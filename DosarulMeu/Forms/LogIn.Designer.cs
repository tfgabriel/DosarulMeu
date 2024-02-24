namespace DosarulMeu
{
    partial class LogIn
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
            this.emailLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.emailTbx = new System.Windows.Forms.TextBox();
            this.passTbx = new System.Windows.Forms.TextBox();
            this.forgotpassLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(305, 68);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(52, 20);
            this.emailLbl.TabIndex = 0;
            this.emailLbl.Text = "Email:";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(305, 154);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(58, 20);
            this.passLbl.TabIndex = 1;
            this.passLbl.Text = "Parolă:";
            // 
            // emailTbx
            // 
            this.emailTbx.Location = new System.Drawing.Point(309, 92);
            this.emailTbx.Name = "emailTbx";
            this.emailTbx.Size = new System.Drawing.Size(187, 26);
            this.emailTbx.TabIndex = 2;
            // 
            // passTbx
            // 
            this.passTbx.Location = new System.Drawing.Point(309, 177);
            this.passTbx.Name = "passTbx";
            this.passTbx.PasswordChar = '*';
            this.passTbx.Size = new System.Drawing.Size(187, 26);
            this.passTbx.TabIndex = 3;
            // 
            // forgotpassLbl
            // 
            this.forgotpassLbl.AutoSize = true;
            this.forgotpassLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpassLbl.Location = new System.Drawing.Point(337, 219);
            this.forgotpassLbl.Name = "forgotpassLbl";
            this.forgotpassLbl.Size = new System.Drawing.Size(116, 20);
            this.forgotpassLbl.TabIndex = 4;
            this.forgotpassLbl.Text = "Am uitat parola";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(309, 263);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(421, 263);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "Creează Cont";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.forgotpassLbl);
            this.Controls.Add(this.passTbx);
            this.Controls.Add(this.emailTbx);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.emailLbl);
            this.Name = "LogIn";
            this.Text = "Dosarul Meu - Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.TextBox emailTbx;
        private System.Windows.Forms.TextBox passTbx;
        private System.Windows.Forms.Label forgotpassLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button createBtn;
    }
}

