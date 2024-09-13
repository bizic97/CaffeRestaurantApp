namespace CateringShopApp
{
    partial class ViewOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrders));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ordersDGV = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.printPreviewOrder = new System.Windows.Forms.PrintPreviewDialog();
            this.printOrder = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(905, 574);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(359, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 37);
            this.label3.TabIndex = 34;
            this.label3.Text = "List of orders";
            // 
            // ordersDGV
            // 
            this.ordersDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ordersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDGV.GridColor = System.Drawing.Color.Silver;
            this.ordersDGV.Location = new System.Drawing.Point(120, 64);
            this.ordersDGV.Name = "ordersDGV";
            this.ordersDGV.RowHeadersVisible = false;
            this.ordersDGV.RowHeadersWidth = 62;
            this.ordersDGV.RowTemplate.Height = 28;
            this.ordersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDGV.Size = new System.Drawing.Size(670, 414);
            this.ordersDGV.TabIndex = 33;
            this.ordersDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDGV_CellContentClick);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeButton.Location = new System.Drawing.Point(402, 509);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(123, 46);
            this.closeButton.TabIndex = 35;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // printPreviewOrder
            // 
            this.printPreviewOrder.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewOrder.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewOrder.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewOrder.Document = this.printOrder;
            this.printPreviewOrder.Enabled = true;
            this.printPreviewOrder.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewOrder.Icon")));
            this.printPreviewOrder.Name = "printPreviewOrder";
            this.printPreviewOrder.Visible = false;
            // 
            // printOrder
            // 
            this.printOrder.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printOrder_PrintPage);
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 588);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ordersDGV);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ViewOrders";
            this.Text = "ViewOrders";
            this.Load += new System.EventHandler(this.ViewOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ordersDGV;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PrintPreviewDialog printPreviewOrder;
        private System.Drawing.Printing.PrintDocument printOrder;
    }
}