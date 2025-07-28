namespace ADBMS_PROJ
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            button1 = new Button();
            button2 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(780, 12);
            button1.Name = "button1";
            button1.Size = new Size(91, 41);
            button1.TabIndex = 0;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue;
            button2.FlatAppearance.MouseOverBackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(666, 12);
            button2.Name = "button2";
            button2.Size = new Size(91, 41);
            button2.TabIndex = 1;
            button2.Text = "Sign In";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.SteelBlue;
            button8.FlatAppearance.BorderColor = Color.White;
            button8.FlatAppearance.CheckedBackColor = Color.DeepSkyBlue;
            button8.FlatAppearance.MouseDownBackColor = Color.Black;
            button8.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 13F);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(201, 466);
            button8.Name = "button8";
            button8.Size = new Size(425, 59);
            button8.TabIndex = 18;
            button8.Text = "Continue Without Account";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(883, 550);
            Controls.Add(button8);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "LandingPage";
            Text = "LandingPage";
            Load += LandingPage_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button8;
    }
}