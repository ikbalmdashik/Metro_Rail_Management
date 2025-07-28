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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ADBMS_PROJ
{
    public partial class CustomerDashboard : Form
    {
        private readonly string email;
        public CustomerDashboard(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new TicketForm().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new EmergencyForm().ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new MyData(this.email).ShowDialog();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            label1.Text = this.email;

            string sql = "SELECT * FROM Employee WHERE email = :email";
            var parameters = new List<OracleParameter>
            {
                new ("email", this.email)
            };

            var result = OracleDb.ExecuteQuery(sql, parameters);

            if (result.Rows[0]["role"]?.ToString() == "Employee")
            {
                button4.Show();
            }

            else
            {
                button4.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AddTrainForm().ShowDialog();
        }
    }
}
