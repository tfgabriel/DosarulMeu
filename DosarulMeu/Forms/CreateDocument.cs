using DosarulMeu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Storage;
using Firebase.Database;

namespace DosarulMeu.Forms
{
    public partial class CreateDocument : Form
    {
        public UserModel user;

        public string docname;
        public CreateDocument()
        {
            InitializeComponent();
        }

        private void CreateDocument_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            comboBox1.Items.Add("Fișă consultație");
            comboBox1.Items.Add("Recomandare doctor specialist");
            comboBox1.Items.Add("Rețetă farmacie");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Fișă consultație")
            {
                panel1.Visible = true;
                label2.Text = "Parafă doctor";
                label3.Text = "Buletin";
                label4.Text = "Certificat de nașstere";
            }
        }

        private void attachfilesBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                docname = openFileDialog1.FileName;
            }
        }

        private void finBtn_Click(object sender, EventArgs e)
        {
            

            DocumentCreate documentCreate = new DocumentCreate();
            DocumentModel newdocument = documentCreate.newdoc(user.CNP, comboBox1.SelectedItem.ToString());
            stam(newdocument.NumeFisier);

            DocumentCheck documentCheck = new DocumentCheck();
            documentCheck.adddoc(newdocument);
            
        }
        private async void stam(string numf)
        {
            var strea1m = File.Open(docname, FileMode.Open);
            var task = new FirebaseStorage("dosarul-meu-f665c.appspot.com")
                .Child(numf+".pdf")
                .PutAsync(strea1m);

            task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");
        }


    }
}
