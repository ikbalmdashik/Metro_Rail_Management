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
    public partial class AddTrainForm : Form
    {
        public AddTrainForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "SELECT Route_No, Line_Name FROM Route";
            DataTable routeTable = OracleDb.ExecuteQuery(sql);

            comboBox2.DataSource = routeTable;
            comboBox2.DisplayMember = "Line_Name";    // What user sees
            comboBox2.ValueMember = "Route_No";       // What we use in the insert
            //comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string sql = @"
                INSERT INTO Train (
                    Train_Name,
                    Train_Type,
                    Arrival_Time,
                    Departure_Time,
                    RealTime_Location,
                    Operational_Status,
                    Seating_Capacity,
                    Route_No
                ) VALUES (
                    :Train_Name,
                    :Train_Type,
                    :Arrival_Time,
                    :Departure_Time,
                    :RealTime_Location,
                    :Operational_Status,
                    :Seating_Capacity,
                    :Route_No
                )";


            var parameters = new List<OracleParameter>
            {
                new OracleParameter("Train_Name", textBox2.Text.Trim()),
                new OracleParameter("Train_Type", textBox3.Text.Trim()),
                new OracleParameter("Arrival_Time", dateTimePicker2.Value), // Use DateTimePicker controls
                new OracleParameter("Departure_Time", dateTimePicker3.Value),
                new OracleParameter("RealTime_Location", dateTimePicker1.Text.Trim()),
                new OracleParameter("Operational_Status", textBox1.Text.Trim()),
                new OracleParameter("Seating_Capacity", Convert.ToInt32(textBox4.Text.Trim())),
                new OracleParameter("Route_No", Convert.ToInt32(comboBox2.SelectedValue)) // From ComboBox
            };

            OracleDb.ExecuteQuery(sql, parameters);

            MessageBox.Show("Train added successfully.");
        }
    }
}
