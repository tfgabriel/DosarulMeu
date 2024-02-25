using DosarulMeu.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DosarulMeu;
using DosarulMeu.Models;

namespace DosarulMeu
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            if(createAccount.ShowDialog() == DialogResult.OK)
            {
                this.Hide();
                createAccount.ShowDialog();
                this.Close();
            }
            
        }

        private void forgotpassLbl_Click(object sender, EventArgs e)
        {
            UserModel model = new UserModel();
            model.Email=emailTbx.Text;
            ForgotPassWord forgotpass = new ForgotPassWord{ user=model };
            if(forgotpass.ShowDialog() == DialogResult.OK )
            {
                this.Hide();
                forgotpass.ShowDialog();
                this.Close();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginChecks loginchecker = new LoginChecks();
            loginchecker.checklogininfo(emailTbx.Text, passTbx.Text);
            if(loginchecker.checklogininfo(emailTbx.Text, passTbx.Text))
            {
                UserModel user = new UserModel
                {
                    Email = emailTbx.Text,
                    Parola = loginchecker.HashPassword(passTbx.Text)
                };

                
                if (loginchecker.checkindatabase(user))
                {
                    user = loginchecker.getuserindatabase(user);
                    DosarulMeuMain main = new DosarulMeuMain
                    {
                        user = user
                    };
                    if (main.ShowDialog() == DialogResult.OK)
                    {
                        this.Hide();
                        main.ShowDialog();              
                        this.Close();
                    }
                }
            }
        }
    }
}
