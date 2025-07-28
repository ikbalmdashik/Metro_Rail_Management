namespace ADBMS_PROJ
{
    partial class AssignEmployee
    {
        private System.ComponentModel.IContainer components = null;
        private DateTimePicker dateAssigned;
        private TextBox txtNotes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignEmployee));
            dateAssigned = new DateTimePicker();
            txtNotes = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            SuspendLayout();
            // 
            // dateAssigned
            // 
            dateAssigned.Location = new Point(292, 220);
            dateAssigned.Name = "dateAssigned";
            dateAssigned.Size = new Size(200, 27);
            dateAssigned.TabIndex = 2;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(292, 340);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(300, 100);
            txtNotes.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(697, 482);
            button1.Name = "button1";
            button1.Size = new Size(91, 41);
            button1.TabIndex = 6;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(102, 140);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 7;
            label1.Text = "Employee Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(126, 180);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 8;
            label2.Text = "Station Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(142, 220);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 9;
            label3.Text = "Assign Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(157, 260);
            label4.Name = "label4";
            label4.Size = new Size(100, 28);
            label4.TabIndex = 10;
            label4.Text = "Duty Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(205, 300);
            label5.Name = "label5";
            label5.Size = new Size(52, 28);
            label5.TabIndex = 11;
            label5.Text = "Shift";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(153, 340);
            label6.Name = "label6";
            label6.Size = new Size(105, 28);
            label6.TabIndex = 12;
            label6.Text = "Instruction";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 20F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(232, 35);
            label7.Name = "label7";
            label7.Size = new Size(272, 46);
            label7.TabIndex = 13;
            label7.Text = "Assign Employee";
            // 
            // comboBox1
            // 
            comboBox1.Location = new Point(292, 140);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 28);
            comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.Items.AddRange(new object[] { "Full Time", "Part Time" });
            comboBox2.Location = new Point(292, 260);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 28);
            comboBox2.TabIndex = 15;
            // 
            // comboBox3
            // 
            comboBox3.Items.AddRange(new object[] { "Morning", "Day", "Night", "Others" });
            comboBox3.Location = new Point(292, 300);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(200, 28);
            comboBox3.TabIndex = 16;
            // 
            // comboBox4
            // 
            comboBox4.Location = new Point(292, 180);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(200, 28);
            comboBox4.TabIndex = 17;
            // 
            // AssignEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 535);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dateAssigned);
            Controls.Add(txtNotes);
            DoubleBuffered = true;
            Name = "AssignEmployee";
            Text = "Assign Employee";
            Load += AssignEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
    }
}
