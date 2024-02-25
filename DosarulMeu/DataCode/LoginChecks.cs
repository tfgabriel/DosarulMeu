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
                    MessageBox.Show("Introdu o adresă de mail validă.");
                    return false;
                }
            }
            catch 
            {
                MessageBox.Show("Introdu o adresă de email validă.");
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
            FirebaseClient firebaseClient = new FirebaseClient("https://dosarul-meu-f665c-default-rtdb.europe-west1.firebasedatabase.app/"); 
            var res = firebaseClient.Child("Utilizatori").OnceAsync<UserModel>().Result;
            for(int i = 0; i < res.Count; ++i)
            {
                if(user.Email == res.ToList()[i].Object.Email)
                {
                    if(user.Parola == res.ToList()[i].Object.Parola)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Parola invalida.");
                        return false;
                    }
                }
                

            }
            MessageBox.Show("Email invalid.");
            return false;
        }

        public UserModel getuserindatabase(UserModel user)
        {
            UserModel usermodel = new UserModel();

            FirebaseClient firebaseClient = new FirebaseClient("https://dosarul-meu-f665c-default-rtdb.europe-west1.firebasedatabase.app/");
            var res = firebaseClient.Child("Utilizatori").OnceAsync<UserModel>().Result;
            for (int i = 0; i < res.Count; i++)
            {
                if (user.Email == res.ToList()[i].Object.Email)
                {
                    if (user.Parola == res.ToList()[i].Object.Parola)
                    {
                        usermodel = new UserModel
                        {
                            Nume = res.ToList()[i].Object.Nume,
                            CNP = res.ToList()[i].Object.CNP,
                            Email = res.ToList()[i].Object.Email,
                            Parola = res.ToList()[i].Object.Parola
                        };
                    }
                }
            }

            return usermodel;
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