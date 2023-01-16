namespace Pos
{
    partial class Order
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxTotal = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.dtgviewItems = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmbbxitem = new System.Windows.Forms.ComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtbxStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtbxQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbbxSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.errprvdr_quantity = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errprvdr_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(665, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Amount";
            // 
            // txtbxTotal
            // 
            this.txtbxTotal.Enabled = false;
            this.txtbxTotal.Location = new System.Drawing.Point(741, 68);
            this.txtbxTotal.Name = "txtbxTotal";
            this.txtbxTotal.Size = new System.Drawing.Size(100, 20);
            this.txtbxTotal.TabIndex = 2;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Location = new System.Drawing.Point(668, 105);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(173, 23);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit Order and Print Receipt";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
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
            this.dtgviewItems.Location = new System.Drawing.Point(12, 68);
            this.dtgviewItems.Name = "dtgviewItems";
            this.dtgviewItems.ReadOnly = true;
            this.dtgviewItems.Size = new System.Drawing.Size(647, 379);
            this.dtgviewItems.TabIndex = 4;
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
            // txtbxPrice
            // 
            this.txtbxPrice.Enabled = false;
            this.txtbxPrice.Location = new System.Drawing.Point(139, 32);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtbxPrice.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(139, 16);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // cmbbxitem
            // 
            this.cmbbxitem.FormattingEnabled = true;
            this.cmbbxitem.Location = new System.Drawing.Point(12, 31);
            this.cmbbxitem.Name = "cmbbxitem";
            this.cmbbxitem.Size = new System.Drawing.Size(121, 21);
            this.cmbbxitem.TabIndex = 7;
            this.cmbbxitem.SelectionChangeCommitted += new System.EventHandler(this.cmbbxitem_SelectionChangeCommitted);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(12, 15);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(60, 13);
            this.lblItem.TabIndex = 8;
            this.lblItem.Text = "Select Item";
            // 
            // txtbxStock
            // 
            this.txtbxStock.Enabled = false;
            this.txtbxStock.Location = new System.Drawing.Point(350, 30);
            this.txtbxStock.Name = "txtbxStock";
            this.txtbxStock.Size = new System.Drawing.Size(100, 20);
            this.txtbxStock.TabIndex = 9;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(347, 13);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Stock";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(453, 16);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtbxQuantity
            // 
            this.txtbxQuantity.Enabled = false;
            this.txtbxQuantity.Location = new System.Drawing.Point(456, 31);
            this.txtbxQuantity.Name = "txtbxQuantity";
            this.txtbxQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtbxQuantity.TabIndex = 11;
            this.txtbxQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxQuantity_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(590, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbbxSize
            // 
            this.cmbbxSize.Enabled = false;
            this.cmbbxSize.FormattingEnabled = true;
            this.cmbbxSize.Location = new System.Drawing.Point(245, 31);
            this.cmbbxSize.Name = "cmbbxSize";
            this.cmbbxSize.Size = new System.Drawing.Size(99, 21);
            this.cmbbxSize.TabIndex = 16;
            this.cmbbxSize.SelectionChangeCommitted += new System.EventHandler(this.cmbbxSize_SelectionChangeCommitted);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(242, 16);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 15;
            this.lblSize.Text = "Size";
            // 
            // errprvdr_quantity
            // 
            this.errprvdr_quantity.BlinkRate = 1000;
            this.errprvdr_quantity.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errprvdr_quantity.ContainerControl = this;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.cmbbxSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtbxQuantity);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtbxStock);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.cmbbxitem);
            this.Controls.Add(this.txtbxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.dtgviewItems);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txtbxTotal);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errprvdr_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxTotal;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.DataGridView dtgviewItems;
        private System.Windows.Forms.TextBox txtbxPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cmbbxitem;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtbxStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtbxQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbbxSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewLinkColumn Remove;
        private System.Windows.Forms.ErrorProvider errprvdr_quantity;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}