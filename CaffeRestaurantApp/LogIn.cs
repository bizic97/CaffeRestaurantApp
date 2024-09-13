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
    public partial class LogIn : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=DESKTOP-NDT7O5N\SQLEXPRESS;Initial Catalog=Caffe;Trusted_Connection=True;MultipleActiveResultSets=True");
        public LogIn()
        {
            InitializeComponent();
        }

        private void guestModeLabel_Click(object sender, EventArgs e)
        {
            GuestOrders guestOrders = new GuestOrders();
            guestOrders.Show();
            this.Hide();
        }
        public static string user;
        private void logInButton_Click(object sender, EventArgs e)
        {
            user = userNameTB.Text;
            if(userNameTB.Text=="" || passwordTB.Text=="")
            {
                MessageBox.Show("Enter username or password");
            }
            else
            {

                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SelectUsers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    string userName=userNameTB.Text;
                    string password= passwordTB.Text;
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@password", password);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    cmd.ExecuteNonQuery();
                    if (table.Rows[0][0].ToString()=="1" )
                    {
                        EmployeeOrder employeeOrder = new EmployeeOrder();
                        employeeOrder.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password");
                    }
                  
                    conn.Close();
                }
            }
            

        }

        private void newEmployeeLabel_Click(object sender, EventArgs e)
        {
            CreateNewEmployee newEmployee = new CreateNewEmployee();
            newEmployee.Show();
            this.Hide();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}