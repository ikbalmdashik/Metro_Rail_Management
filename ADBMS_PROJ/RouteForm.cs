using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADBMS_PROJ
{
    public partial class RouteForm : Form
    {
        public RouteForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected Control_CenterID from the ComboBox
            int controlCenterId = Convert.ToInt32(comboBox1.SelectedValue); // SelectedValue will be the Control_CenterID

            // Get Line_Name from TextBox
            string lineName = textBox2.Text.Trim();

            // Insert into Route using the selected Control_CenterID
            string sql = "INSERT INTO Route (Control_CenterID, Line_Name) VALUES (:Control_CenterID, :Line_Name)";

            var parameters = new List<OracleParameter>
            {
                new OracleParameter("Control_CenterID", controlCenterId),
                new OracleParameter("Line_Name", lineName)
            };

            // Execute the query (this assumes OracleDb.ExecuteQuery handles it correctly)
            OracleDb.ExecuteQuery(sql, parameters);

            MessageBox.Show("Route added successfully.");
        }

        private void RouteForm_Load(object sender, EventArgs e)
        {
            string sql = "SELECT Center_ID, Center_Name FROM ControlCenter";

            // Execute the query and retrieve the data as a list or DataTable
            DataTable dataTable = OracleDb.ExecuteQuery(sql);

            // Set ComboBox DataSource to the DataTable
            comboBox1.DataSource = dataTable;

            // Set the text to be shown in the ComboBox (the Center_Name)
            comboBox1.DisplayMember = "Center_Name";

            // Set the actual value of the selected item (the Center_ID)
            comboBox1.ValueMember = "Center_ID";

            // Optionally, set a default selection (e.g., the first item)
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0; // Default select the first item
            }
        }
    }
}
