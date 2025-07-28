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
    public partial class maintenanceScheduleForm : Form
    {
        public maintenanceScheduleForm()
        {
            InitializeComponent();
        }

        private void maintenanceScheduleForm_Load(object sender, EventArgs e)
        {
            string sql = "SELECT Train_Name, Train_Id FROM Train";
            DataTable trains = OracleDb.ExecuteQuery(sql);

            comboBox1.DataSource = trains.Copy();
            comboBox1.DisplayMember = "Train_Name";
            comboBox1.ValueMember = "Train_Id";
            //comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = @"
            INSERT INTO MaintenanceSchedule (
                Train_ID,
                Schedule_Date,
                Status,
                Description
            ) VALUES (
                :Train_ID,
                :Schedule_Date,
                :Status,
                :Description
            )"
            ;

            var parameters = new List<OracleParameter>
            {
                new ("Train_ID", comboBox1.SelectedValue),
                new ("Schedule_Date", dateTimePicker1.Value),
                new ("Status", comboBox2.Text),
                new ("Description", richTextBox1.Text),
            };

            OracleDb.ExecuteQuery(sql, parameters);

            MessageBox.Show("Maintenance schedule added successfully.");
        }
    }
}
