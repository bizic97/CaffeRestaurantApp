using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CateringShopApp
{
    public partial class Items : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=DESKTOP-NDT7O5N\SQLEXPRESS;Initial Catalog=Caffe;Trusted_Connection=True;MultipleActiveResultSets=True");
        public Items()
        {
            InitializeComponent();
        }
        private void PopulateGrid()
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("SelectItem", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                itemsDGV.DataSource = dt;
                conn.Close();
            }
        }

        private void goToOrdersButton_Click(object sender, EventArgs e)
        {
            EmployeeOrder employeeOrder = new EmployeeOrder();
            employeeOrder.Show();
            this.Hide();
        }

        private void goToUsersButton_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Hide();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (itemNameTB.Text == "" || itemPriceTB.Text == "" || itemNumberTB.Text == "" || categoryCB.Text == "")
            {
                MessageBox.Show("Please enter all the values");
            }
            else
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertIntoItems", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        int itemNumber = int.Parse(itemNumberTB.Text);
                        string itemName = itemNameTB.Text;
                        string itemCategory = categoryCB.SelectedItem.ToString();
                        int itemPrice = int.Parse(itemPriceTB.Text);
                        cmd.Parameters.AddWithValue("@itemNumber", itemNumber);
                        cmd.Parameters.AddWithValue("@itemName", itemName);
                        cmd.Parameters.AddWithValue("@itemCategory", itemCategory);
                        cmd.Parameters.AddWithValue("@itemPrice", itemPrice);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item inserted successfully");
                        conn.Close();
                        PopulateGrid();
                    }

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("An error occured: " + Ex.Message);
                }
            }
        }

        private void Items_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void itemsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            itemNumberTB.Text = itemsDGV.SelectedRows[0].Cells[0].Value.ToString();
            itemNameTB.Text = itemsDGV.SelectedRows[0].Cells[1].Value.ToString();
            categoryCB.Text = itemsDGV.SelectedRows[0].Cells[2].Value.ToString();
            itemPriceTB.Text = itemsDGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (itemNameTB.Text == "" || itemPriceTB.Text == "" || itemNumberTB.Text == "" || categoryCB.Text == "")
            {
                MessageBox.Show("Please enter all the values");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to edit items?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("UpdateItems", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            int itemNumber = int.Parse(itemNumberTB.Text);
                            string itemName = itemNameTB.Text;
                            string itemCategory = categoryCB.SelectedItem.ToString();
                            int itemPrice = int.Parse(itemPriceTB.Text);
                            cmd.Parameters.AddWithValue("@itemNumber", itemNumber);
                            cmd.Parameters.AddWithValue("@itemName", itemName);
                            cmd.Parameters.AddWithValue("@itemCategory", itemCategory);
                            cmd.Parameters.AddWithValue("@itemPrice", itemPrice);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Item edited successfully");
                            conn.Close();
                            PopulateGrid();
                        }

                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("An error occured: " + Ex.Message);
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (itemNameTB.Text == "" || itemPriceTB.Text == "" || itemNumberTB.Text == "" || categoryCB.Text == "")
            {
                MessageBox.Show("Please select the item to be deleted");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("DeleteItem", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            int itemNum = Convert.ToInt32(itemNumberTB.Text);
                            cmd.Parameters.AddWithValue("itemNum", itemNum);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data deleted successfully!");
                            conn.Close();
                            PopulateGrid();
                        }
                    }
                    catch (Exception Ex)
                    {

                        MessageBox.Show("An error occured: " + Ex.Message);
                    }
                    
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            itemNameTB.Text = "";
            itemPriceTB.Text = "";
            itemNumberTB.Text = "";
            categoryCB.Text = "";
        }
    }
}
