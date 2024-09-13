namespace CateringShopApp
{
    partial class Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            this.goToUsersButton = new System.Windows.Forms.Button();
            this.goToOrdersButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.itemPriceTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemNameTB = new System.Windows.Forms.TextBox();
            this.itemsDGV = new System.Windows.Forms.DataGridView();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.itemNumberTB = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // goToUsersButton
            // 
            this.goToUsersButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goToUsersButton.Location = new System.Drawing.Point(33, 500);
            this.goToUsersButton.Name = "goToUsersButton";
            this.goToUsersButton.Size = new System.Drawing.Size(123, 46);
            this.goToUsersButton.TabIndex = 55;
            this.goToUsersButton.Text = "Go to Users";
            this.goToUsersButton.UseVisualStyleBackColor = false;
            this.goToUsersButton.Click += new System.EventHandler(this.goToUsersButton_Click);
            // 
            // goToOrdersButton
            // 
            this.goToOrdersButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goToOrdersButton.Location = new System.Drawing.Point(33, 410);
            this.goToOrdersButton.Name = "goToOrdersButton";
            this.goToOrdersButton.Size = new System.Drawing.Size(123, 46);
            this.goToOrdersButton.TabIndex = 53;
            this.goToOrdersButton.Text = "Go to Orders";
            this.goToOrdersButton.UseVisualStyleBackColor = false;
            this.goToOrdersButton.Click += new System.EventHandler(this.goToOrdersButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(759, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 27);
            this.label6.TabIndex = 52;
            this.label6.Text = "Item Price";
            // 
            // itemPriceTB
            // 
            this.itemPriceTB.Location = new System.Drawing.Point(747, 127);
            this.itemPriceTB.Name = "itemPriceTB";
            this.itemPriceTB.Size = new System.Drawing.Size(150, 26);
            this.itemPriceTB.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(507, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 37);
            this.label3.TabIndex = 49;
            this.label3.Text = "Item List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(412, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 47;
            this.label2.Text = "Item name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(240, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 27);
            this.label1.TabIndex = 46;
            this.label1.Text = "Item number";
            // 
            // itemNameTB
            // 
            this.itemNameTB.Location = new System.Drawing.Point(413, 125);
            this.itemNameTB.Name = "itemNameTB";
            this.itemNameTB.Size = new System.Drawing.Size(150, 26);
            this.itemNameTB.TabIndex = 45;
            // 
            // itemsDGV
            // 
            this.itemsDGV.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.itemsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDGV.GridColor = System.Drawing.Color.Silver;
            this.itemsDGV.Location = new System.Drawing.Point(227, 224);
            this.itemsDGV.Name = "itemsDGV";
            this.itemsDGV.RowHeadersVisible = false;
            this.itemsDGV.RowHeadersWidth = 62;
            this.itemsDGV.RowTemplate.Height = 28;
            this.itemsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsDGV.Size = new System.Drawing.Size(670, 270);
            this.itemsDGV.TabIndex = 44;
            this.itemsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemsDGV_CellContentClick);
            // 
            // categoryCB
            // 
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Items.AddRange(new object[] {
            "Food",
            "Bevrage"});
            this.categoryCB.Location = new System.Drawing.Point(583, 125);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(150, 28);
            this.categoryCB.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(599, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "Category";
            // 
            // itemNumberTB
            // 
            this.itemNumberTB.Location = new System.Drawing.Point(241, 125);
            this.itemNumberTB.Name = "itemNumberTB";
            this.itemNumberTB.Size = new System.Drawing.Size(150, 26);
            this.itemNumberTB.TabIndex = 41;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.PeachPuff;
            this.addButton.Location = new System.Drawing.Point(285, 172);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(123, 46);
            this.addButton.TabIndex = 40;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(905, 574);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.PeachPuff;
            this.editButton.Location = new System.Drawing.Point(438, 174);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(123, 46);
            this.editButton.TabIndex = 56;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.PeachPuff;
            this.deleteButton.Location = new System.Drawing.Point(582, 174);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(123, 46);
            this.deleteButton.TabIndex = 57;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.PeachPuff;
            this.resetButton.Location = new System.Drawing.Point(725, 174);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(123, 46);
            this.resetButton.TabIndex = 58;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 588);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.goToUsersButton);
            this.Controls.Add(this.goToOrdersButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.itemPriceTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemNameTB);
            this.Controls.Add(this.itemsDGV);
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.itemNumberTB);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goToUsersButton;
        private System.Windows.Forms.Button goToOrdersButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox itemPriceTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemNameTB;
        private System.Windows.Forms.DataGridView itemsDGV;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox itemNumberTB;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button resetButton;
    }
}