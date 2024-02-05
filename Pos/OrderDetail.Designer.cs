namespace Pos
{
    partial class FrmOrderDetail
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
            this.dgOrderDetails = new System.Windows.Forms.DataGridView();
            this.lblOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOrderDetails
            // 
            this.dgOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderDetails.Location = new System.Drawing.Point(12, 73);
            this.dgOrderDetails.Name = "dgOrderDetails";
            this.dgOrderDetails.Size = new System.Drawing.Size(505, 221);
            this.dgOrderDetails.TabIndex = 0;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(12, 36);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(82, 20);
            this.lblOrder.TabIndex = 1;
            this.lblOrder.Text = "Order ID : ";
            // 
            // FrmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 313);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.dgOrderDetails);
            this.Name = "FrmOrderDetail";
            this.Text = "OrderDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOrderDetails;
        private System.Windows.Forms.Label lblOrder;
    }
}