namespace Pos
{
    partial class AccountTransaction
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
            this.gbbxtransaction = new System.Windows.Forms.GroupBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtbxDesc = new System.Windows.Forms.TextBox();
            this.cmbbxAccount = new System.Windows.Forms.ComboBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtbxBal = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtbxAmount = new System.Windows.Forms.TextBox();
            this.cmbbxtype = new System.Windows.Forms.ComboBox();
            this.lbl_AccType = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbbxtransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbbxtransaction
            // 
            this.gbbxtransaction.Controls.Add(this.lblDesc);
            this.gbbxtransaction.Controls.Add(this.txtbxDesc);
            this.gbbxtransaction.Controls.Add(this.cmbbxAccount);
            this.gbbxtransaction.Controls.Add(this.lblAccount);
            this.gbbxtransaction.Controls.Add(this.lblBalance);
            this.gbbxtransaction.Controls.Add(this.txtbxBal);
            this.gbbxtransaction.Controls.Add(this.lblAmount);
            this.gbbxtransaction.Controls.Add(this.txtbxAmount);
            this.gbbxtransaction.Controls.Add(this.cmbbxtype);
            this.gbbxtransaction.Controls.Add(this.lbl_AccType);
            this.gbbxtransaction.Controls.Add(this.btnSubmit);
            this.gbbxtransaction.Location = new System.Drawing.Point(31, 47);
            this.gbbxtransaction.Name = "gbbxtransaction";
            this.gbbxtransaction.Size = new System.Drawing.Size(409, 372);
            this.gbbxtransaction.TabIndex = 5;
            this.gbbxtransaction.TabStop = false;
            this.gbbxtransaction.Text = "Add Transaction";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(13, 178);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 42;
            this.lblDesc.Text = "Description";
            // 
            // txtbxDesc
            // 
            this.txtbxDesc.Location = new System.Drawing.Point(117, 175);
            this.txtbxDesc.Multiline = true;
            this.txtbxDesc.Name = "txtbxDesc";
            this.txtbxDesc.Size = new System.Drawing.Size(219, 54);
            this.txtbxDesc.TabIndex = 41;
            // 
            // cmbbxAccount
            // 
            this.cmbbxAccount.FormattingEnabled = true;
            this.cmbbxAccount.Location = new System.Drawing.Point(117, 68);
            this.cmbbxAccount.Name = "cmbbxAccount";
            this.cmbbxAccount.Size = new System.Drawing.Size(100, 21);
            this.cmbbxAccount.TabIndex = 40;
            this.cmbbxAccount.Text = "Select Account";
            this.cmbbxAccount.SelectionChangeCommitted += new System.EventHandler(this.cmbbxAccount_SelectionChangeCommitted);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(13, 71);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(80, 13);
            this.lblAccount.TabIndex = 39;
            this.lblAccount.Text = "Select Account";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(13, 109);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(46, 13);
            this.lblBalance.TabIndex = 38;
            this.lblBalance.Text = "Balance";
            // 
            // txtbxBal
            // 
            this.txtbxBal.Enabled = false;
            this.txtbxBal.Location = new System.Drawing.Point(117, 106);
            this.txtbxBal.Name = "txtbxBal";
            this.txtbxBal.Size = new System.Drawing.Size(100, 20);
            this.txtbxBal.TabIndex = 37;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(16, 145);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 36;
            this.lblAmount.Text = "Amount";
            // 
            // txtbxAmount
            // 
            this.txtbxAmount.Location = new System.Drawing.Point(117, 142);
            this.txtbxAmount.Name = "txtbxAmount";
            this.txtbxAmount.Size = new System.Drawing.Size(100, 20);
            this.txtbxAmount.TabIndex = 35;
            // 
            // cmbbxtype
            // 
            this.cmbbxtype.FormattingEnabled = true;
            this.cmbbxtype.Items.AddRange(new object[] {
            "Employee",
            "Purchase",
            "Customer",
            "Default"});
            this.cmbbxtype.Location = new System.Drawing.Point(117, 30);
            this.cmbbxtype.Name = "cmbbxtype";
            this.cmbbxtype.Size = new System.Drawing.Size(100, 21);
            this.cmbbxtype.TabIndex = 34;
            this.cmbbxtype.Text = "Select Type";
            this.cmbbxtype.SelectedIndexChanged += new System.EventHandler(this.cmbbxtype_SelectedIndexChanged);
            // 
            // lbl_AccType
            // 
            this.lbl_AccType.AutoSize = true;
            this.lbl_AccType.Location = new System.Drawing.Point(13, 33);
            this.lbl_AccType.Name = "lbl_AccType";
            this.lbl_AccType.Size = new System.Drawing.Size(74, 13);
            this.lbl_AccType.TabIndex = 33;
            this.lbl_AccType.Text = "Account Type";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(328, 343);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // AccountTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 478);
            this.Controls.Add(this.gbbxtransaction);
            this.Name = "AccountTransaction";
            this.Text = "AccountTransaction";
            this.Load += new System.EventHandler(this.AccountTransaction_Load);
            this.gbbxtransaction.ResumeLayout(false);
            this.gbbxtransaction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbbxtransaction;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbbxtype;
        private System.Windows.Forms.Label lbl_AccType;
        private System.Windows.Forms.ComboBox cmbbxAccount;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtbxBal;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtbxAmount;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtbxDesc;
    }
}