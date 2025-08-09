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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
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
            this.txtbxStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtbxQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbbxSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.errprvdr_quantity = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txtbxDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtNetTotal = new System.Windows.Forms.TextBox();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.txtbxpaid = new System.Windows.Forms.TextBox();
            this.lblpaid = new System.Windows.Forms.Label();
            this.txtremaining = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcustomer = new System.Windows.Forms.Label();
            this.cmbbx_CustomerAcc = new System.Windows.Forms.ComboBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblItem = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Submit_Order_wout_Receipt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errprvdr_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(921, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Amount";
            // 
            // txtbxTotal
            // 
            this.txtbxTotal.Enabled = false;
            this.txtbxTotal.Location = new System.Drawing.Point(1053, 199);
            this.txtbxTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxTotal.Name = "txtbxTotal";
            this.txtbxTotal.Size = new System.Drawing.Size(132, 22);
            this.txtbxTotal.TabIndex = 2;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Location = new System.Drawing.Point(941, 442);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(231, 28);
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
            this.dtgviewItems.Location = new System.Drawing.Point(16, 137);
            this.dtgviewItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgviewItems.Name = "dtgviewItems";
            this.dtgviewItems.ReadOnly = true;
            this.dtgviewItems.RowHeadersWidth = 51;
            this.dtgviewItems.Size = new System.Drawing.Size(863, 466);
            this.dtgviewItems.TabIndex = 4;
            this.dtgviewItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgviewItems_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 35;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 200;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 90;
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 30;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 50;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 50;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 60;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.MinimumWidth = 6;
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Text = "Remove";
            this.Remove.Width = 125;
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Enabled = false;
            this.txtbxPrice.Location = new System.Drawing.Point(185, 92);
            this.txtbxPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(132, 22);
            this.txtbxPrice.TabIndex = 6;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(185, 73);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // cmbbxitem
            // 
            this.cmbbxitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxitem.FormattingEnabled = true;
            this.cmbbxitem.Location = new System.Drawing.Point(16, 91);
            this.cmbbxitem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbbxitem.Name = "cmbbxitem";
            this.cmbbxitem.Size = new System.Drawing.Size(160, 24);
            this.cmbbxitem.TabIndex = 7;
            this.cmbbxitem.SelectionChangeCommitted += new System.EventHandler(this.cmbbxitem_SelectionChangeCommitted);
            // 
            // txtbxStock
            // 
            this.txtbxStock.Enabled = false;
            this.txtbxStock.Location = new System.Drawing.Point(467, 90);
            this.txtbxStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxStock.Name = "txtbxStock";
            this.txtbxStock.Size = new System.Drawing.Size(132, 22);
            this.txtbxStock.TabIndex = 9;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(463, 69);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 16);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Stock";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(604, 73);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 16);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtbxQuantity
            // 
            this.txtbxQuantity.Enabled = false;
            this.txtbxQuantity.Location = new System.Drawing.Point(608, 91);
            this.txtbxQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxQuantity.Name = "txtbxQuantity";
            this.txtbxQuantity.Size = new System.Drawing.Size(132, 22);
            this.txtbxQuantity.TabIndex = 11;
            this.txtbxQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtbxQuantity_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(787, 90);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(73, 28);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbbxSize
            // 
            this.cmbbxSize.Enabled = false;
            this.cmbbxSize.FormattingEnabled = true;
            this.cmbbxSize.Location = new System.Drawing.Point(327, 91);
            this.cmbbxSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbbxSize.Name = "cmbbxSize";
            this.cmbbxSize.Size = new System.Drawing.Size(131, 24);
            this.cmbbxSize.TabIndex = 16;
            this.cmbbxSize.SelectionChangeCommitted += new System.EventHandler(this.cmbbxSize_SelectionChangeCommitted);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(323, 73);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(33, 16);
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
            // txtbxDiscount
            // 
            this.txtbxDiscount.Location = new System.Drawing.Point(1053, 231);
            this.txtbxDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxDiscount.Name = "txtbxDiscount";
            this.txtbxDiscount.Size = new System.Drawing.Size(132, 22);
            this.txtbxDiscount.TabIndex = 18;
            this.txtbxDiscount.Text = "0";
            this.txtbxDiscount.TextChanged += new System.EventHandler(this.txtbxDiscount_TextChanged);
            this.txtbxDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxDiscount_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(924, 235);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(59, 16);
            this.lblDiscount.TabIndex = 17;
            this.lblDiscount.Text = "Discount";
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.Enabled = false;
            this.txtNetTotal.Location = new System.Drawing.Point(1053, 267);
            this.txtNetTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.Size = new System.Drawing.Size(132, 22);
            this.txtNetTotal.TabIndex = 20;
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.AutoSize = true;
            this.lblNetTotal.Location = new System.Drawing.Point(924, 271);
            this.lblNetTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(62, 16);
            this.lblNetTotal.TabIndex = 19;
            this.lblNetTotal.Tag = "";
            this.lblNetTotal.Text = "Net Total";
            // 
            // txtbxpaid
            // 
            this.txtbxpaid.Location = new System.Drawing.Point(1053, 299);
            this.txtbxpaid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxpaid.Name = "txtbxpaid";
            this.txtbxpaid.Size = new System.Drawing.Size(132, 22);
            this.txtbxpaid.TabIndex = 22;
            this.txtbxpaid.Text = "0";
            this.txtbxpaid.TextChanged += new System.EventHandler(this.txtbxpaid_TextChanged);
            this.txtbxpaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxpaid_KeyPress);
            // 
            // lblpaid
            // 
            this.lblpaid.AutoSize = true;
            this.lblpaid.Location = new System.Drawing.Point(924, 303);
            this.lblpaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpaid.Name = "lblpaid";
            this.lblpaid.Size = new System.Drawing.Size(38, 16);
            this.lblpaid.TabIndex = 21;
            this.lblpaid.Text = "Paid ";
            // 
            // txtremaining
            // 
            this.txtremaining.Enabled = false;
            this.txtremaining.Location = new System.Drawing.Point(1053, 331);
            this.txtremaining.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtremaining.Name = "txtremaining";
            this.txtremaining.Size = new System.Drawing.Size(132, 22);
            this.txtremaining.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(924, 335);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 23;
            this.label3.Tag = "";
            this.label3.Text = "Remaining";
            // 
            // lblcustomer
            // 
            this.lblcustomer.AutoSize = true;
            this.lblcustomer.Location = new System.Drawing.Point(921, 171);
            this.lblcustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(115, 16);
            this.lblcustomer.TabIndex = 25;
            this.lblcustomer.Text = "Customer Account";
            // 
            // cmbbx_CustomerAcc
            // 
            this.cmbbx_CustomerAcc.FormattingEnabled = true;
            this.cmbbx_CustomerAcc.Location = new System.Drawing.Point(1053, 167);
            this.cmbbx_CustomerAcc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbbx_CustomerAcc.Name = "cmbbx_CustomerAcc";
            this.cmbbx_CustomerAcc.Size = new System.Drawing.Size(132, 24);
            this.cmbbx_CustomerAcc.TabIndex = 26;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(17, 43);
            this.txtbxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(132, 22);
            this.txtbxSearch.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(159, 41);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(16, 23);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(50, 16);
            this.lblItem.TabIndex = 29;
            this.lblItem.Text = "Search";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(267, 39);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Product";
            // 
            // btn_Submit_Order_wout_Receipt
            // 
            this.btn_Submit_Order_wout_Receipt.Enabled = false;
            this.btn_Submit_Order_wout_Receipt.Location = new System.Drawing.Point(941, 406);
            this.btn_Submit_Order_wout_Receipt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Submit_Order_wout_Receipt.Name = "btn_Submit_Order_wout_Receipt";
            this.btn_Submit_Order_wout_Receipt.Size = new System.Drawing.Size(231, 28);
            this.btn_Submit_Order_wout_Receipt.TabIndex = 32;
            this.btn_Submit_Order_wout_Receipt.Text = "Submit Order and Print Receipt";
            this.btn_Submit_Order_wout_Receipt.UseVisualStyleBackColor = true;
            this.btn_Submit_Order_wout_Receipt.Click += new System.EventHandler(this.btn_Submit_Order_wout_Receipt_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 622);
            this.Controls.Add(this.btn_Submit_Order_wout_Receipt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.cmbbx_CustomerAcc);
            this.Controls.Add(this.lblcustomer);
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
            this.Controls.Add(this.txtbxStock);
            this.Controls.Add(this.cmbbxitem);
            this.Controls.Add(this.txtbxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.dtgviewItems);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txtbxTotal);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtbxDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtNetTotal;
        private System.Windows.Forms.Label lblNetTotal;
        private System.Windows.Forms.TextBox txtremaining;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxpaid;
        private System.Windows.Forms.Label lblpaid;
        private System.Windows.Forms.Label lblcustomer;
        private System.Windows.Forms.ComboBox cmbbx_CustomerAcc;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Submit_Order_wout_Receipt;
    }
}