namespace ADBMS_PROJ
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            button8 = new Button();
            button6 = new Button();
            button9 = new Button();
            label1 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button8
            // 
            button8.BackColor = Color.SteelBlue;
            button8.FlatAppearance.BorderColor = Color.White;
            button8.FlatAppearance.CheckedBackColor = Color.DeepSkyBlue;
            button8.FlatAppearance.MouseDownBackColor = Color.Black;
            button8.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 12F);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(277, 106);
            button8.Name = "button8";
            button8.Size = new Size(206, 59);
            button8.TabIndex = 17;
            button8.Text = "Book Ticket";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.SteelBlue;
            button6.FlatAppearance.BorderColor = Color.White;
            button6.FlatAppearance.CheckedBackColor = Color.DeepSkyBlue;
            button6.FlatAppearance.MouseDownBackColor = Color.Black;
            button6.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(281, 202);
            button6.Name = "button6";
            button6.Size = new Size(202, 54);
            button6.TabIndex = 15;
            button6.Text = "Report Emergency";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.SteelBlue;
            button9.FlatAppearance.BorderColor = Color.White;
            button9.FlatAppearance.CheckedBackColor = Color.DeepSkyBlue;
            button9.FlatAppearance.MouseDownBackColor = Color.Black;
            button9.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 12F);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Location = new Point(12, 384);
            button9.Name = "button9";
            button9.Size = new Size(776, 54);
            button9.TabIndex = 18;
            button9.Text = "Profile";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 19;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.CheckedBackColor = Color.DeepSkyBlue;
            button4.FlatAppearance.MouseDownBackColor = Color.Black;
            button4.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(281, 304);
            button4.Name = "button4";
            button4.Size = new Size(206, 54);
            button4.TabIndex = 20;
            button4.Text = "Add Train";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button6);
            DoubleBuffered = true;
            Name = "CustomerDashboard";
            Text = "CustomerDashboard";
            Load += CustomerDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button8;
        private Button button6;
        private Button button9;
        private Label label1;
        private Button button4;
    }
}