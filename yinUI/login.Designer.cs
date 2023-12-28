using SkeetFramework;

namespace yinUI
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            yinBackground1 = new yinBackground();
            shadowLabel1 = new shadowLabel();
            yinTextBox1 = new yinTextBox();
            yinButton1 = new yinButton();
            yinBackground1.SuspendLayout();
            SuspendLayout();
            // 
            // yinBackground1
            // 
            yinBackground1.BackColor = Color.FromArgb(23, 23, 23);
            yinBackground1.Controls.Add(shadowLabel1);
            yinBackground1.Controls.Add(yinTextBox1);
            yinBackground1.Controls.Add(yinButton1);
            yinBackground1.Dock = DockStyle.Fill;
            yinBackground1.Location = new Point(0, 0);
            yinBackground1.Name = "yinBackground1";
            yinBackground1.Size = new Size(800, 450);
            yinBackground1.TabIndex = 0;
            yinBackground1.Text = "yinBackground1";
            yinBackground1.Click += yinBackground1_Click;
            // 
            // shadowLabel1
            // 
            shadowLabel1.BackColor = Color.Transparent;
            shadowLabel1.EnableShadow = false;
            shadowLabel1.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            shadowLabel1.ForeColor = SystemColors.ButtonFace;
            shadowLabel1.Location = new Point(569, 427);
            shadowLabel1.Name = "shadowLabel1";
            shadowLabel1.ShadowColor = Color.LightGray;
            shadowLabel1.ShadowOffset = 1;
            shadowLabel1.Size = new Size(228, 15);
            shadowLabel1.TabIndex = 7;
            shadowLabel1.Text = "yin Omega - Public v1.0 (made by detective)";
            // 
            // yinTextBox1
            // 
            yinTextBox1.BackColor = Color.Transparent;
            yinTextBox1.ColorBottom = Color.FromArgb(25, 25, 25);
            yinTextBox1.ColorTop = Color.FromArgb(23, 23, 23);
            yinTextBox1.FocusOnHover = false;
            yinTextBox1.Location = new Point(207, 220);
            yinTextBox1.MaxLength = 32767;
            yinTextBox1.Multiline = false;
            yinTextBox1.Name = "yinTextBox1";
            yinTextBox1.ReadOnly = false;
            yinTextBox1.Size = new Size(435, 23);
            yinTextBox1.TabIndex = 1;
            yinTextBox1.TextAlign = HorizontalAlignment.Left;
            yinTextBox1.TextColor = Color.FromArgb(192, 192, 192);
            yinTextBox1.UseSystemPasswordChar = true;
            yinTextBox1.TextChanged += yinTextBox1_TextChanged;
            // 
            // yinButton1
            // 
            yinButton1.ColorBottom = Color.FromArgb(25, 25, 25);
            yinButton1.ColorTop = Color.FromArgb(23, 23, 23);
            yinButton1.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinButton1.Location = new Point(362, 288);
            yinButton1.Name = "yinButton1";
            yinButton1.Size = new Size(75, 23);
            yinButton1.TabIndex = 0;
            yinButton1.Text = "login";
            yinButton1.Click += yinButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(yinBackground1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "login";
            Text = "login";
            yinBackground1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private yinBackground yinBackground1;
        private yinTextBox yinTextBox1;
        private yinButton yinButton1;
        private shadowLabel shadowLabel1;
    }
}