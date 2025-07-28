namespace ADBMS_PROJ
{
    partial class FindEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindEmployee));
            textBox1 = new TextBox();
            label1 = new Label();
            button11 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(196, 65);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 36);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(220, 9);
            label1.Name = "label1";
            label1.Size = new Size(355, 35);
            label1.TabIndex = 1;
            label1.Text = "Email You Want To Search For?";
            // 
            // button11
            // 
            button11.BackColor = Color.SteelBlue;
            button11.FlatAppearance.BorderColor = Color.White;
            button11.FlatAppearance.CheckedBackColor = Color.DeepSkyBlue;
            button11.FlatAppearance.MouseDownBackColor = Color.Black;
            button11.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 11F);
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Location = new Point(502, 65);
            button11.Name = "button11";
            button11.Size = new Size(122, 36);
            button11.TabIndex = 11;
            button11.Text = "Next";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.CheckedBackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.MouseDownBackColor = Color.Black;
            button1.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(316, 370);
            button1.Name = "button1";
            button1.Size = new Size(163, 59);
            button1.TabIndex = 12;
            button1.Text = "Save Changes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MediumTurquoise;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 89);
            dataGridView1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(295, 227);
            label2.Name = "label2";
            label2.Size = new Size(187, 35);
            label2.TabIndex = 14;
            label2.Text = "Change Role To";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ButtonFace;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Customer", "Employee", "Admin" });
            comboBox1.Location = new Point(316, 274);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 15;
            // 
            // FindEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(button11);
            Controls.Add(label1);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            Name = "FindEmployee";
            Text = "FindEmployee";
            Load += FindEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button11;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label2;
        private ComboBox comboBox1;
    }
}