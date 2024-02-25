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
            this.emailLbl.BackColor = System.Drawing.Color.Transparent;
            this.emailLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.Location = new System.Drawing.Point(305, 68);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(58, 25);
            this.emailLbl.TabIndex = 0;
            this.emailLbl.Text = "Email:";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.Location = new System.Drawing.Point(305, 154);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(64, 25);
            this.passLbl.TabIndex = 1;
            this.passLbl.Text = "Parolă:";
            // 
            // emailTbx
            // 
            this.emailTbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTbx.Location = new System.Drawing.Point(310, 92);
            this.emailTbx.Name = "emailTbx";
            this.emailTbx.Size = new System.Drawing.Size(180, 26);
            this.emailTbx.TabIndex = 2;
            // 
            // passTbx
            // 
            this.passTbx.Location = new System.Drawing.Point(310, 177);
            this.passTbx.Name = "passTbx";
            this.passTbx.PasswordChar = '*';
            this.passTbx.Size = new System.Drawing.Size(185, 26);
            this.passTbx.TabIndex = 3;
            // 
            // forgotpassLbl
            // 
            this.forgotpassLbl.AutoSize = true;
            this.forgotpassLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotpassLbl.Location = new System.Drawing.Point(332, 218);
            this.forgotpassLbl.Name = "forgotpassLbl";
            this.forgotpassLbl.Size = new System.Drawing.Size(135, 25);
            this.forgotpassLbl.TabIndex = 4;
            this.forgotpassLbl.Text = "Am uitat parola";
            this.forgotpassLbl.Click += new System.EventHandler(this.forgotpassLbl_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(248, 263);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(132, 35);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(409, 263);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(139, 35);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "Creează Cont";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
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

