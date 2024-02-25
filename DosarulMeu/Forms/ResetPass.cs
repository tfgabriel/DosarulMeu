using DosarulMeu.Models;
using Firebase.Database;
using Firebase.Database.Query;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosarulMeu.Forms
{
    public partial class ResetPass : Form
    {
        public UserModel user;
        public ResetPass()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            LoginChecks passchecker = new LoginChecks();
            passchecker.verifypass(textBox1.Text);
            if (passchecker.verifypass(textBox1.Text))
            {
                if(textBox1.Text == textBox2.Text)
                {
                    user.Parola = passchecker.HashPassword(textBox1.Text);
                    FirebaseClient firebaseClient = new FirebaseClient("https://dosarul-meu-f665c-default-rtdb.europe-west1.firebasedatabase.app/");
                    var res = firebaseClient.Child("Utilizatori").OnceAsync<UserModel>().Result;
                    for (int i =0;i<res.Count;i++)
                    {
                        if (res.ToList()[i].Object.Email == user.Email)
                        {
                            ResetareParola pass = new ResetareParola{ Parola=user.Parola};
                            await firebaseClient.Child("Utilizatori").Child(res.ToList()[i].Key).DeleteAsync();
                            user.Id = res.ToList()[i].Object.Id;
                            user.Nume = res.ToList()[i].Object.Nume;
                            user.CNP = res.ToList()[i].Object.CNP;

                            await firebaseClient.Child("Utilizatori").PostAsync(user); 

                        }
                    }

                    LogIn login = new LogIn();
                    if(login.ShowDialog() == DialogResult.OK)
                    {
                        login.ShowDialog();
                        this.Close();
                        this.Visible = false;
                    }
                }
            }
        }

        private void ResetPass_Load(object sender, EventArgs e)
        {

        }
    }
    public class ResetareParola
    {
        public string Parola;
    }
}
