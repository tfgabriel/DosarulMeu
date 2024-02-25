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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassWord));
            this.emailTbx2 = new System.Windows.Forms.TextBox();
            this.insertcodeTbx = new System.Windows.Forms.TextBox();
            this.sendcodeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailTbx2
            // 
            this.emailTbx2.Location = new System.Drawing.Point(252, 76);
            this.emailTbx2.Name = "emailTbx2";
            this.emailTbx2.Size = new System.Drawing.Size(184, 26);
            this.emailTbx2.TabIndex = 9;
            // 
            // insertcodeTbx
            // 
            this.insertcodeTbx.Location = new System.Drawing.Point(252, 121);
            this.insertcodeTbx.Name = "insertcodeTbx";
            this.insertcodeTbx.Size = new System.Drawing.Size(184, 26);
            this.insertcodeTbx.TabIndex = 10;
            // 
            // sendcodeBtn
            // 
            this.sendcodeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sendcodeBtn.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendcodeBtn.Location = new System.Drawing.Point(454, 76);
            this.sendcodeBtn.Name = "sendcodeBtn";
            this.sendcodeBtn.Size = new System.Drawing.Size(286, 31);
            this.sendcodeBtn.TabIndex = 11;
            this.sendcodeBtn.Text = "Trimite Cod";
            this.sendcodeBtn.UseVisualStyleBackColor = false;
            this.sendcodeBtn.Click += new System.EventHandler(this.sendcodeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Îți vom trimite un cod de 6 cifre pe adresa ta de email. ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(505, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 34);
            this.button1.TabIndex = 14;
            this.button1.Text = "Verifică codul";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ForgotPassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 260);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sendcodeBtn);
            this.Controls.Add(this.insertcodeTbx);
            this.Controls.Add(this.emailTbx2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassWord";
            this.Text = "Mail de resetare";
            this.Load += new System.EventHandler(this.ForgotPassWord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}