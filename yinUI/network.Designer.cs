using SkeetFramework;

namespace yinUI
{
    partial class network
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(network));
            yinBackground1 = new yinBackground();
            shadowLabel2 = new shadowLabel();
            yinGroupBox4 = new yinGroupBox();
            yinButton7 = new yinButton();
            richTextBox4 = new RichTextBox();
            yinTextBox4 = new yinTextBox();
            yinGroupBox3 = new yinGroupBox();
            richTextBox3 = new RichTextBox();
            yinButton6 = new yinButton();
            yinTextBox3 = new yinTextBox();
            yinGroupBox2 = new yinGroupBox();
            richTextBox2 = new RichTextBox();
            yinTextBox2 = new yinTextBox();
            yinButton5 = new yinButton();
            yinGroupBox1 = new yinGroupBox();
            yinButton4 = new yinButton();
            richTextBox1 = new RichTextBox();
            yinButton3 = new yinButton();
            yinTextBox1 = new yinTextBox();
            yinButton2 = new yinButton();
            shadowLabel1 = new shadowLabel();
            yinButton1 = new yinButton();
            yinBackground1.SuspendLayout();
            yinGroupBox4.SuspendLayout();
            yinGroupBox3.SuspendLayout();
            yinGroupBox2.SuspendLayout();
            yinGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // yinBackground1
            // 
            yinBackground1.BackColor = Color.FromArgb(23, 23, 23);
            yinBackground1.Controls.Add(shadowLabel2);
            yinBackground1.Controls.Add(yinGroupBox4);
            yinBackground1.Controls.Add(yinGroupBox3);
            yinBackground1.Controls.Add(yinGroupBox2);
            yinBackground1.Controls.Add(yinGroupBox1);
            yinBackground1.Controls.Add(yinButton2);
            yinBackground1.Controls.Add(shadowLabel1);
            yinBackground1.Controls.Add(yinButton1);
            yinBackground1.Cursor = Cursors.Hand;
            yinBackground1.Dock = DockStyle.Fill;
            yinBackground1.Location = new Point(0, 0);
            yinBackground1.Name = "yinBackground1";
            yinBackground1.Size = new Size(800, 450);
            yinBackground1.TabIndex = 0;
            yinBackground1.Text = "yinBackground1";
            // 
            // shadowLabel2
            // 
            shadowLabel2.BackColor = Color.Transparent;
            shadowLabel2.EnableShadow = false;
            shadowLabel2.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            shadowLabel2.ForeColor = SystemColors.ButtonFace;
            shadowLabel2.Location = new Point(569, 427);
            shadowLabel2.Name = "shadowLabel2";
            shadowLabel2.ShadowColor = Color.LightGray;
            shadowLabel2.ShadowOffset = 1;
            shadowLabel2.Size = new Size(228, 15);
            shadowLabel2.TabIndex = 7;
            shadowLabel2.Text = "yin Omega - Public v1.0 (made by detective)";
            // 
            // yinGroupBox4
            // 
            yinGroupBox4.Controls.Add(yinButton7);
            yinGroupBox4.Controls.Add(richTextBox4);
            yinGroupBox4.Controls.Add(yinTextBox4);
            yinGroupBox4.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinGroupBox4.Location = new Point(21, 317);
            yinGroupBox4.Name = "yinGroupBox4";
            yinGroupBox4.Size = new Size(282, 112);
            yinGroupBox4.TabIndex = 8;
            yinGroupBox4.TabStop = false;
            yinGroupBox4.Text = "DNS/MX Lookup";
            yinGroupBox4.Enter += yinGroupBox4_Enter;
            // 
            // yinButton7
            // 
            yinButton7.ColorBottom = Color.FromArgb(25, 25, 25);
            yinButton7.ColorTop = Color.FromArgb(23, 23, 23);
            yinButton7.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinButton7.Location = new Point(182, 18);
            yinButton7.Name = "yinButton7";
            yinButton7.Size = new Size(75, 23);
            yinButton7.TabIndex = 10;
            yinButton7.Text = "lookup";
            yinButton7.Click += yinButton7_Click;
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = Color.FromArgb(23, 23, 23);
            richTextBox4.BorderStyle = BorderStyle.None;
            richTextBox4.ForeColor = SystemColors.Menu;
            richTextBox4.Location = new Point(6, 44);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(217, 62);
            richTextBox4.TabIndex = 9;
            richTextBox4.Text = "";
            richTextBox4.TextChanged += richTextBox4_TextChanged;
            // 
            // yinTextBox4
            // 
            yinTextBox4.BackColor = Color.Transparent;
            yinTextBox4.ColorBottom = Color.FromArgb(25, 25, 25);
            yinTextBox4.ColorTop = Color.FromArgb(23, 23, 23);
            yinTextBox4.FocusOnHover = false;
            yinTextBox4.Location = new Point(29, 18);
            yinTextBox4.MaxLength = 32767;
            yinTextBox4.Multiline = false;
            yinTextBox4.Name = "yinTextBox4";
            yinTextBox4.ReadOnly = false;
            yinTextBox4.Size = new Size(109, 23);
            yinTextBox4.TabIndex = 0;
            yinTextBox4.Text = "domain";
            yinTextBox4.TextAlign = HorizontalAlignment.Left;
            yinTextBox4.TextColor = Color.FromArgb(192, 192, 192);
            yinTextBox4.UseSystemPasswordChar = false;
            yinTextBox4.TextChanged += yinTextBox4_TextChanged;
            // 
            // yinGroupBox3
            // 
            yinGroupBox3.Controls.Add(richTextBox3);
            yinGroupBox3.Controls.Add(yinButton6);
            yinGroupBox3.Controls.Add(yinTextBox3);
            yinGroupBox3.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinGroupBox3.Location = new Point(484, 241);
            yinGroupBox3.Name = "yinGroupBox3";
            yinGroupBox3.Size = new Size(281, 174);
            yinGroupBox3.TabIndex = 7;
            yinGroupBox3.TabStop = false;
            yinGroupBox3.Text = "IP Info";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.FromArgb(23, 23, 23);
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.ForeColor = SystemColors.Menu;
            richTextBox3.Location = new Point(6, 95);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(269, 73);
            richTextBox3.TabIndex = 7;
            richTextBox3.Text = "";
            richTextBox3.TextChanged += richTextBox3_TextChanged;
            // 
            // yinButton6
            // 
            yinButton6.ColorBottom = Color.FromArgb(25, 25, 25);
            yinButton6.ColorTop = Color.FromArgb(23, 23, 23);
            yinButton6.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinButton6.Location = new Point(26, 66);
            yinButton6.Name = "yinButton6";
            yinButton6.Size = new Size(75, 23);
            yinButton6.TabIndex = 1;
            yinButton6.Text = "info";
            yinButton6.Click += yinButton6_Click;
            // 
            // yinTextBox3
            // 
            yinTextBox3.BackColor = Color.Transparent;
            yinTextBox3.ColorBottom = Color.FromArgb(25, 25, 25);
            yinTextBox3.ColorTop = Color.FromArgb(23, 23, 23);
            yinTextBox3.FocusOnHover = false;
            yinTextBox3.Location = new Point(26, 28);
            yinTextBox3.MaxLength = 32767;
            yinTextBox3.Multiline = false;
            yinTextBox3.Name = "yinTextBox3";
            yinTextBox3.ReadOnly = false;
            yinTextBox3.Size = new Size(115, 23);
            yinTextBox3.TabIndex = 0;
            yinTextBox3.Text = "ip";
            yinTextBox3.TextAlign = HorizontalAlignment.Left;
            yinTextBox3.TextColor = Color.FromArgb(192, 192, 192);
            yinTextBox3.UseSystemPasswordChar = false;
            yinTextBox3.TextChanged += yinTextBox3_TextChanged;
            // 
            // yinGroupBox2
            // 
            yinGroupBox2.Controls.Add(richTextBox2);
            yinGroupBox2.Controls.Add(yinTextBox2);
            yinGroupBox2.Controls.Add(yinButton5);
            yinGroupBox2.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinGroupBox2.Location = new Point(484, 73);
            yinGroupBox2.Name = "yinGroupBox2";
            yinGroupBox2.Size = new Size(281, 162);
            yinGroupBox2.TabIndex = 4;
            yinGroupBox2.TabStop = false;
            yinGroupBox2.Text = "Cloudflare Resolver";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.FromArgb(23, 23, 23);
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.ForeColor = SystemColors.Menu;
            richTextBox2.Location = new Point(26, 125);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(151, 22);
            richTextBox2.TabIndex = 6;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // yinTextBox2
            // 
            yinTextBox2.BackColor = Color.Transparent;
            yinTextBox2.ColorBottom = Color.FromArgb(25, 25, 25);
            yinTextBox2.ColorTop = Color.FromArgb(23, 23, 23);
            yinTextBox2.FocusOnHover = false;
            yinTextBox2.Location = new Point(26, 33);
            yinTextBox2.MaxLength = 32767;
            yinTextBox2.Multiline = false;
            yinTextBox2.Name = "yinTextBox2";
            yinTextBox2.ReadOnly = false;
            yinTextBox2.Size = new Size(136, 23);
            yinTextBox2.TabIndex = 5;
            yinTextBox2.Text = "domain";
            yinTextBox2.TextAlign = HorizontalAlignment.Left;
            yinTextBox2.TextColor = Color.FromArgb(192, 192, 192);
            yinTextBox2.UseSystemPasswordChar = false;
            yinTextBox2.TextChanged += yinTextBox2_TextChanged;
            // 
            // yinButton5
            // 
            yinButton5.ColorBottom = Color.FromArgb(25, 25, 25);
            yinButton5.ColorTop = Color.FromArgb(23, 23, 23);
            yinButton5.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinButton5.Location = new Point(26, 75);
            yinButton5.Name = "yinButton5";
            yinButton5.Size = new Size(75, 23);
            yinButton5.TabIndex = 6;
            yinButton5.Text = "resolve";
            yinButton5.Click += yinButton5_Click;
            // 
            // yinGroupBox1
            // 
            yinGroupBox1.Controls.Add(yinButton4);
            yinGroupBox1.Controls.Add(richTextBox1);
            yinGroupBox1.Controls.Add(yinButton3);
            yinGroupBox1.Controls.Add(yinTextBox1);
            yinGroupBox1.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinGroupBox1.Location = new Point(21, 64);
            yinGroupBox1.Name = "yinGroupBox1";
            yinGroupBox1.Size = new Size(282, 247);
            yinGroupBox1.TabIndex = 3;
            yinGroupBox1.TabStop = false;
            yinGroupBox1.Text = "Pinger";
            yinGroupBox1.Enter += yinGroupBox1_Enter;
            // 
            // yinButton4
            // 
            yinButton4.ColorBottom = Color.FromArgb(25, 25, 25);
            yinButton4.ColorTop = Color.FromArgb(23, 23, 23);
            yinButton4.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinButton4.Location = new Point(148, 75);
            yinButton4.Name = "yinButton4";
            yinButton4.Size = new Size(75, 23);
            yinButton4.TabIndex = 0;
            yinButton4.Text = "stop";
            yinButton4.Click += yinButton4_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(23, 23, 23);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = SystemColors.Menu;
            richTextBox1.Location = new Point(6, 125);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(270, 114);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged_1;
            // 
            // yinButton3
            // 
            yinButton3.ColorBottom = Color.FromArgb(25, 25, 25);
            yinButton3.ColorTop = Color.FromArgb(23, 23, 23);
            yinButton3.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinButton3.Location = new Point(29, 75);
            yinButton3.Name = "yinButton3";
            yinButton3.Size = new Size(75, 23);
            yinButton3.TabIndex = 4;
            yinButton3.Text = "ping";
            yinButton3.Click += yinButton3_Click;
            // 
            // yinTextBox1
            // 
            yinTextBox1.BackColor = Color.Transparent;
            yinTextBox1.ColorBottom = Color.FromArgb(25, 25, 25);
            yinTextBox1.ColorTop = Color.FromArgb(23, 23, 23);
            yinTextBox1.FocusOnHover = false;
            yinTextBox1.Location = new Point(29, 33);
            yinTextBox1.MaxLength = 32767;
            yinTextBox1.Multiline = false;
            yinTextBox1.Name = "yinTextBox1";
            yinTextBox1.ReadOnly = false;
            yinTextBox1.Size = new Size(109, 23);
            yinTextBox1.TabIndex = 4;
            yinTextBox1.Text = "ip";
            yinTextBox1.TextAlign = HorizontalAlignment.Left;
            yinTextBox1.TextColor = Color.FromArgb(192, 192, 192);
            yinTextBox1.UseSystemPasswordChar = false;
            yinTextBox1.TextChanged += yinTextBox1_TextChanged;
            // 
            // yinButton2
            // 
            yinButton2.ColorBottom = Color.FromArgb(25, 25, 25);
            yinButton2.ColorTop = Color.FromArgb(23, 23, 23);
            yinButton2.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinButton2.Location = new Point(311, 26);
            yinButton2.Name = "yinButton2";
            yinButton2.Size = new Size(75, 23);
            yinButton2.TabIndex = 2;
            yinButton2.Text = "current IP";
            yinButton2.Click += yinButton2_Click;
            // 
            // shadowLabel1
            // 
            shadowLabel1.AutoSize = true;
            shadowLabel1.EnableShadow = true;
            shadowLabel1.Font = new Font("Verdana", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            shadowLabel1.ForeColor = SystemColors.ControlLight;
            shadowLabel1.Location = new Point(329, 26);
            shadowLabel1.Name = "shadowLabel1";
            shadowLabel1.ShadowColor = Color.Black;
            shadowLabel1.ShadowOffset = 1;
            shadowLabel1.Size = new Size(57, 12);
            shadowLabel1.TabIndex = 1;
            shadowLabel1.Text = "Getting IP";
            shadowLabel1.Click += shadowLabel1_Click;
            // 
            // yinButton1
            // 
            yinButton1.ColorBottom = Color.FromArgb(25, 25, 25);
            yinButton1.ColorTop = Color.FromArgb(23, 23, 23);
            yinButton1.Font = new Font("Verdana", 7F, FontStyle.Regular, GraphicsUnit.Point);
            yinButton1.Location = new Point(21, 26);
            yinButton1.Name = "yinButton1";
            yinButton1.Size = new Size(75, 23);
            yinButton1.TabIndex = 0;
            yinButton1.Text = "back";
            yinButton1.Click += yinButton1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(yinBackground1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "IP & Network";
            yinBackground1.ResumeLayout(false);
            yinBackground1.PerformLayout();
            yinGroupBox4.ResumeLayout(false);
            yinGroupBox3.ResumeLayout(false);
            yinGroupBox2.ResumeLayout(false);
            yinGroupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private yinBackground yinBackground1;
        private yinButton yinButton1;
        private shadowLabel shadowLabel1;
        private yinGroupBox yinGroupBox1;
        private yinTextBox yinTextBox1;
        private yinButton yinButton2;
        private yinButton yinButton3;
        private RichTextBox richTextBox1;
        private yinButton yinButton4;
        private yinGroupBox yinGroupBox2;
        private yinTextBox yinTextBox2;
        private yinButton yinButton5;
        private RichTextBox richTextBox2;
        private yinGroupBox yinGroupBox3;
        private RichTextBox richTextBox3;
        private yinButton yinButton6;
        private yinTextBox yinTextBox3;
        private yinGroupBox yinGroupBox4;
        private RichTextBox richTextBox4;
        private yinTextBox yinTextBox4;
        private yinButton yinButton7;
        private shadowLabel shadowLabel2;
    }
}