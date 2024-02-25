using DosarulMeu.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosarulMeu.Forms
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            
            if(string.IsNullOrWhiteSpace(numeTb.Text) || string.IsNullOrWhiteSpace(cnpTb.Text) || string.IsNullOrWhiteSpace(emailTb.Text) || string.IsNullOrWhiteSpace(parolaTb.Text))
            {
                MessageBox.Show("Completeaza toate spatiile.");
                
            }
            else
            {
                LoginChecks createaccount = new LoginChecks();
                createaccount.checklogininfo(emailTb.Text, parolaTb.Text);
                if(parolaTb.Text == confpassTb.Text )
                {
                    FirebaseClient firebaseClient = new FirebaseClient("https://dosarul-meu-f665c-default-rtdb.europe-west1.firebasedatabase.app/");
                    var res = firebaseClient.Child("Utilizatori").OnceAsync<UserModel>().Result;

                    UserModel user = new UserModel
                    {
                        Nume = numeTb.Text,
                        Parola = createaccount.HashPassword(parolaTb.Text),
                        CNP = Int32.Parse(cnpTb.Text),
                        Email = emailTb.Text,

                        Id = (res.Count+1)

                    };

                    firebaseClient.Child("Utilizatori").PostAsync(user);

                    LogIn logIn = new LogIn();
                    if(logIn.ShowDialog() == DialogResult.OK)
                    {
                        logIn.ShowDialog();
                        this.Close();
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Reintrodu parola.");
                }
            }
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        
    }
        
}
