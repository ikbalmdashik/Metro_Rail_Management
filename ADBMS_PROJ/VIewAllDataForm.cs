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
    public partial class VIewAllDataForm : Form
    {
        public VIewAllDataForm()
        {
            InitializeComponent();
            InitializeScrollPanel();
        }

        private int currentY = 10;
        private Panel scrollPanel;

        private void InitializeScrollPanel()
        {
            scrollPanel = new Panel
            {
                AutoScroll = true,    // Enable scrolling when content overflows
                Dock = DockStyle.Fill // Fill the form or set to specific size
            };

            // Add the panel to the form's Controls collection
            this.Controls.Add(scrollPanel);
        }

        private void DataViwe(string sql, string labelText)
        {
            try
            {
                // Create and place label inside scrollPanel
                var label = new Label
                {
                    Text = labelText,
                    Location = new Point(10, currentY),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };
                scrollPanel.Controls.Add(label);
                currentY += label.Height + 5; // Move below label

                // Execute SQL and create grid
                DataTable data = OracleDb.ExecuteQuery(sql);
                var grid = new DataGridView
                {
                    DataSource = data,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                    ScrollBars = ScrollBars.Vertical,
                    ReadOnly = true,
                    AllowUserToAddRows = false,
                    AllowUserToDeleteRows = false,
                    Width = 1200,
                    Location = new Point(10, currentY)
                };

                int rowHeight = grid.RowTemplate.Height;
                int maxRowsVisible = 10;
                int rowCount = Math.Min(data.Rows.Count, maxRowsVisible);
                int headerHeight = grid.ColumnHeadersHeight;
                int totalHeight = rowCount * rowHeight + headerHeight + 2;

                grid.Height = totalHeight;

                // Add to scrollPanel and move down for the next control
                scrollPanel.Controls.Add(grid);
                currentY += grid.Height + 20; // Extra space before next section
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void VIewAllDataForm_Load(object sender, EventArgs e)
        {
            DataViwe("SELECT * FROM Station", "Stations");
            DataViwe("SELECT * FROM ControlCenter", "Control Centers");
            DataViwe("SELECT * FROM Route", "Routes");
            DataViwe("SELECT * FROM Train", "Trains");
            DataViwe("SELECT * FROM Employee", "Employees");
            DataViwe("SELECT * FROM AssignedEmployee", "Assigned Employees");
            DataViwe("SELECT * FROM Ticket", "Booked Tickets");
            DataViwe("SELECT * FROM MaintenanceSchedule ", "Maintenance Schedule ");
            DataViwe("SELECT * FROM Emergency", "Emergency Reports");
        }

        
    }
}
