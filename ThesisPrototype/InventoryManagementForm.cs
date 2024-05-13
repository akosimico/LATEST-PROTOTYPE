using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ThesisPrototype
{
    public partial class InventoryManagementForm : Form
    {
        public InventoryManagementForm()
        {
            InitializeComponent();
        }
        public static readonly string _constring = "Data Source=DESKTOP-33UQUOB\\SQLEXPRESS;Initial Catalog=ChefJoyDB;Integrated Security=True;";
        public static SqlConnection connection = new SqlConnection(_constring);
        
        private void InventoryManagementForm_Load(object sender, EventArgs e)
        {
            GetSession();
            using (SqlConnection connection = new SqlConnection(_constring))
            {
                connection.Open();
                string query = "SELECT ProductID, ProductName FROM CJ_Products";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        ProductIDCB.DataSource = dt;
                        ProductIDCB.DisplayMember = "ProductName";
                        ProductIDCB.ValueMember = "ProductID";
                    }
                }
            }
            int quantity = Convert.ToInt32(qtyCB.SelectedValue) == 0 ? 1 : Convert.ToInt32(qtyCB.SelectedValue);


        }
        public void GetSession()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-33UQUOB\\SQLEXPRESS;Initial Catalog=ChefJoyDB;Integrated Security=True"))
            {
                string query = "SELECT SessionID FROM CJ_Session WHERE SessionID= (SELECT MAX(SessionID) FROM CJ_Session)\r\n";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sessionIDDisplay.Text = ("Session ID: " + reader["SessionId"]);
                        }
                    }

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        { //Save BTN
            
            int productID = (int)ProductIDCB.SelectedValue;
            if (string.IsNullOrEmpty(qtyCB.Text) || string.IsNullOrEmpty(P1.Text)) { 
                MessageBox.Show("Please enter a value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (ProductIDCB.SelectedValue == null)
            {
                MessageBox.Show("Please select a Product ID.", "Chef Joy Application", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Click yes to confirm.", "Chef Joy Application", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(_constring))
                {
                    connection.Open();
                    string getSessionQuery = "SELECT SessionID FROM CJ_Session WHERE SessionID= (SELECT MAX(SessionID) FROM CJ_Session)";
                    using (SqlCommand getSessionCmd = new SqlCommand(getSessionQuery, connection))
                    {
                        int sessionId = (int)getSessionCmd.ExecuteScalar();

                        string insertQuery = "INSERT INTO CJ_Inventory (SessionID, ProductID, Quantity, Price, Date) VALUES (@SessionID, @ProductID, @Quantity, @Price, @Date)";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                        {
                            insertCmd.Parameters.AddWithValue("@SessionID", sessionId);
                            insertCmd.Parameters.AddWithValue("@Date", DateTime.Now);
                            insertCmd.Parameters.AddWithValue("@ProductID", ProductIDCB.SelectedValue);
                            insertCmd.Parameters.AddWithValue("@Quantity", qtyCB.SelectedValue ?? 0);
                            insertCmd.Parameters.AddWithValue("@Price", P1.Text);
                            insertCmd.ExecuteNonQuery();

                            MessageBox.Show("Saved successfully!", "Chef Joy Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
            
        

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}