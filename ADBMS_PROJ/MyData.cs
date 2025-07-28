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
    public partial class MyData : Form
    {
        private readonly string email;
        public MyData(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void MyData_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Employee WHERE email = :email";
            var parameters = new List<OracleParameter>
            {
                new ("email", this.email)
            };

            var result = OracleDb.ExecuteQuery(sql, parameters);

            dataGridView1.DataSource = result;
        }
    }
}
