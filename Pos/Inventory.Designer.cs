namespace Pos
{
    partial class Inventory
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
            this.lblProduct = new System.Windows.Forms.Label();
            this.cmbbxSelectProduct = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.txtbxStock = new System.Windows.Forms.TextBox();
            this.txtbxQuantity = new System.Windows.Forms.TextBox();
            this.txtbxVendor = new System.Windows.Forms.TextBox();
            this.txtbxDesc = new System.Windows.Forms.TextBox();
            this.lblVendorDesc = new System.Windows.Forms.Label();
            this.txtbxPid = new System.Windows.Forms.TextBox();
            this.lblPid = new System.Windows.Forms.Label();
            this.btnAddInventory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(28, 33);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(77, 13);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Select Product";
            // 
            // cmbbxSelectProduct
            // 
            this.cmbbxSelectProduct.FormattingEnabled = true;
            this.cmbbxSelectProduct.Location = new System.Drawing.Point(111, 30);
            this.cmbbxSelectProduct.Name = "cmbbxSelectProduct";
            this.cmbbxSelectProduct.Size = new System.Drawing.Size(263, 21);
            this.cmbbxSelectProduct.TabIndex = 1;
            this.cmbbxSelectProduct.SelectionChangeCommitted += new System.EventHandler(this.cmbbxSelectProduct_SelectionChangeCommitted);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(27, 127);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "In Stock";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(27, 155);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(41, 13);
            this.lblVendor.TabIndex = 4;
            this.lblVendor.Text = "Vendor";
            // 
            // txtbxStock
            // 
            this.txtbxStock.Enabled = false;
            this.txtbxStock.Location = new System.Drawing.Point(111, 97);
            this.txtbxStock.Name = "txtbxStock";
            this.txtbxStock.Size = new System.Drawing.Size(100, 20);
            this.txtbxStock.TabIndex = 5;
            // 
            // txtbxQuantity
            // 
            this.txtbxQuantity.Location = new System.Drawing.Point(111, 124);
            this.txtbxQuantity.Name = "txtbxQuantity";
            this.txtbxQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtbxQuantity.TabIndex = 6;
            // 
            // txtbxVendor
            // 
            this.txtbxVendor.Location = new System.Drawing.Point(111, 152);
            this.txtbxVendor.Name = "txtbxVendor";
            this.txtbxVendor.Size = new System.Drawing.Size(100, 20);
            this.txtbxVendor.TabIndex = 7;
            // 
            // txtbxDesc
            // 
            this.txtbxDesc.Location = new System.Drawing.Point(111, 178);
            this.txtbxDesc.Multiline = true;
            this.txtbxDesc.Name = "txtbxDesc";
            this.txtbxDesc.Size = new System.Drawing.Size(263, 76);
            this.txtbxDesc.TabIndex = 9;
            // 
            // lblVendorDesc
            // 
            this.lblVendorDesc.AutoSize = true;
            this.lblVendorDesc.Location = new System.Drawing.Point(27, 181);
            this.lblVendorDesc.Name = "lblVendorDesc";
            this.lblVendorDesc.Size = new System.Drawing.Size(60, 13);
            this.lblVendorDesc.TabIndex = 8;
            this.lblVendorDesc.Text = "Description";
            // 
            // txtbxPid
            // 
            this.txtbxPid.Enabled = false;
            this.txtbxPid.Location = new System.Drawing.Point(111, 71);
            this.txtbxPid.Name = "txtbxPid";
            this.txtbxPid.Size = new System.Drawing.Size(100, 20);
            this.txtbxPid.TabIndex = 11;
            // 
            // lblPid
            // 
            this.lblPid.AutoSize = true;
            this.lblPid.Location = new System.Drawing.Point(27, 74);
            this.lblPid.Name = "lblPid";
            this.lblPid.Size = new System.Drawing.Size(58, 13);
            this.lblPid.TabIndex = 10;
            this.lblPid.Text = "Product ID";
            // 
            // btnAddInventory
            // 
            this.btnAddInventory.Location = new System.Drawing.Point(299, 275);
            this.btnAddInventory.Name = "btnAddInventory";
            this.btnAddInventory.Size = new System.Drawing.Size(75, 23);
            this.btnAddInventory.TabIndex = 12;
            this.btnAddInventory.Text = "Add Stock";
            this.btnAddInventory.UseVisualStyleBackColor = true;
            this.btnAddInventory.Click += new System.EventHandler(this.btnAddInventory_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddInventory);
            this.Controls.Add(this.txtbxPid);
            this.Controls.Add(this.lblPid);
            this.Controls.Add(this.txtbxDesc);
            this.Controls.Add(this.lblVendorDesc);
            this.Controls.Add(this.txtbxVendor);
            this.Controls.Add(this.txtbxQuantity);
            this.Controls.Add(this.txtbxStock);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cmbbxSelectProduct);
            this.Controls.Add(this.lblProduct);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cmbbxSelectProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.TextBox txtbxStock;
        private System.Windows.Forms.TextBox txtbxQuantity;
        private System.Windows.Forms.TextBox txtbxVendor;
        private System.Windows.Forms.TextBox txtbxDesc;
        private System.Windows.Forms.Label lblVendorDesc;
        private System.Windows.Forms.TextBox txtbxPid;
        private System.Windows.Forms.Label lblPid;
        private System.Windows.Forms.Button btnAddInventory;
    }
}