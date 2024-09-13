namespace CateringShopApp
{
    partial class GuestOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestOrders));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.orderDGV = new System.Windows.Forms.DataGridView();
            this.itemsDGV = new System.Windows.Forms.DataGridView();
            this.logOutLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.quantityTB = new System.Windows.Forms.TextBox();
            this.sellerNameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.datelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(905, 574);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.placeOrderButton.Location = new System.Drawing.Point(536, 523);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(162, 46);
            this.placeOrderButton.TabIndex = 53;
            this.placeOrderButton.Text = "Place the order";
            this.placeOrderButton.UseVisualStyleBackColor = false;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(481, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 37);
            this.label4.TabIndex = 49;
            this.label4.Text = "Your Order";
            // 
            // orderDGV
            // 
            this.orderDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDGV.Location = new System.Drawing.Point(226, 327);
            this.orderDGV.Name = "orderDGV";
            this.orderDGV.RowHeadersVisible = false;
            this.orderDGV.RowHeadersWidth = 62;
            this.orderDGV.RowTemplate.Height = 28;
            this.orderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDGV.Size = new System.Drawing.Size(670, 190);
            this.orderDGV.TabIndex = 47;
            // 
            // itemsDGV
            // 
            this.itemsDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.itemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDGV.GridColor = System.Drawing.Color.Silver;
            this.itemsDGV.Location = new System.Drawing.Point(226, 49);
            this.itemsDGV.Name = "itemsDGV";
            this.itemsDGV.RowHeadersVisible = false;
            this.itemsDGV.RowHeadersWidth = 62;
            this.itemsDGV.RowTemplate.Height = 28;
            this.itemsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsDGV.Size = new System.Drawing.Size(670, 180);
            this.itemsDGV.TabIndex = 43;
            this.itemsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDGV_CellContentClick);
            // 
            // logOutLabel
            // 
            this.logOutLabel.AutoSize = true;
            this.logOutLabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.logOutLabel.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logOutLabel.Location = new System.Drawing.Point(46, 523);
            this.logOutLabel.Name = "logOutLabel";
            this.logOutLabel.Size = new System.Drawing.Size(76, 22);
            this.logOutLabel.TabIndex = 55;
            this.logOutLabel.Text = "Log Out";
            this.logOutLabel.Click += new System.EventHandler(this.logOutLabel_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.refreshButton.Location = new System.Drawing.Point(59, 96);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(123, 38);
            this.refreshButton.TabIndex = 76;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // categoryCB
            // 
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Items.AddRange(new object[] {
            "Food",
            "Bevrage"});
            this.categoryCB.Location = new System.Drawing.Point(45, 49);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(150, 28);
            this.categoryCB.TabIndex = 75;
            this.categoryCB.SelectedIndexChanged += new System.EventHandler(this.categoryCB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(54, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 27);
            this.label5.TabIndex = 74;
            this.label5.Text = "Category";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.amountLabel.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.amountLabel.Location = new System.Drawing.Point(753, 536);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(20, 22);
            this.amountLabel.TabIndex = 73;
            this.amountLabel.Text = "$";
            // 
            // quantityTB
            // 
            this.quantityTB.Location = new System.Drawing.Point(492, 248);
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Size = new System.Drawing.Size(150, 26);
            this.quantityTB.TabIndex = 72;
            // 
            // sellerNameTB
            // 
            this.sellerNameTB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sellerNameTB.Location = new System.Drawing.Point(30, 372);
            this.sellerNameTB.Name = "sellerNameTB";
            this.sellerNameTB.Size = new System.Drawing.Size(150, 30);
            this.sellerNameTB.TabIndex = 71;
            this.sellerNameTB.Text = "GUEST";
            this.sellerNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(648, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 27);
            this.label6.TabIndex = 68;
            this.label6.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(29, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 27);
            this.label2.TabIndex = 67;
            this.label2.Text = "Seller name";
            // 
            // addToCartButton
            // 
            this.addToCartButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addToCartButton.Location = new System.Drawing.Point(773, 245);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(123, 46);
            this.addToCartButton.TabIndex = 65;
            this.addToCartButton.Text = "Add to Cart";
            this.addToCartButton.UseVisualStyleBackColor = false;
            this.addToCartButton.Click += new System.EventHandler(this.addToCartButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(505, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 37);
            this.label8.TabIndex = 77;
            this.label8.Text = "Place Order";
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.datelabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datelabel.Location = new System.Drawing.Point(768, 17);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(59, 27);
            this.datelabel.TabIndex = 78;
            this.datelabel.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(788, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 79;
            this.label3.Text = "$";
            // 
            // GuestOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 588);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.quantityTB);
            this.Controls.Add(this.sellerNameTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addToCartButton);
            this.Controls.Add(this.logOutLabel);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orderDGV);
            this.Controls.Add(this.itemsDGV);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GuestOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestOrders";
            this.Load += new System.EventHandler(this.GuestOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView orderDGV;
        private System.Windows.Forms.DataGridView itemsDGV;
        private System.Windows.Forms.Label logOutLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox quantityTB;
        private System.Windows.Forms.TextBox sellerNameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addToCartButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Label label3;
    }
}