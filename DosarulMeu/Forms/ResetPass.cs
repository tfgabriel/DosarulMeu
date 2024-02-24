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
    public partial class ResetPass : Form
    {
        public UserModel user;
        public ResetPass()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginChecks passchecker = new LoginChecks();
            passchecker.verifypass(textBox1.Text);
            if (passchecker.verifypass(textBox1.Text))
            {
                if(textBox1.Text == textBox2.Text)
                {
                    user.Parola = passchecker.HashPassword(textBox1.Text);
                    //adaugat in firebase parola noua
                    
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
    }
}
