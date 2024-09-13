using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CateringShopApp
{
    public partial class GuestOrders : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=DESKTOP-NDT7O5N\SQLEXPRESS;Initial Catalog=Caffe;Trusted_Connection=True;MultipleActiveResultSets=True");
        public GuestOrders()
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

        private void FilterByCategory()
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("SelectByCategory", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                string itemCategory = categoryCB.SelectedItem.ToString();
                cmd.Parameters.AddWithValue("@itemCategory", itemCategory);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                itemsDGV.DataSource = dt;
                conn.Close();
            }
        }

        private void logOutLabel_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        DataTable table = new DataTable();
        int flag = 0;
        int num = 0;
        int price, total;
        string item, category;

        private void GuestOrders_Load(object sender, EventArgs e)
        {
            PopulateGrid();
            table.Columns.Add("Number", typeof(int));
            table.Columns.Add("ItemName", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("Total", typeof(int));
            orderDGV.DataSource = table;
            datelabel.Text = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Day.ToString() + "/" + DateTime.Today.Year.ToString();
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (quantityTB.Text == "")
            {
                MessageBox.Show("Please enter the quantity");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Please select the product to add to cart");
            }
            else

            {
                num = num + 1;
                total = price * Convert.ToInt32(quantityTB.Text);
                table.Rows.Add(num, item, category, price, total);
                orderDGV.DataSource = table;
                flag = 0;
            }
            sum += total;
            amountLabel.Text = ""+sum;
        }

        private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterByCategory();
        }
        int sum = 0;
        private void refreshButton_Click(object sender, EventArgs e)
        {
            PopulateGrid();
        }
       
        private void itemsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            item = itemsDGV.SelectedRows[0].Cells[1].Value.ToString();
            category = itemsDGV.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32(itemsDGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            //Do ovde si stigao napravi query u sql ne zaboravi i u drugoj aplikaciji da popravis datum
            DialogResult result = MessageBox.Show("Are you sure you want to create a order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertIntoOrders", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        string selerName = sellerNameTB.Text;
                        //int orderNumber = int.Parse(orderNumberTB.Text);
                        DateTime date = DateTime.Parse(datelabel.Text);
                        int orderAmount = int.Parse(amountLabel.Text);
                        cmd.Parameters.AddWithValue("@selerName", selerName);
                        //cmd.Parameters.AddWithValue("@orderNumber", orderNumber);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@orderAmount", orderAmount);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order successfully created");
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
}
