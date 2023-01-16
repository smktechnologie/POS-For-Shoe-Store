namespace Pos
{
    partial class ViewTransations
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
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtfrom = new System.Windows.Forms.DateTimePicker();
            this.chkbxdate = new System.Windows.Forms.CheckBox();
            this.cmbbxAccount = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lbl_AccType = new System.Windows.Forms.Label();
            this.cmbbxtype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgResults
            // 
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Location = new System.Drawing.Point(12, 99);
            this.dgResults.Name = "dgResults";
            this.dgResults.Size = new System.Drawing.Size(776, 339);
            this.dgResults.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.dtfrom);
            this.groupBox1.Controls.Add(this.chkbxdate);
            this.groupBox1.Controls.Add(this.cmbbxAccount);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblAccount);
            this.groupBox1.Controls.Add(this.lbl_AccType);
            this.groupBox1.Controls.Add(this.cmbbxtype);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Transactions";
            // 
            // dtTo
            // 
            this.dtTo.Enabled = false;
            this.dtTo.Location = new System.Drawing.Point(489, 46);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 20);
            this.dtTo.TabIndex = 47;
            // 
            // dtfrom
            // 
            this.dtfrom.CustomFormat = "";
            this.dtfrom.Enabled = false;
            this.dtfrom.Location = new System.Drawing.Point(489, 19);
            this.dtfrom.Name = "dtfrom";
            this.dtfrom.Size = new System.Drawing.Size(200, 20);
            this.dtfrom.TabIndex = 46;
            // 
            // chkbxdate
            // 
            this.chkbxdate.AutoSize = true;
            this.chkbxdate.Location = new System.Drawing.Point(405, 32);
            this.chkbxdate.Name = "chkbxdate";
            this.chkbxdate.Size = new System.Drawing.Size(71, 17);
            this.chkbxdate.TabIndex = 45;
            this.chkbxdate.Text = "Use Date";
            this.chkbxdate.UseVisualStyleBackColor = true;
            this.chkbxdate.CheckedChanged += new System.EventHandler(this.chkbxdate_CheckedChanged);
            // 
            // cmbbxAccount
            // 
            this.cmbbxAccount.FormattingEnabled = true;
            this.cmbbxAccount.Location = new System.Drawing.Point(280, 28);
            this.cmbbxAccount.Name = "cmbbxAccount";
            this.cmbbxAccount.Size = new System.Drawing.Size(100, 21);
            this.cmbbxAccount.TabIndex = 44;
            this.cmbbxAccount.Text = "Select Account";
            this.cmbbxAccount.SelectionChangeCommitted += new System.EventHandler(this.cmbbxAccount_SelectionChangeCommitted);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(695, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(194, 31);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(80, 13);
            this.lblAccount.TabIndex = 43;
            this.lblAccount.Text = "Select Account";
            // 
            // lbl_AccType
            // 
            this.lbl_AccType.AutoSize = true;
            this.lbl_AccType.Location = new System.Drawing.Point(6, 32);
            this.lbl_AccType.Name = "lbl_AccType";
            this.lbl_AccType.Size = new System.Drawing.Size(74, 13);
            this.lbl_AccType.TabIndex = 41;
            this.lbl_AccType.Text = "Account Type";
            // 
            // cmbbxtype
            // 
            this.cmbbxtype.FormattingEnabled = true;
            this.cmbbxtype.Items.AddRange(new object[] {
            "Employee",
            "Purchase",
            "Customer",
            "Default"});
            this.cmbbxtype.Location = new System.Drawing.Point(86, 29);
            this.cmbbxtype.Name = "cmbbxtype";
            this.cmbbxtype.Size = new System.Drawing.Size(100, 21);
            this.cmbbxtype.TabIndex = 42;
            this.cmbbxtype.Text = "Select Type";
            this.cmbbxtype.SelectedIndexChanged += new System.EventHandler(this.cmbbxtype_SelectedIndexChanged);
            // 
            // ViewTransations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgResults);
            this.Name = "ViewTransations";
            this.Text = "View Transations";
            this.Load += new System.EventHandler(this.ViewTransations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbbxAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ComboBox cmbbxtype;
        private System.Windows.Forms.Label lbl_AccType;
        private System.Windows.Forms.CheckBox chkbxdate;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtfrom;
    }
}