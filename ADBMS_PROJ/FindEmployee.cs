using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADBMS_PROJ
{
    public partial class FindEmployee : Form
    {
        public FindEmployee()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Employee WHERE email = :email";
            var parameters = new List<OracleParameter>
            {
                new ("email", textBox1.Text.Trim())
            };

            var result = OracleDb.ExecuteQuery(sql, parameters);

            if (result != null)
            {
                dataGridView1.Show();
                button1.Show();
                label2.Show();
                comboBox1.Show();
                dataGridView1.DataSource = result;
            }

            else
            {
                MessageBox.Show("Email Not Found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? selectedRole = comboBox1.SelectedItem?.ToString();
            string email = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please select a role first.", "No Role Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter an email to update.", "Missing Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get current role of the employee
            string getRoleSql = "SELECT ROLE FROM Employee WHERE EMAIL = :email";
            var getRoleParams = new List<OracleParameter>
            {
                new OracleParameter("email", email)
            };

            var currentRoleResult = OracleDb.ExecuteQuery(getRoleSql, getRoleParams);

            if (currentRoleResult.Rows.Count == 0)
            {
                MessageBox.Show("No employee found with this email.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string? currentRole = currentRoleResult.Rows[0]["ROLE"]?.ToString();

            if (currentRole == selectedRole)
            {
                MessageBox.Show($"The user already has the role '{selectedRole}'.", "No Change Needed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm role update
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to change the role from '{currentRole}' to '{selectedRole}'?",
                "Confirm Role Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                string updateSql = "UPDATE Employee SET ROLE = :role WHERE EMAIL = :email";
                var updateParams = new List<OracleParameter>
                {
                    new OracleParameter("role", selectedRole),
                    new OracleParameter("email", email)
                };

                OracleDb.ExecuteQuery(updateSql, updateParams); // execute update (no rows returned)

                // Confirm update
                var verify = OracleDb.ExecuteQuery(getRoleSql, getRoleParams);
                string? updatedRole = verify.Rows[0]["ROLE"]?.ToString();

                if (updatedRole == selectedRole)
                {
                    MessageBox.Show("Role updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update the role. Please try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Role update canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FindEmployee_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            button1.Hide();
            label2.Hide();
            comboBox1.Hide();
        }
    }
}
