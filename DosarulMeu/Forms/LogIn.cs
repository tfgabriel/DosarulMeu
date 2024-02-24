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

        }

        private void forgotpassLbl_Click(object sender, EventArgs e)
        {
            ForgotPassWord forgotpass = new ForgotPassWord();
            if(forgotpass.ShowDialog() == DialogResult.OK )
            {
                this.Close();
                forgotpass.ShowDialog();
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

                loginchecker.checkindatabase(user);
                if (loginchecker.checkindatabase(user))
                {
                    DosarulMeuMain main = new DosarulMeuMain();
                    if (main.ShowDialog() == DialogResult.OK)
                    {
                        this.Close();
                        main.ShowDialog();
                    }
                }
            }
        }
    }
}
