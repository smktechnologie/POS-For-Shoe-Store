namespace Pos
{
    partial class Product
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
            this.btn_search = new System.Windows.Forms.Button();
            this.dg_products = new System.Windows.Forms.DataGridView();
            this.txtbx_name_search = new System.Windows.Forms.TextBox();
            this.txtbx_pname = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_pname = new System.Windows.Forms.Label();
            this.lbl_pdesc = new System.Windows.Forms.Label();
            this.txtbx_pdesc = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.txtbx_pid = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_products)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(713, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dg_products
            // 
            this.dg_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_products.Location = new System.Drawing.Point(341, 41);
            this.dg_products.Name = "dg_products";
            this.dg_products.Size = new System.Drawing.Size(447, 150);
            this.dg_products.TabIndex = 1;
            this.dg_products.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_products_CellClick);
            // 
            // txtbx_name_search
            // 
            this.txtbx_name_search.Location = new System.Drawing.Point(607, 15);
            this.txtbx_name_search.Name = "txtbx_name_search";
            this.txtbx_name_search.Size = new System.Drawing.Size(100, 20);
            this.txtbx_name_search.TabIndex = 2;
            // 
            // txtbx_pname
            // 
            this.txtbx_pname.Location = new System.Drawing.Point(116, 78);
            this.txtbx_pname.Name = "txtbx_pname";
            this.txtbx_pname.Size = new System.Drawing.Size(100, 20);
            this.txtbx_pname.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(16, 168);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_pname
            // 
            this.lbl_pname.AutoSize = true;
            this.lbl_pname.Location = new System.Drawing.Point(13, 83);
            this.lbl_pname.Name = "lbl_pname";
            this.lbl_pname.Size = new System.Drawing.Size(75, 13);
            this.lbl_pname.TabIndex = 5;
            this.lbl_pname.Text = "Product Name";
            // 
            // lbl_pdesc
            // 
            this.lbl_pdesc.AutoSize = true;
            this.lbl_pdesc.Location = new System.Drawing.Point(12, 136);
            this.lbl_pdesc.Name = "lbl_pdesc";
            this.lbl_pdesc.Size = new System.Drawing.Size(100, 13);
            this.lbl_pdesc.TabIndex = 7;
            this.lbl_pdesc.Text = "Product Description";
            // 
            // txtbx_pdesc
            // 
            this.txtbx_pdesc.Location = new System.Drawing.Point(116, 133);
            this.txtbx_pdesc.Name = "txtbx_pdesc";
            this.txtbx_pdesc.Size = new System.Drawing.Size(100, 20);
            this.txtbx_pdesc.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(15, 55);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(58, 13);
            this.ID.TabIndex = 9;
            this.ID.Text = "Product ID";
            // 
            // txtbx_pid
            // 
            this.txtbx_pid.Enabled = false;
            this.txtbx_pid.Location = new System.Drawing.Point(116, 52);
            this.txtbx_pid.Name = "txtbx_pid";
            this.txtbx_pid.Size = new System.Drawing.Size(100, 20);
            this.txtbx_pid.TabIndex = 8;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(97, 168);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 110);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price";
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Location = new System.Drawing.Point(116, 106);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtbxPrice.TabIndex = 12;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 257);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtbxPrice);
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
            this.Name = "Product";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dg_products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dg_products;
        private System.Windows.Forms.TextBox txtbx_name_search;
        private System.Windows.Forms.TextBox txtbx_pname;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_pname;
        private System.Windows.Forms.Label lbl_pdesc;
        private System.Windows.Forms.TextBox txtbx_pdesc;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtbx_pid;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtbxPrice;
    }
}

