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
    public partial class StationForm : Form
    {
        public StationForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = @"
            INSERT INTO Station (
                Station_Code,
                Station_Name,
                Location,
                Available_Facilities,
                Platform_Details
            ) VALUES (
                :Station_Code,
                :Station_Name,
                :Location,
                :Available_Facilities,
                :Platform_Details
            )";

            var parameters = new List<OracleParameter>
            {
                new ("Station_Code", textBox1.Text.Trim()),
                new ("Station_Name", textBox2.Text.Trim()),
                new ("Location", textBox4.Text.Trim()),
                new ("Available_Facilities", richTextBox1.Text.Trim()),
                new ("Platform_Details", textBox3.Text.Trim())
            };

            OracleDb.ExecuteQuery(sql, parameters);

            MessageBox.Show("Station added successfully.");
        }

        private void StationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
