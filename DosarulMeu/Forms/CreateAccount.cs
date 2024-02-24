using DosarulMeu.Models;
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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            LoginChecks createaccount = new LoginChecks();
            if(string.IsNullOrWhiteSpace(numeTb.Text) || string.IsNullOrWhiteSpace(cnpTb.Text) || string.IsNullOrWhiteSpace(emailTb.Text) || string.IsNullOrWhiteSpace(parolaTb.Text))
            {
                createaccount.checklogininfo(emailTb.Text, parolaTb.Text);
                if(parolaTb.Text == confpassTb.Text )
                {

                    UserModel user = new UserModel
                    {
                        Nume = numeTb.Text,
                        Parola = parolaTb.Text,
                        CNP = cnpTb.Text,
                        Email = emailTb.Text,
                        //add id
                        //add user to firebase

                    };

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
            else
            {
                MessageBox.Show("Completeaza toate spatiile.");
            }
        }
    }
}
