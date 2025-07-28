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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Employee WHERE email = :email";
            var parameters = new List<OracleParameter>
            {
                new ("email", textBox1.Text.Trim())
            };

            var result = OracleDb.ExecuteQuery(sql, parameters);

            if (result.Rows.Count != 1)
            {
                MessageBox.Show("Invalid email.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool verifyPass = BCrypt.Net.BCrypt.Verify(textBox2.Text.Trim(), result.Rows[0]["password"].ToString());
            string? role = result.Rows[0]["role"].ToString();

            if (verifyPass == true)
            {
                Hide();

                if (role == "Admin")
                {
                    new Dashboard().Show();
                }

                else if (role == "Customer")
                {
                    new CustomerDashboard(textBox1.Text.Trim()).Show();
                }

                else if (role == "Employee")
                {
                    new CustomerDashboard(textBox1.Text.Trim()).Show();
                }

                else
                {
                    MessageBox.Show("Other roles is under maintainance!");
                }
            }
            else
            {
                MessageBox.Show("Invalid password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
