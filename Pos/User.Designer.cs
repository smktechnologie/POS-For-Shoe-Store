namespace Pos
{
    partial class User
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
            this.lblIsActive = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtbxpassword = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtbx_name_search = new System.Windows.Forms.TextBox();
            this.dg_users = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.chkbxactive = new System.Windows.Forms.CheckBox();
            this.chkbxisadmin = new System.Windows.Forms.CheckBox();
            this.lblisadmin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_users)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Location = new System.Drawing.Point(25, 159);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(48, 13);
            this.lblIsActive.TabIndex = 27;
            this.lblIsActive.Text = "Is Active";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(201, 208);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(120, 208);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 24;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(27, 104);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 13);
            this.lblUsername.TabIndex = 23;
            this.lblUsername.Text = "User Name";
            // 
            // txtbx_username
            // 
            this.txtbx_username.Location = new System.Drawing.Point(128, 101);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(100, 20);
            this.txtbx_username.TabIndex = 22;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(25, 132);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 19;
            this.lbl_password.Text = "Password";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbxpassword
            // 
            this.txtbxpassword.Location = new System.Drawing.Point(128, 127);
            this.txtbxpassword.Name = "txtbxpassword";
            this.txtbxpassword.Size = new System.Drawing.Size(100, 20);
            this.txtbxpassword.TabIndex = 18;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(39, 208);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtbx_name_search
            // 
            this.txtbx_name_search.Location = new System.Drawing.Point(619, 64);
            this.txtbx_name_search.Name = "txtbx_name_search";
            this.txtbx_name_search.Size = new System.Drawing.Size(100, 20);
            this.txtbx_name_search.TabIndex = 16;
            // 
            // dg_users
            // 
            this.dg_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_users.Location = new System.Drawing.Point(353, 90);
            this.dg_users.Name = "dg_users";
            this.dg_users.Size = new System.Drawing.Size(447, 150);
            this.dg_users.TabIndex = 15;
            this.dg_users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_users_CellClick);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(725, 61);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // chkbxactive
            // 
            this.chkbxactive.AutoSize = true;
            this.chkbxactive.Location = new System.Drawing.Point(128, 159);
            this.chkbxactive.Name = "chkbxactive";
            this.chkbxactive.Size = new System.Drawing.Size(15, 14);
            this.chkbxactive.TabIndex = 28;
            this.chkbxactive.UseVisualStyleBackColor = true;
            // 
            // chkbxisadmin
            // 
            this.chkbxisadmin.AutoSize = true;
            this.chkbxisadmin.Location = new System.Drawing.Point(128, 183);
            this.chkbxisadmin.Name = "chkbxisadmin";
            this.chkbxisadmin.Size = new System.Drawing.Size(15, 14);
            this.chkbxisadmin.TabIndex = 30;
            this.chkbxisadmin.UseVisualStyleBackColor = true;
            // 
            // lblisadmin
            // 
            this.lblisadmin.AutoSize = true;
            this.lblisadmin.Location = new System.Drawing.Point(26, 183);
            this.lblisadmin.Name = "lblisadmin";
            this.lblisadmin.Size = new System.Drawing.Size(47, 13);
            this.lblisadmin.TabIndex = 29;
            this.lblisadmin.Text = "Is Admin";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 299);
            this.Controls.Add(this.chkbxisadmin);
            this.Controls.Add(this.lblisadmin);
            this.Controls.Add(this.chkbxactive);
            this.Controls.Add(this.lblIsActive);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtbx_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txtbxpassword);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtbx_name_search);
            this.Controls.Add(this.dg_users);
            this.Controls.Add(this.btn_search);
            this.Name = "User";
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.dg_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtbx_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtbxpassword;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtbx_name_search;
        private System.Windows.Forms.DataGridView dg_users;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.CheckBox chkbxactive;
        private System.Windows.Forms.CheckBox chkbxisadmin;
        private System.Windows.Forms.Label lblisadmin;
    }
}