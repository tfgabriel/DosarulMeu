using DosarulMeu.Models;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DosarulMeu
{
    public class LoginChecks
    {
        public bool checklogininfo(string email, string password)
        {
            
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Introdu adresa de email.");
                return false;
            }

            try
            {
                var mailaddress = new MailAddress(email);
                if(email == mailaddress.Address)
                {
                    if(verifypass(password))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Introdu o adresa de mail valida.");
                    return false;
                }
            }
            catch 
            {
                MessageBox.Show("Introdu o adresa de email valida.");
                return false;
            }


           
        }

        public bool verifypass(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Introdu o parola.");
                return false;

            } else if (password.Length < 8 || password.Length > 16)
            {
                MessageBox.Show("Parola are intre 8 si 16 caractere.");
                return false;
            } 
            else if (!checkpasswordchars(password))
            {
                MessageBox.Show("Parola trebuie sa contina cel putin un caracter special, o cifra si o litera mare.");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool checkpasswordchars(string password)
        {
            bool isCapital = false;
            bool isSpecialChar = false;
            bool isNumber = false;

            foreach(char c in password)
            {
                if(c >= 'A' && c <= 'Z')
                    isCapital = true;
                if(c >= '0' && c <= '9')
                    isNumber = true;
                if (c >= 33 && c <= 49)
                    isSpecialChar = true;

            }

            return isCapital && isNumber && isSpecialChar;
        }

        
        public bool checkindatabase(UserModel user)
        {
            if (user == null)
            {
                MessageBox.Show("Date credentiale invalide.");
                return false;
            }
            else
            {
                FirebaseClient firebaseClient = new FirebaseClient("https://dosarul-meu-f665c-default-rtdb.europe-west1.firebasedatabase.app/");
                var res = firebaseClient.Child("Utilizatori").OnceAsync<UserModel>().Result;
                for (int i = 0; i < res.Count; i++)
                {
                    if(user.Email == res.ToList()[i].Object.Email.ToString())
                    {
                        if(user.Parola == res.ToList()[i].Object.Parola.ToString())
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Parola incorecta.");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email incorect.");
                        return false;
                    }
                }

                return false;
            }
        }

        public string HashPassword(string passsword)
        {
            using (var h = SHA256.Create())
            {
                byte[] bytes = h.ComputeHash(Encoding.UTF8.GetBytes(passsword));

            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }

            return sb.ToString();

            }
            
        }
    }
}