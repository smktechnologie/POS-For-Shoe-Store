namespace Pos
{
    partial class Login
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
            this.txtbxUserName = new System.Windows.Forms.TextBox();
            this.txtbxpassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.gbbxLogin = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbbxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbxUserName
            // 
            this.txtbxUserName.Location = new System.Drawing.Point(96, 31);
            this.txtbxUserName.Name = "txtbxUserName";
            this.txtbxUserName.Size = new System.Drawing.Size(100, 20);
            this.txtbxUserName.TabIndex = 0;
            // 
            // txtbxpassword
            // 
            this.txtbxpassword.Location = new System.Drawing.Point(96, 67);
            this.txtbxpassword.Name = "txtbxpassword";
            this.txtbxpassword.Size = new System.Drawing.Size(100, 20);
            this.txtbxpassword.TabIndex = 1;
            this.txtbxpassword.UseSystemPasswordChar = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(21, 38);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(21, 74);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // gbbxLogin
            // 
            this.gbbxLogin.Controls.Add(this.btnSubmit);
            this.gbbxLogin.Controls.Add(this.lblPassword);
            this.gbbxLogin.Controls.Add(this.txtbxpassword);
            this.gbbxLogin.Controls.Add(this.lblUserName);
            this.gbbxLogin.Controls.Add(this.txtbxUserName);
            this.gbbxLogin.Location = new System.Drawing.Point(81, 64);
            this.gbbxLogin.Name = "gbbxLogin";
            this.gbbxLogin.Size = new System.Drawing.Size(224, 160);
            this.gbbxLogin.TabIndex = 4;
            this.gbbxLogin.TabStop = false;
            this.gbbxLogin.Text = "Login";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(121, 104);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Login";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 320);
            this.Controls.Add(this.gbbxLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.gbbxLogin.ResumeLayout(false);
            this.gbbxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxUserName;
        private System.Windows.Forms.TextBox txtbxpassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox gbbxLogin;
        private System.Windows.Forms.Button btnSubmit;
    }
}