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
    public partial class Users : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=DESKTOP-NDT7O5N\SQLEXPRESS;Initial Catalog=Caffe;Trusted_Connection=True;MultipleActiveResultSets=True");
        
        public Users()
        {
            InitializeComponent();
        }
        private void PopulateGrid()
        {
            conn.Open();
            using(SqlCommand cmd = new SqlCommand("SelectFromUsers", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                usersDGV.DataSource = dt;
                conn.Close();
            }
        }

        private void goToOrdersButton_Click(object sender, EventArgs e)
        {
            EmployeeOrder employeeOrder = new EmployeeOrder();
            employeeOrder.Show();
            this.Hide();
        }

        private void goToItemsButton_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.Show();
            this.Hide();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }
        int UserKey;
        private void changeUserButton_Click(object sender, EventArgs e)
        {            
            if (userNameTB.Text == "")
            {
                MessageBox.Show("Please select the user to edit");
            }
            else if (newUsernameTB.Text == "" || newPasswordTB.Text == "")
            {
               MessageBox.Show("Enter the username and password you want to edit");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to edit information about the User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
               if (result == DialogResult.Yes)
               {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("UpdateUser", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            int userKey = UserKey;
                            string uName = newUsernameTB.Text;
                            string uPassword = newPasswordTB.Text;
                            cmd.Parameters.AddWithValue("@uName", uName);
                            cmd.Parameters.AddWithValue("uPassword", uPassword);
                            cmd.Parameters.AddWithValue("userKey", UserKey);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("User updated successfully");
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

        private void usersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserKey = Convert.ToInt32(usersDGV.SelectedRows[0].Cells[0].Value.ToString());
            userNameTB.Text = usersDGV.SelectedRows[0].Cells[1].Value.ToString();
            
        }
    }
}
