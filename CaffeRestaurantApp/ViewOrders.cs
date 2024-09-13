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
    public partial class ViewOrders : Form
    {
        SqlConnection conn = new SqlConnection(@"data source=DESKTOP-NDT7O5N\SQLEXPRESS;Initial Catalog=Caffe;Trusted_Connection=True;MultipleActiveResultSets=True");
        public ViewOrders()
        {
            InitializeComponent();
        }
        private void PopulateGrid()
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("SelectOrders", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ordersDGV.DataSource = dt;
                conn.Close();
            }
        }
        private void ViewOrders_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ordersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(printPreviewOrder.ShowDialog()==DialogResult.OK)
            {
                printOrder.Print();
            }

        }

        private void printOrder_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("---------Order Summary---------", new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Black, new Point(200,40));
            e.Graphics.DrawString("----------------------------------------------------------------", new Font("Times New Roman", 25, FontStyle.Bold), Brushes.Black, new Point(20, 60));
            e.Graphics.DrawString($"Order Number:{ordersDGV.SelectedRows[0].Cells[0].Value.ToString()}", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(200, 100));
            e.Graphics.DrawString($"Seller Name:{ordersDGV.SelectedRows[0].Cells[1].Value.ToString()}", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(200, 120));
            e.Graphics.DrawString($"Order Date:{ordersDGV.SelectedRows[0].Cells[2].Value.ToString()}", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(200, 140));
            e.Graphics.DrawString($"Order Amount:{ordersDGV.SelectedRows[0].Cells[3].Value.ToString()} $", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(200, 160));
        }
    }
}
