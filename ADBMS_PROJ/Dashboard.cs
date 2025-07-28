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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new StationForm().ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new ControlCenterForm().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new RouteForm().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AddTrainForm().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new SignupForm().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new EmergencyForm().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new maintenanceScheduleForm().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new TicketForm().ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new VIewAllDataForm().ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new AssignEmployee().ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new FindEmployee().ShowDialog();
        }
    }
}
