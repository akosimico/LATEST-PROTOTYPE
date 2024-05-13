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
    public partial class MainForm : Form
    {
        InventoryManagementForm FormInv;
        SalesOperationForms FormOperation;
        SalesReportForms FormReports;
        public bool sidebarExpand;
        public static readonly string connstring = "Data Source=DESKTOP-33UQUOB\\SQLEXPRESS;Initial Catalog=ChefJoyDB;Integrated Security=True;";
        public static SqlConnection connection = new SqlConnection(connstring);
        
        public MainForm()
        {
            InitializeComponent();
            timer1.Start();
            openChildForm(new Home());
        }
        

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {   //Menu Button


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        { //Inventory Management Button

            openChildForm(new InventoryManagementForm());
            
        }


        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (msgLogout.Show("Are you sure you want to logout?", "Chef Joy Application") == DialogResult.Yes)
            {
                string insertQuery = @"UPDATE CJ_Session set sessionEnd = @sessionEnd";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@sessionEnd", DateTime.Now);

                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                    connection.Close();
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
                                    msgSaved.Text = ("Session saved!\nSessionID:" + reader["SessionId"]);
                                    msgSaved.Show();
                                }
                            }

                        }
                        connection.Close();
                        SwitchFroms SF = new SwitchFroms();
                        SF.Switch(this, new LoginForm());
                    }

                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        public void GetSession()
        {
            
        }

            private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new SalesOperationForms());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            openChildForm(new SalesReportForms());
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

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void guna2Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.time.Text = time.ToString("g");
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            openChildForm(new Home());
        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

