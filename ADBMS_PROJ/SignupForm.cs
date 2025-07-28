using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Oracle.ManagedDataAccess.Client;

namespace ADBMS_PROJ
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void AssignEmployeeForm_Load(object sender, EventArgs e)
        {
            string sql = "SELECT Station_Name, Station_Code FROM Station";
            DataTable stations = OracleDb.ExecuteQuery(sql);

            comboBox2.DataSource = stations.Copy();
            comboBox2.DisplayMember = "Station_Name";
            comboBox2.ValueMember = "Station_Code";
            //comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string? selectedRole = comboBox3.SelectedItem?.ToString();
            string fullName = textBox2.Text.Trim();
            string email = textBox1.Text.Trim();
            string password = textBox3.Text.Trim();

            if (ValidationCheck.IsNullOrWhiteSpace(fullName) ||
                ValidationCheck.IsNullOrWhiteSpace(email) ||
                ValidationCheck.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (!ValidationCheck.IsValidName(fullName))
            {
                MessageBox.Show("Invalid name format.");
                return;
            }

            if (!ValidationCheck.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            if (!ValidationCheck.IsStrongPassword(password))
            {
                MessageBox.Show("Weak password. Must include upper, lower, and number.");
                return;
            }

            // Validate role selection
            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please select role.");
                return;
            }

            string checkEmailSql = "SELECT COUNT(*) FROM Employee WHERE Email = :Email";
            var checkEmailParams = new List<OracleParameter>
            {
                new("Email", email)
            };

            DataTable result = OracleDb.ExecuteQuery(checkEmailSql, checkEmailParams); // Assume this method returns a single value
            int userCount = Convert.ToInt32(result.Rows[0][0]);

            if (userCount == 1)
            {
                MessageBox.Show("This email is already registered.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = @"
            INSERT INTO Employee (
                Full_Name,
                Joining_Date,
                Assigned_StationCode,
                Email,
                Password,
                Role
            ) VALUES (
                :Full_Name,
                :Joining_Date,
                :Assigned_StationCode,
                :Email,
                :Password,
                :Role
            )";

            var parameters = new List<OracleParameter>
            {
                new ("Full_Name", fullName),
                new ("Joining_Date", dateTimePicker1.Value),
                new ("Assigned_StationCode", comboBox2.SelectedValue),
                new ("Email", email),
                new ("Password",  BCrypt.Net.BCrypt.HashPassword(password, 5)),
                new ("Role", selectedRole)
            };

            OracleDb.ExecuteQuery(sql, parameters);

            MessageBox.Show("Employee added successfully.");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
