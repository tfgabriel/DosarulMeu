namespace DosarulMeu.Forms
{
    partial class CreateAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numeTb = new System.Windows.Forms.TextBox();
            this.cnpTb = new System.Windows.Forms.TextBox();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.parolaTb = new System.Windows.Forms.TextBox();
            this.confpassTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numeTb
            // 
            this.numeTb.Location = new System.Drawing.Point(279, 62);
            this.numeTb.Name = "numeTb";
            this.numeTb.Size = new System.Drawing.Size(197, 26);
            this.numeTb.TabIndex = 0;
            // 
            // cnpTb
            // 
            this.cnpTb.Location = new System.Drawing.Point(279, 120);
            this.cnpTb.Name = "cnpTb";
            this.cnpTb.Size = new System.Drawing.Size(197, 26);
            this.cnpTb.TabIndex = 1;
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(279, 183);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(197, 26);
            this.emailTb.TabIndex = 2;
            // 
            // parolaTb
            // 
            this.parolaTb.Location = new System.Drawing.Point(279, 239);
            this.parolaTb.Name = "parolaTb";
            this.parolaTb.PasswordChar = '*';
            this.parolaTb.Size = new System.Drawing.Size(197, 26);
            this.parolaTb.TabIndex = 3;
            // 
            // confpassTb
            // 
            this.confpassTb.Location = new System.Drawing.Point(279, 303);
            this.confpassTb.Name = "confpassTb";
            this.confpassTb.PasswordChar = '*';
            this.confpassTb.Size = new System.Drawing.Size(197, 26);
            this.confpassTb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "CNP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parolă:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Confirmare Parolă:";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(330, 373);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(97, 33);
            this.createBtn.TabIndex = 10;
            this.createBtn.Text = "Creează Cont";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confpassTb);
            this.Controls.Add(this.parolaTb);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.cnpTb);
            this.Controls.Add(this.numeTb);
            this.Name = "CreateAccount";
            this.Text = "Creează Cont";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeTb;
        private System.Windows.Forms.TextBox cnpTb;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.TextBox parolaTb;
        private System.Windows.Forms.TextBox confpassTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createBtn;
    }
}