﻿namespace Pos
{
    partial class Expense
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.txtbx_pid = new System.Windows.Forms.TextBox();
            this.lbl_pdesc = new System.Windows.Forms.Label();
            this.txtbx_pdesc = new System.Windows.Forms.TextBox();
            this.lbl_pname = new System.Windows.Forms.Label();
            this.txtbx_pname = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtbx_name_search = new System.Windows.Forms.TextBox();
            this.dg_products = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_products)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(97, 168);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 22;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(13, 64);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(62, 13);
            this.ID.TabIndex = 21;
            this.ID.Text = "Expense ID";
            // 
            // txtbx_pid
            // 
            this.txtbx_pid.Enabled = false;
            this.txtbx_pid.Location = new System.Drawing.Point(115, 61);
            this.txtbx_pid.Name = "txtbx_pid";
            this.txtbx_pid.Size = new System.Drawing.Size(100, 20);
            this.txtbx_pid.TabIndex = 20;
            // 
            // lbl_pdesc
            // 
            this.lbl_pdesc.AutoSize = true;
            this.lbl_pdesc.Location = new System.Drawing.Point(13, 119);
            this.lbl_pdesc.Name = "lbl_pdesc";
            this.lbl_pdesc.Size = new System.Drawing.Size(104, 13);
            this.lbl_pdesc.TabIndex = 19;
            this.lbl_pdesc.Text = "Expense Description";
            // 
            // txtbx_pdesc
            // 
            this.txtbx_pdesc.Location = new System.Drawing.Point(115, 116);
            this.txtbx_pdesc.Name = "txtbx_pdesc";
            this.txtbx_pdesc.Size = new System.Drawing.Size(100, 20);
            this.txtbx_pdesc.TabIndex = 18;
            // 
            // lbl_pname
            // 
            this.lbl_pname.AutoSize = true;
            this.lbl_pname.Location = new System.Drawing.Point(13, 90);
            this.lbl_pname.Name = "lbl_pname";
            this.lbl_pname.Size = new System.Drawing.Size(79, 13);
            this.lbl_pname.TabIndex = 17;
            this.lbl_pname.Text = "Expense Name";
            // 
            // txtbx_pname
            // 
            this.txtbx_pname.Location = new System.Drawing.Point(115, 87);
            this.txtbx_pname.Name = "txtbx_pname";
            this.txtbx_pname.Size = new System.Drawing.Size(100, 20);
            this.txtbx_pname.TabIndex = 16;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(16, 168);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtbx_name_search
            // 
            this.txtbx_name_search.Location = new System.Drawing.Point(686, 15);
            this.txtbx_name_search.Name = "txtbx_name_search";
            this.txtbx_name_search.Size = new System.Drawing.Size(100, 20);
            this.txtbx_name_search.TabIndex = 14;
            // 
            // dg_products
            // 
            this.dg_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_products.Location = new System.Drawing.Point(329, 70);
            this.dg_products.Name = "dg_products";
            this.dg_products.Size = new System.Drawing.Size(447, 150);
            this.dg_products.TabIndex = 13;
            this.dg_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_products_CellClick);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(711, 41);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtbx_pid);
            this.Controls.Add(this.lbl_pdesc);
            this.Controls.Add(this.txtbx_pdesc);
            this.Controls.Add(this.lbl_pname);
            this.Controls.Add(this.txtbx_pname);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txtbx_name_search);
            this.Controls.Add(this.dg_products);
            this.Controls.Add(this.btn_search);
            this.Name = "Expense";
            this.Text = "Expense";
            ((System.ComponentModel.ISupportInitialize)(this.dg_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtbx_pid;
        private System.Windows.Forms.Label lbl_pdesc;
        private System.Windows.Forms.TextBox txtbx_pdesc;
        private System.Windows.Forms.Label lbl_pname;
        private System.Windows.Forms.TextBox txtbx_pname;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtbx_name_search;
        private System.Windows.Forms.DataGridView dg_products;
        private System.Windows.Forms.Button btn_search;
    }
}