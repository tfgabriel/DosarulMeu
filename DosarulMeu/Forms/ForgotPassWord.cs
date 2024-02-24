using DosarulMeu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosarulMeu.Forms
{
    public partial class ForgotPassWord : Form
    {
        public UserModel user;
        public ForgotPassWord()
        {
            InitializeComponent();
            timer1.Enabled = false;
        }

        private int code;
        private int minutes = 1;
        private DateTime endTime;
        

        private void sendcodeBtn_Click(object sender, EventArgs e)
        {
            SendEmail sendEmail = new SendEmail();
            sendEmail.Email(emailTbx2.Text);
            code = sendEmail.randomcode();

            DateTime start = DateTime.UtcNow; 
            endTime = start.AddMinutes(minutes);
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(insertcodeTbx.Text == code.ToString())
            {
                ResetPass resetpass = new ResetPass
                {
                    user = user
                };

                if(resetpass.ShowDialog() == DialogResult.OK)
                {
                    ShowDialog(resetpass);
                    this.Close();
                    this.Visible = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = endTime - DateTime.UtcNow;
            if (remainingTime < TimeSpan.Zero)
            {
                sendcodeBtn.Text = "Trimite Cod";
                timer1.Enabled = false;
            }
            else
            {
                sendcodeBtn.Text = "Trimite Cod" + remainingTime.ToString();
            }
        }

        private void ForgotPassWord_Load(object sender, EventArgs e)
        {

        }
    }
}
