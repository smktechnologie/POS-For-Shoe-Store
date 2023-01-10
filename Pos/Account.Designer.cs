namespace Pos
{
    partial class Accounts
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
            this.lblbalance = new System.Windows.Forms.Label();
            this.txtbxbalance = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lbl_adesc = new System.Windows.Forms.Label();
            this.txtbx_address = new System.Windows.Forms.TextBox();
            this.lbl_aname = new System.Windows.Forms.Label();
            this.txtbx_aname = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtbx_aname_search = new System.Windows.Forms.TextBox();
            this.dg_account = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_AccType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccID = new System.Windows.Forms.TextBox();
            this.cmbbxtype = new System.Windows.Forms.ComboBox();
            this.cmbbxtypesrch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblphn = new System.Windows.Forms.Label();
            this.txtbxPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_account)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbalance
            // 
            this.lblbalance.AutoSize = true;
            this.lblbalance.Location = new System.Drawing.Point(10, 107);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(75, 13);
            this.lblbalance.TabIndex = 27;
            this.lblbalance.Text = "Open Balance";
            // 
            // txtbxbalance
            // 
            this.txtbxbalance.Location = new System.Drawing.Point(116, 104);
            this.txtbxbalance.Name = "txtbxbalance";
            this.txtbxbalance.Size = new System.Drawing.Size(100, 20);
            this.txtbxbalance.TabIndex = 26;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 189);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(97, 189);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 24;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lbl_adesc
            // 
            this.lbl_adesc.AutoSize = true;
            this.lbl_adesc.Location = new System.Drawing.Point(10, 134);
            this.lbl_adesc.Name = "lbl_adesc";
            this.lbl_adesc.Size = new System.Drawing.Size(45, 13);
            this.lbl_adesc.TabIndex = 21;
            this.lbl_adesc.Text = "Address";
            // 
            // txtbx_address
            // 
            this.txtbx_address.Location = new System.Drawing.Point(116, 131);
            this.txtbx_address.Name = "txtbx_address";
            this.txtbx_address.Size = new System.Drawing.Size(100, 20);
            this.txtbx_address.TabIndex = 20;
            // 
            // lbl_aname
            // 
            this.lbl_aname.AutoSize = true;
            this.lbl_aname.Location = new System.Drawing.Point(10, 79);
            this.lbl_aname.Name = "lbl_aname";
            this.lbl_aname.Size = new System.Drawing.Size(78, 13);
            this.lbl_aname.TabIndex = 19;
            this.lbl_aname.Text = "Account Name";
            // 
            // txtbx_aname
            // 
            this.txtbx_aname.Location = new System.Drawing.Point(116, 76);
            this.txtbx_aname.Name = "txtbx_aname";
            this.txtbx_aname.Size = new System.Drawing.Size(100, 20);
            this.txtbx_aname.TabIndex = 18;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(16, 189);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 17;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtbx_aname_search
            // 
            this.txtbx_aname_search.Location = new System.Drawing.Point(607, 34);
            this.txtbx_aname_search.Name = "txtbx_aname_search";
            this.txtbx_aname_search.Size = new System.Drawing.Size(100, 20);
            this.txtbx_aname_search.TabIndex = 16;
            // 
            // dg_account
            // 
            this.dg_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_account.Location = new System.Drawing.Point(341, 60);
            this.dg_account.Name = "dg_account";
            this.dg_account.Size = new System.Drawing.Size(447, 150);
            this.dg_account.TabIndex = 15;
            this.dg_account.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_account_CellClick);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(713, 31);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_AccType
            // 
            this.lbl_AccType.AutoSize = true;
            this.lbl_AccType.Location = new System.Drawing.Point(12, 53);
            this.lbl_AccType.Name = "lbl_AccType";
            this.lbl_AccType.Size = new System.Drawing.Size(74, 13);
            this.lbl_AccType.TabIndex = 23;
            this.lbl_AccType.Text = "Account Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Account ID";
            // 
            // txtAccID
            // 
            this.txtAccID.Enabled = false;
            this.txtAccID.Location = new System.Drawing.Point(116, 27);
            this.txtAccID.Name = "txtAccID";
            this.txtAccID.Size = new System.Drawing.Size(100, 20);
            this.txtAccID.TabIndex = 28;
            // 
            // cmbbxtype
            // 
            this.cmbbxtype.FormattingEnabled = true;
            this.cmbbxtype.Items.AddRange(new object[] {
            "Employee",
            "Purchase",
            "Customer",
            "Default"});
            this.cmbbxtype.Location = new System.Drawing.Point(116, 50);
            this.cmbbxtype.Name = "cmbbxtype";
            this.cmbbxtype.Size = new System.Drawing.Size(100, 21);
            this.cmbbxtype.TabIndex = 30;
            // 
            // cmbbxtypesrch
            // 
            this.cmbbxtypesrch.FormattingEnabled = true;
            this.cmbbxtypesrch.Items.AddRange(new object[] {
            "Employee",
            "Purchase",
            "Customer",
            "Default"});
            this.cmbbxtypesrch.Location = new System.Drawing.Point(501, 33);
            this.cmbbxtypesrch.Name = "cmbbxtypesrch";
            this.cmbbxtypesrch.Size = new System.Drawing.Size(100, 21);
            this.cmbbxtypesrch.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Account Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Account Type";
            // 
            // lblphn
            // 
            this.lblphn.AutoSize = true;
            this.lblphn.Location = new System.Drawing.Point(10, 160);
            this.lblphn.Name = "lblphn";
            this.lblphn.Size = new System.Drawing.Size(38, 13);
            this.lblphn.TabIndex = 35;
            this.lblphn.Text = "Phone";
            // 
            // txtbxPhone
            // 
            this.txtbxPhone.Location = new System.Drawing.Point(116, 157);
            this.txtbxPhone.Name = "txtbxPhone";
            this.txtbxPhone.Size = new System.Drawing.Size(100, 20);
            this.txtbxPhone.TabIndex = 34;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 241);
            this.Controls.Add(this.lblphn);
            this.Controls.Add(this.txtbxPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbbxtypesrch);
            this.Controls.Add(this.cmbbxtype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccID);
            this.Controls.Add(this.lblbalance);
            this.Controls.Add(this.txtbxbalance);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.lbl_AccType);
            this.Controls.Add(this.lbl_adesc);
            this.Controls.Add(this.txtbx_address);
            this.Controls.Add(this.lbl_aname);
            this.Controls.Add(this.txtbx_aname);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtbx_aname_search);
            this.Controls.Add(this.dg_account);
            this.Controls.Add(this.btn_search);
            this.Name = "Accounts";
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbalance;
        private System.Windows.Forms.TextBox txtbxbalance;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label lbl_adesc;
        private System.Windows.Forms.TextBox txtbx_address;
        private System.Windows.Forms.Label lbl_aname;
        private System.Windows.Forms.TextBox txtbx_aname;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtbx_aname_search;
        private System.Windows.Forms.DataGridView dg_account;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_AccType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccID;
        private System.Windows.Forms.ComboBox cmbbxtype;
        private System.Windows.Forms.ComboBox cmbbxtypesrch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblphn;
        private System.Windows.Forms.TextBox txtbxPhone;
    }
}