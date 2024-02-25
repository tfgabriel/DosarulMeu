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
    public partial class DosarulMeuMain : Form
    {
        public UserModel user;
        public DosarulMeuMain()
        {
            InitializeComponent();
            infoPnl.Visible = false;
        }

        private void DosarulMeuMain_Load(object sender, EventArgs e)
        {
            label1.Text = "Buna, " + user.Nume + "!";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            infoPnl.Visible = false;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTb.Text))
            {
                MessageBox.Show("Adauga un numar de inregistrare.");
            }
            else
            {
                DocumentCheck documentCheck = new DocumentCheck();
                DocumentModel documentModel = documentCheck.checkdocument(searchTb.Text);
                if(documentModel.NrReg == searchTb.Text)
                {
                    infoPnl.Visible = true;
                    label4.Text = documentModel.TipDocument;
                    label6.Text = documentModel.Status;
                    label8.Text = documentModel.InfoAdd;
                }
            }
        }

        private void newdocBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
