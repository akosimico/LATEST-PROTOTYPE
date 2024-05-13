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
    public partial class SalesOperationForms : Form
    {
        public SalesOperationForms()
        {
            InitializeComponent();
        }
    
        private void SalesOperationForms_Load(object sender, EventArgs e)
        {
            GetSession();
            openChildForm(new DataGridOS());
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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        { //FoodID

                string constring = "Data Source=DESKTOP-33UQUOB\\SQLEXPRESS;Initial Catalog=ChefJoyDB;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(constring);
            SqlCommand command = new SqlCommand("INSERT INTO Orders (FoodID, Qty, Price)\r\nSELECT TOP 5 FoodID AS FoodID, QTY AS Qty, PRICE AS Price FROM Orders ORDER BY FoodID DESC;", connection);
            connection.Open();
            object result = command.ExecuteScalar();
            connection.Close();
            MessageBox.Show("Done1");
        }
        public class AddOrder
        {

        }
    }
}
