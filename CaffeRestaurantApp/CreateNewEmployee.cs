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
   
    public partial class CreateNewEmployee : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=DESKTOP-NDT7O5N\SQLEXPRESS;Initial Catalog=Caffe;Trusted_Connection=True;MultipleActiveResultSets=True");
        public CreateNewEmployee()
        {
            InitializeComponent();
        }
        public static string user;
        private void createNewButton_Click(object sender, EventArgs e)
        {
           
            try
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("InsertIntoUsers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    string userName = userNameTB.Text;
                    string password = passwordTB.Text;
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("You have succssefully created new employee users account");
                LogIn log = new LogIn();
                log.Show();
                this.Hide();
                MessageBox.Show("Log in to your account");
                
            }
            catch (Exception Ex)
            {

                MessageBox.Show("An error occured: " + Ex.Message);
            }
            
        }

        private void backToLoginLabel_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }

        private void CreateNewEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
