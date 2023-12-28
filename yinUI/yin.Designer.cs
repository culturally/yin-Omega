using SkeetFramework;

namespace yinUI
{
    partial class yin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yin));
            yinBackground1 = new yinBackground();
            shadowLabel1 = new shadowLabel();
            yinButton4 = new yinButton();
            yinButton3 = new yinButton();
            yinGroupBox1 = new yinGroupBox();
            yinToggle1 = new yinToggle();
            yinTextBox4 = new yinTextBox();
            yinTextBox3 = new yinTextBox();
            yinButton2 = new yinButton();
            yinComboBox2 = new yinComboBox();
            yinGroupBox2 = new yinGroupBox();
            yinButton1 = new yinButton();
            yinTextBox2 = new yinTextBox();
            yinTextBox1 = new yinTextBox();
            yinButton5 = new yinButton();
            yinBackground1.SuspendLayout();
            yinGroupBox1.SuspendLayout();
            yinGroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // yinBackground1
            // 
            yinBackground1.BackColor = Color.FromArgb(23, 23, 23);
            yinBackground1.Controls.Add(yinButton5);
            yinBackground1.Controls.Add(shadowLabel1);
            yinBackground1.Controls.Add(yinButton4);
            yinBackground1.Controls.Add(yinButton3);
            yinBackground1.Controls.Add(yinGroupBox1);
            yinBackground1.Controls.Add(yinGroupBox2);
            yinBackground1.Cursor = Cursors.Hand;
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
            shadowLabel1.TabIndex = 6;
            shadowLabel1.Text = "yin Omega - Public v1.0 (made by detective)";
            shadowLabel1.Click += shadowLabel1_Click;
            // 
            // yinButton4
            // 
            yinButton4.ColorBottom = Color.FromArgb(25, 25, 25);
            yinButton4.ColorTop = Color.FromArgb(23, 23, 23);
            yinButton4.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinButton4.Location = new Point(448, 90);
            yinButton4.Name = "yinButton4";
            yinButton4.Size = new Size(267, 23);
            yinButton4.TabIndex = 5;
            yinButton4.Text = "OSINT";
            yinButton4.Click += yinButton4_Click;
            // 
            // yinButton3
            // 
            yinButton3.ColorBottom = Color.FromArgb(25, 25, 25);
            yinButton3.ColorTop = Color.FromArgb(23, 23, 23);
            yinButton3.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinButton3.Location = new Point(448, 60);
            yinButton3.Name = "yinButton3";
            yinButton3.Size = new Size(267, 23);
            yinButton3.TabIndex = 1;
            yinButton3.Text = "IP and Network";
            yinButton3.Click += yinButton3_Click;
            // 
            // yinGroupBox1
            // 
            yinGroupBox1.Controls.Add(yinToggle1);
            yinGroupBox1.Controls.Add(yinTextBox4);
            yinGroupBox1.Controls.Add(yinTextBox3);
            yinGroupBox1.Controls.Add(yinButton2);
            yinGroupBox1.Controls.Add(yinComboBox2);
            yinGroupBox1.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinGroupBox1.Location = new Point(34, 28);
            yinGroupBox1.Name = "yinGroupBox1";
            yinGroupBox1.Size = new Size(265, 165);
            yinGroupBox1.TabIndex = 4;
            yinGroupBox1.TabStop = false;
            yinGroupBox1.Text = "Discord Webhook";
            // 
            // yinToggle1
            // 
            yinToggle1.BackColor = Color.Transparent;
            yinToggle1.Checked = false;
            yinToggle1.ColorBottom = Color.FromArgb(35, 35, 35);
            yinToggle1.ColorBottom1 = Color.FromArgb(124, 161, 27);
            yinToggle1.ColorTop = Color.FromArgb(45, 45, 45);
            yinToggle1.ColorTop1 = Color.FromArgb(154, 197, 39);
            yinToggle1.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinToggle1.Location = new Point(6, 91);
            yinToggle1.Name = "yinToggle1";
            yinToggle1.Size = new Size(99, 11);
            yinToggle1.TabIndex = 5;
            yinToggle1.Text = "custom message";
            yinToggle1.CheckedChanged += yinToggle1_CheckedChanged;
            // 
            // yinTextBox4
            // 
            yinTextBox4.BackColor = Color.Transparent;
            yinTextBox4.ColorBottom = Color.FromArgb(25, 25, 25);
            yinTextBox4.ColorTop = Color.FromArgb(23, 23, 23);
            yinTextBox4.FocusOnHover = false;
            yinTextBox4.Location = new Point(128, 62);
            yinTextBox4.MaxLength = 32767;
            yinTextBox4.Multiline = false;
            yinTextBox4.Name = "yinTextBox4";
            yinTextBox4.ReadOnly = false;
            yinTextBox4.Size = new Size(126, 23);
            yinTextBox4.TabIndex = 4;
            yinTextBox4.Text = "text";
            yinTextBox4.TextAlign = HorizontalAlignment.Left;
            yinTextBox4.TextColor = Color.FromArgb(192, 192, 192);
            yinTextBox4.UseSystemPasswordChar = false;
            yinTextBox4.TextChanged += yinTextBox4_TextChanged;
            // 
            // yinTextBox3
            // 
            yinTextBox3.BackColor = Color.Transparent;
            yinTextBox3.ColorBottom = Color.FromArgb(25, 25, 25);
            yinTextBox3.ColorTop = Color.FromArgb(23, 23, 23);
            yinTextBox3.FocusOnHover = false;
            yinTextBox3.Location = new Point(6, 32);
            yinTextBox3.MaxLength = 32767;
            yinTextBox3.Multiline = false;
            yinTextBox3.Name = "yinTextBox3";
            yinTextBox3.ReadOnly = false;
            yinTextBox3.Size = new Size(248, 23);
            yinTextBox3.TabIndex = 3;
            yinTextBox3.Text = "webhook";
            yinTextBox3.TextAlign = HorizontalAlignment.Left;
            yinTextBox3.TextColor = Color.FromArgb(192, 192, 192);
            yinTextBox3.UseSystemPasswordChar = false;
            yinTextBox3.TextChanged += yinTextBox3_TextChanged;
            // 
            // yinButton2
            // 
            yinButton2.ColorBottom = Color.FromArgb(25, 25, 25);
            yinButton2.ColorTop = Color.FromArgb(23, 23, 23);
            yinButton2.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinButton2.Location = new Point(96, 124);
            yinButton2.Name = "yinButton2";
            yinButton2.Size = new Size(75, 23);
            yinButton2.TabIndex = 2;
            yinButton2.Text = "send";
            yinButton2.Click += yinButton2_Click;
            // 
            // yinComboBox2
            // 
            yinComboBox2.BackColor = Color.FromArgb(45, 45, 48);
            yinComboBox2.ColorBottom = Color.FromArgb(25, 25, 25);
            yinComboBox2.ColorTop = Color.FromArgb(23, 23, 23);
            yinComboBox2.DrawMode = DrawMode.OwnerDrawFixed;
            yinComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            yinComboBox2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            yinComboBox2.ForeColor = Color.White;
            yinComboBox2.FormattingEnabled = true;
            yinComboBox2.ItemHeight = 18;
            yinComboBox2.Items.AddRange(new object[] { "Spam", "Delete" });
            yinComboBox2.Location = new Point(6, 61);
            yinComboBox2.Name = "yinComboBox2";
            yinComboBox2.Size = new Size(92, 24);
            yinComboBox2.TabIndex = 1;
            yinComboBox2.SelectedIndexChanged += yinComboBox2_SelectedIndexChanged;
            // 
            // yinGroupBox2
            // 
            yinGroupBox2.Controls.Add(yinButton1);
            yinGroupBox2.Controls.Add(yinTextBox2);
            yinGroupBox2.Controls.Add(yinTextBox1);
            yinGroupBox2.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinGroupBox2.Location = new Point(34, 199);
            yinGroupBox2.Name = "yinGroupBox2";
            yinGroupBox2.Size = new Size(271, 222);
            yinGroupBox2.TabIndex = 3;
            yinGroupBox2.TabStop = false;
            yinGroupBox2.Text = "SMS Sender";
            // 
            // yinButton1
            // 
            yinButton1.ColorBottom = Color.FromArgb(25, 25, 25);
            yinButton1.ColorTop = Color.FromArgb(23, 23, 23);
            yinButton1.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinButton1.Location = new Point(96, 165);
            yinButton1.Name = "yinButton1";
            yinButton1.Size = new Size(75, 23);
            yinButton1.TabIndex = 2;
            yinButton1.Text = "send";
            yinButton1.Click += yinButton1_Click;
            // 
            // yinTextBox2
            // 
            yinTextBox2.BackColor = Color.Transparent;
            yinTextBox2.ColorBottom = Color.FromArgb(25, 25, 25);
            yinTextBox2.ColorTop = Color.FromArgb(23, 23, 23);
            yinTextBox2.FocusOnHover = false;
            yinTextBox2.Location = new Point(6, 113);
            yinTextBox2.MaxLength = 32767;
            yinTextBox2.Multiline = false;
            yinTextBox2.Name = "yinTextBox2";
            yinTextBox2.ReadOnly = false;
            yinTextBox2.Size = new Size(248, 23);
            yinTextBox2.TabIndex = 1;
            yinTextBox2.Text = "text";
            yinTextBox2.TextAlign = HorizontalAlignment.Left;
            yinTextBox2.TextColor = Color.FromArgb(192, 192, 192);
            yinTextBox2.UseSystemPasswordChar = false;
            yinTextBox2.TextChanged += yinTextBox2_TextChanged;
            // 
            // yinTextBox1
            // 
            yinTextBox1.BackColor = Color.Transparent;
            yinTextBox1.ColorBottom = Color.FromArgb(25, 25, 25);
            yinTextBox1.ColorTop = Color.FromArgb(23, 23, 23);
            yinTextBox1.FocusOnHover = false;
            yinTextBox1.Location = new Point(6, 60);
            yinTextBox1.MaxLength = 32767;
            yinTextBox1.Multiline = false;
            yinTextBox1.Name = "yinTextBox1";
            yinTextBox1.ReadOnly = false;
            yinTextBox1.Size = new Size(248, 23);
            yinTextBox1.TabIndex = 0;
            yinTextBox1.Text = "number";
            yinTextBox1.TextAlign = HorizontalAlignment.Left;
            yinTextBox1.TextColor = Color.FromArgb(192, 192, 192);
            yinTextBox1.UseSystemPasswordChar = false;
            yinTextBox1.TextChanged += yinTextBox1_TextChanged;
            // 
            // yinButton5
            // 
            yinButton5.ColorBottom = Color.FromArgb(25, 25, 25);
            yinButton5.ColorTop = Color.FromArgb(23, 23, 23);
            yinButton5.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinButton5.Location = new Point(448, 119);
            yinButton5.Name = "yinButton5";
            yinButton5.Size = new Size(267, 23);
            yinButton5.TabIndex = 7;
            yinButton5.Text = "Cracking";
            yinButton5.Click += yinButton5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(yinBackground1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "yin - Active";
            Load += Form2_Load;
            yinBackground1.ResumeLayout(false);
            yinGroupBox1.ResumeLayout(false);
            yinGroupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private yinBackground yinBackground1;
        private yinGroupBox yinGroupBox2;
        private yinButton yinButton1;
        private yinTextBox yinTextBox2;
        private yinTextBox yinTextBox1;
        private yinComboBox yinComboBox2;
        private yinGroupBox yinGroupBox1;
        private yinButton yinButton2;
        private yinTextBox yinTextBox3;
        private yinToggle yinToggle1;
        private yinTextBox yinTextBox4;
        private yinButton yinButton3;
        private yinButton yinButton4;
        private shadowLabel shadowLabel1;
        private yinButton yinButton5;
    }
}