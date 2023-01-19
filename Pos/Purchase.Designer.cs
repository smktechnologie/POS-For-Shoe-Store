namespace Pos
{
    partial class Purchase
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
            this.components = new System.ComponentModel.Container();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.errprvdr_quantity = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbbx_PurchaseAcc = new System.Windows.Forms.ComboBox();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.txtremaining = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxpaid = new System.Windows.Forms.TextBox();
            this.lblpaid = new System.Windows.Forms.Label();
            this.txtNetTotal = new System.Windows.Forms.TextBox();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.txtbxDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.cmbbxSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtbxQuantity = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.dtgviewItems = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txtbxTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxStock = new System.Windows.Forms.TextBox();
            this.cmbbxitem = new System.Windows.Forms.ComboBox();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errprvdr_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // errprvdr_quantity
            // 
            this.errprvdr_quantity.BlinkRate = 1000;
            this.errprvdr_quantity.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errprvdr_quantity.ContainerControl = this;
            // 
            // cmbbx_PurchaseAcc
            // 
            this.cmbbx_PurchaseAcc.FormattingEnabled = true;
            this.cmbbx_PurchaseAcc.Location = new System.Drawing.Point(806, 88);
            this.cmbbx_PurchaseAcc.Name = "cmbbx_PurchaseAcc";
            this.cmbbx_PurchaseAcc.Size = new System.Drawing.Size(100, 21);
            this.cmbbx_PurchaseAcc.TabIndex = 51;
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Location = new System.Drawing.Point(707, 91);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(98, 13);
            this.lblPurchase.TabIndex = 50;
            this.lblPurchase.Text = "Purchaser Account";
            // 
            // txtremaining
            // 
            this.txtremaining.Enabled = false;
            this.txtremaining.Location = new System.Drawing.Point(806, 221);
            this.txtremaining.Name = "txtremaining";
            this.txtremaining.Size = new System.Drawing.Size(100, 20);
            this.txtremaining.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(709, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 48;
            this.label3.Tag = "";
            this.label3.Text = "Remaining";
            // 
            // txtbxpaid
            // 
            this.txtbxpaid.Location = new System.Drawing.Point(806, 195);
            this.txtbxpaid.Name = "txtbxpaid";
            this.txtbxpaid.Size = new System.Drawing.Size(100, 20);
            this.txtbxpaid.TabIndex = 47;
            this.txtbxpaid.Text = "0";
            this.txtbxpaid.TextChanged += new System.EventHandler(this.txtbxpaid_TextChanged);
            this.txtbxpaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxpaid_KeyPress);
            // 
            // lblpaid
            // 
            this.lblpaid.AutoSize = true;
            this.lblpaid.Location = new System.Drawing.Point(709, 198);
            this.lblpaid.Name = "lblpaid";
            this.lblpaid.Size = new System.Drawing.Size(31, 13);
            this.lblpaid.TabIndex = 46;
            this.lblpaid.Text = "Paid ";
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.Enabled = false;
            this.txtNetTotal.Location = new System.Drawing.Point(806, 169);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.Size = new System.Drawing.Size(100, 20);
            this.txtNetTotal.TabIndex = 45;
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.AutoSize = true;
            this.lblNetTotal.Location = new System.Drawing.Point(709, 172);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(51, 13);
            this.lblNetTotal.TabIndex = 44;
            this.lblNetTotal.Tag = "";
            this.lblNetTotal.Text = "Net Total";
            // 
            // txtbxDiscount
            // 
            this.txtbxDiscount.Location = new System.Drawing.Point(806, 140);
            this.txtbxDiscount.Name = "txtbxDiscount";
            this.txtbxDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtbxDiscount.TabIndex = 43;
            this.txtbxDiscount.Text = "0";
            this.txtbxDiscount.TextChanged += new System.EventHandler(this.txtbxDiscount_TextChanged);
            this.txtbxDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxDiscount_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(709, 143);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 42;
            this.lblDiscount.Text = "Discount";
            // 
            // cmbbxSize
            // 
            this.cmbbxSize.Enabled = false;
            this.cmbbxSize.FormattingEnabled = true;
            this.cmbbxSize.Location = new System.Drawing.Point(261, 26);
            this.cmbbxSize.Name = "cmbbxSize";
            this.cmbbxSize.Size = new System.Drawing.Size(99, 21);
            this.cmbbxSize.TabIndex = 41;
            this.cmbbxSize.SelectionChangeCommitted += new System.EventHandler(this.cmbbxSize_SelectionChangeCommitted);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(258, 11);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 40;
            this.lblSize.Text = "Size";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(606, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(469, 11);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 38;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtbxQuantity
            // 
            this.txtbxQuantity.Enabled = false;
            this.txtbxQuantity.Location = new System.Drawing.Point(472, 26);
            this.txtbxQuantity.Name = "txtbxQuantity";
            this.txtbxQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtbxQuantity.TabIndex = 37;
            this.txtbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxQuantity_KeyPress);
            this.txtbxQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxQuantity_Validating);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(363, 8);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 36;
            this.lblStock.Text = "Stock";
            // 
            // dtgviewItems
            // 
            this.dtgviewItems.AllowUserToAddRows = false;
            this.dtgviewItems.AllowUserToDeleteRows = false;
            this.dtgviewItems.AllowUserToOrderColumns = true;
            this.dtgviewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgviewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Item,
            this.Price,
            this.Size,
            this.Stock,
            this.Quantity,
            this.Total,
            this.Remove});
            this.dtgviewItems.GridColor = System.Drawing.SystemColors.Highlight;
            this.dtgviewItems.Location = new System.Drawing.Point(28, 63);
            this.dtgviewItems.Name = "dtgviewItems";
            this.dtgviewItems.ReadOnly = true;
            this.dtgviewItems.Size = new System.Drawing.Size(647, 379);
            this.dtgviewItems.TabIndex = 30;
            this.dtgviewItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgviewItems_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 35;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 200;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 90;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 30;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 50;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 50;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 60;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Text = "Remove";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Location = new System.Drawing.Point(722, 276);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(173, 23);
            this.btn_Submit.TabIndex = 29;
            this.btn_Submit.Text = "Submit Purchase";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txtbxTotal
            // 
            this.txtbxTotal.Enabled = false;
            this.txtbxTotal.Location = new System.Drawing.Point(806, 114);
            this.txtbxTotal.Name = "txtbxTotal";
            this.txtbxTotal.Size = new System.Drawing.Size(100, 20);
            this.txtbxTotal.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Total Amount";
            // 
            // txtbxStock
            // 
            this.txtbxStock.Enabled = false;
            this.txtbxStock.Location = new System.Drawing.Point(366, 25);
            this.txtbxStock.Name = "txtbxStock";
            this.txtbxStock.Size = new System.Drawing.Size(100, 20);
            this.txtbxStock.TabIndex = 35;
            // 
            // cmbbxitem
            // 
            this.cmbbxitem.FormattingEnabled = true;
            this.cmbbxitem.Location = new System.Drawing.Point(28, 26);
            this.cmbbxitem.Name = "cmbbxitem";
            this.cmbbxitem.Size = new System.Drawing.Size(121, 21);
            this.cmbbxitem.TabIndex = 33;
            this.cmbbxitem.SelectionChangeCommitted += new System.EventHandler(this.cmbbxitem_SelectionChangeCommitted);
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Location = new System.Drawing.Point(155, 27);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtbxPrice.TabIndex = 32;
            this.txtbxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(155, 11);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 31;
            this.lblPrice.Text = "Price";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(28, 10);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(60, 13);
            this.lblItem.TabIndex = 34;
            this.lblItem.Text = "Select Item";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.cmbbx_PurchaseAcc);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.txtremaining);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxpaid);
            this.Controls.Add(this.lblpaid);
            this.Controls.Add(this.txtNetTotal);
            this.Controls.Add(this.lblNetTotal);
            this.Controls.Add(this.txtbxDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.cmbbxSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtbxQuantity);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.dtgviewItems);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txtbxTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxStock);
            this.Controls.Add(this.cmbbxitem);
            this.Controls.Add(this.txtbxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItem);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.Purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errprvdr_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ErrorProvider errprvdr_quantity;
        private System.Windows.Forms.ComboBox cmbbx_PurchaseAcc;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.TextBox txtremaining;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxpaid;
        private System.Windows.Forms.Label lblpaid;
        private System.Windows.Forms.TextBox txtNetTotal;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.TextBox txtbxDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.ComboBox cmbbxSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtbxQuantity;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.DataGridView dtgviewItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewLinkColumn Remove;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txtbxTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxStock;
        private System.Windows.Forms.ComboBox cmbbxitem;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblItem;
    }
}