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
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == comboBox2.SelectedValue)
            {
                MessageBox.Show("Destination cannot be the same as departure.");
                return;
            }


            string sql = @"
            INSERT INTO Ticket (
                Passenger_Name,
                Origin_StationCode,
                Destination_StationCode,
                Fare,
                Travel_Date,
                Ticket_Type
            ) VALUES (
                :Passenger_Name,
                :Origin_StationCode,
                :Destination_StationCode,
                :Fare,
                :Travel_Date,
                :Ticket_Type
            )";

            var parameters = new List<OracleParameter>
            {
                new ("Passenger_Name", textBox2.Text.Trim()),
                new ("Origin_StationCode", comboBox1.SelectedValue),
                new ("Destination_StationCode", comboBox2.SelectedValue),
                new ("Fare", Convert.ToDecimal(textBox3.Text.Trim())),
                new ("Travel_Date", dateTimePicker1.Value),
                new ("Ticket_Type", textBox4.Text.Trim())
            };

            OracleDb.ExecuteQuery(sql, parameters);

            MessageBox.Show("Ticket booked successfully.");
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            string sql = "SELECT Station_Name, Station_Code FROM Station";
            DataTable stations = OracleDb.ExecuteQuery(sql);

            comboBox1.DataSource = stations.Copy();
            comboBox1.DisplayMember = "Station_Name";
            comboBox1.ValueMember = "Station_Code";
            //comboBox1.SelectedIndex = 0;

            comboBox2.DataSource = stations.Copy();
            comboBox2.DisplayMember = "Station_Name";
            comboBox2.ValueMember = "Station_Code";
            //comboBox2.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
