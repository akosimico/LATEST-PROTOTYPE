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

namespace ThesisPrototype
{
    public partial class DataGridOS : Form
    {
        public static readonly string constring = "Data Source=DESKTOP-33UQUOB\\SQLEXPRESS;Initial Catalog=ChefJoyDB;Integrated Security=True";
        public DataGridOS()
        {
            InitializeComponent();
            dataLoad DL = new dataLoad();
                string sql = "SELECT FoodID AS FoodID, QTY AS Qty, PRICE AS Price\r\nFROM Orders\r\nORDER BY FoodID DESC;";
            DL.PopulateDataGridView(dataGridView1, constring, sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public class dataLoad
        {
            public void PopulateDataGridView(DataGridView dataGridView, string connectionString, string sql)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
        }
    }
}
