namespace DosarulMeu.Forms
{
    partial class ForgotPassWord
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
            this.components = new System.ComponentModel.Container();
            this.emailTbx2 = new System.Windows.Forms.TextBox();
            this.insertcodeTbx = new System.Windows.Forms.TextBox();
            this.sendcodeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // emailTbx2
            // 
            this.emailTbx2.Location = new System.Drawing.Point(320, 67);
            this.emailTbx2.Name = "emailTbx2";
            this.emailTbx2.Size = new System.Drawing.Size(184, 26);
            this.emailTbx2.TabIndex = 9;
            // 
            // insertcodeTbx
            // 
            this.insertcodeTbx.Location = new System.Drawing.Point(320, 111);
            this.insertcodeTbx.Name = "insertcodeTbx";
            this.insertcodeTbx.Size = new System.Drawing.Size(184, 26);
            this.insertcodeTbx.TabIndex = 10;
            // 
            // sendcodeBtn
            // 
            this.sendcodeBtn.Location = new System.Drawing.Point(232, 162);
            this.sendcodeBtn.Name = "sendcodeBtn";
            this.sendcodeBtn.Size = new System.Drawing.Size(126, 29);
            this.sendcodeBtn.TabIndex = 11;
            this.sendcodeBtn.Text = "Trimite Cod";
            this.sendcodeBtn.UseVisualStyleBackColor = true;
            this.sendcodeBtn.Click += new System.EventHandler(this.sendcodeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Îți vom trimite un cod de 6 cifre pe adresa ta de email. ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Verifică codul";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ForgotPassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sendcodeBtn);
            this.Controls.Add(this.insertcodeTbx);
            this.Controls.Add(this.emailTbx2);
            this.Name = "ForgotPassWord";
            this.Text = "Mail de resetare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailTbx2;
        private System.Windows.Forms.TextBox insertcodeTbx;
        private System.Windows.Forms.Button sendcodeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}