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

namespace ADBMS_PROJ
{
    public partial class AssignEmployee : Form
    {
        public AssignEmployee()
        {
            InitializeComponent();
        }

        private void AssignEmployee_Load(object sender, EventArgs e)
        {
            string sql = "SELECT Emp_Id, Full_Name FROM Employee WHERE role = 'Employee'";
            DataTable employees = OracleDb.ExecuteQuery(sql);

            comboBox1.DataSource = employees.Copy();
            comboBox1.DisplayMember = "Full_Name";
            comboBox1.ValueMember = "Emp_Id";
            //comboBox1.SelectedIndex = 0;

            string sql1 = "SELECT Station_Name, Station_Code FROM Station";
            DataTable stations = OracleDb.ExecuteQuery(sql1);

            comboBox4.DataSource = stations.Copy();
            comboBox4.DisplayMember = "Station_Name";
            comboBox4.ValueMember = "Station_Code";
            //comboBox4.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = @"
            INSERT INTO AssignedEmployee (
                Assignment_ID,
                Emp_ID,
                Station_Code,
                Assigned_Date,
                Duty_Type,
                Shift,
                Notes
            ) VALUES (
                seq_assigned_employee.NEXTVAL,
                :Emp_ID,
                :Station_Code,
                :Assigned_Date,
                :Duty_Type,
                :Shift,
                :Notes
            )";

            var parameters = new List<OracleParameter>
            {
                new("Emp_ID", comboBox1.SelectedValue),
                new("Station_Code", comboBox4.SelectedValue),
                new("Assigned_Date", dateAssigned.Value),
                new("Duty_Type", comboBox2.Text.Trim()),
                new("Shift", comboBox3.Text.Trim()),
                new("Notes", txtNotes.Text.Trim())
            };

            OracleDb.ExecuteQuery(sql, parameters);

            MessageBox.Show("Employee assigned successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
