namespace CateringShopApp
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.goToItemsButton = new System.Windows.Forms.Button();
            this.goToOrdersButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usersDGV = new System.Windows.Forms.DataGridView();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newPasswordTB = new System.Windows.Forms.TextBox();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.newUsernameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // goToItemsButton
            // 
            this.goToItemsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goToItemsButton.Location = new System.Drawing.Point(33, 500);
            this.goToItemsButton.Name = "goToItemsButton";
            this.goToItemsButton.Size = new System.Drawing.Size(123, 46);
            this.goToItemsButton.TabIndex = 72;
            this.goToItemsButton.Text = "Go to Items";
            this.goToItemsButton.UseVisualStyleBackColor = false;
            this.goToItemsButton.Click += new System.EventHandler(this.goToItemsButton_Click);
            // 
            // goToOrdersButton
            // 
            this.goToOrdersButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goToOrdersButton.Location = new System.Drawing.Point(33, 410);
            this.goToOrdersButton.Name = "goToOrdersButton";
            this.goToOrdersButton.Size = new System.Drawing.Size(123, 46);
            this.goToOrdersButton.TabIndex = 70;
            this.goToOrdersButton.Text = "Go to Orders";
            this.goToOrdersButton.UseVisualStyleBackColor = false;
            this.goToOrdersButton.Click += new System.EventHandler(this.goToOrdersButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(374, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 37);
            this.label3.TabIndex = 67;
            this.label3.Text = "Manage Users";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(376, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 27);
            this.label1.TabIndex = 65;
            this.label1.Text = "Current username";
            // 
            // usersDGV
            // 
            this.usersDGV.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.usersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDGV.GridColor = System.Drawing.Color.Silver;
            this.usersDGV.Location = new System.Drawing.Point(341, 162);
            this.usersDGV.Name = "usersDGV";
            this.usersDGV.RowHeadersVisible = false;
            this.usersDGV.RowHeadersWidth = 62;
            this.usersDGV.RowTemplate.Height = 28;
            this.usersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDGV.Size = new System.Drawing.Size(236, 342);
            this.usersDGV.TabIndex = 63;
            this.usersDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDGV_CellContentClick);
            // 
            // userNameTB
            // 
            this.userNameTB.Location = new System.Drawing.Point(377, 124);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(150, 26);
            this.userNameTB.TabIndex = 60;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(905, 574);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(637, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 27);
            this.label2.TabIndex = 74;
            this.label2.Text = "New password";
            // 
            // newPasswordTB
            // 
            this.newPasswordTB.Location = new System.Drawing.Point(646, 202);
            this.newPasswordTB.Name = "newPasswordTB";
            this.newPasswordTB.Size = new System.Drawing.Size(150, 26);
            this.newPasswordTB.TabIndex = 73;
            // 
            // changeUserButton
            // 
            this.changeUserButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeUserButton.Location = new System.Drawing.Point(397, 519);
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.Size = new System.Drawing.Size(123, 46);
            this.changeUserButton.TabIndex = 75;
            this.changeUserButton.Text = "Change User";
            this.changeUserButton.UseVisualStyleBackColor = false;
            this.changeUserButton.Click += new System.EventHandler(this.changeUserButton_Click);
            // 
            // newUsernameTB
            // 
            this.newUsernameTB.Location = new System.Drawing.Point(642, 124);
            this.newUsernameTB.Name = "newUsernameTB";
            this.newUsernameTB.Size = new System.Drawing.Size(150, 26);
            this.newUsernameTB.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(641, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 27);
            this.label4.TabIndex = 65;
            this.label4.Text = "New username";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 588);
            this.Controls.Add(this.changeUserButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPasswordTB);
            this.Controls.Add(this.goToItemsButton);
            this.Controls.Add(this.goToOrdersButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersDGV);
            this.Controls.Add(this.newUsernameTB);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button goToItemsButton;
        private System.Windows.Forms.Button goToOrdersButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView usersDGV;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPasswordTB;
        private System.Windows.Forms.Button changeUserButton;
        private System.Windows.Forms.TextBox newUsernameTB;
        private System.Windows.Forms.Label label4;
    }
}