namespace ADBMS_PROJ
{
    partial class NoLoginDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoLoginDashboard));
            button8 = new Button();
            button1 = new Button();
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
            button8.Location = new Point(262, 197);
            button8.Name = "button8";
            button8.Size = new Size(206, 59);
            button8.TabIndex = 18;
            button8.Text = "Book Ticket";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(697, 12);
            button1.Name = "button1";
            button1.Size = new Size(91, 41);
            button1.TabIndex = 19;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            // 
            // NoLoginDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button8);
            DoubleBuffered = true;
            Name = "NoLoginDashboard";
            Text = "NoLoginDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button button8;
        private Button button1;
    }
}