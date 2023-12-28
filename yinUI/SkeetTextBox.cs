using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkeetFramework
{
    [DefaultEvent("TextChanged")]
    public class yinTextBox : Control
    {
        private int W;
        private int H;
        private System.Windows.Forms.TextBox TB;

        private HorizontalAlignment _TextAlign = HorizontalAlignment.Left;
        [Category("Options")]
        public HorizontalAlignment TextAlign
        {
            get { return _TextAlign; }
            set
            {
                _TextAlign = value;
                if (TB != null)
                {
                    TB.TextAlign = value;
                }
            }
        }

        private int _MaxLength = 32767;
        [Category("Options")]
        public int MaxLength
        {
            get { return _MaxLength; }
            set
            {
                _MaxLength = value;
                if (TB != null)
                {
                    TB.MaxLength = value;
                }
            }
        }

        private bool _ReadOnly;
        [Category("Options")]
        public bool ReadOnly
        {
            get { return _ReadOnly; }
            set
            {
                _ReadOnly = value;
                if (TB != null)
                {
                    TB.ReadOnly = value;
                }
            }
        }

        private bool _UseSystemPasswordChar;
        [Category("Options")]
        public bool UseSystemPasswordChar
        {
            get { return _UseSystemPasswordChar; }
            set
            {
                _UseSystemPasswordChar = value;
                if (TB != null)
                {
                    TB.UseSystemPasswordChar = value;
                }
            }
        }

        private bool _Multiline;
        [Category("Options")]
        public bool Multiline
        {
            get { return _Multiline; }
            set
            {
                _Multiline = value;
                if (TB != null)
                {
                    TB.Multiline = value;

                    if (value)
                    {
                        TB.Height = Height - 11;
                    }
                    else
                    {
                        Height = TB.Height + 11;
                    }

                }
            }
        }

        private bool _FocusOnHover = false;
        [Category("Options")]
        public bool FocusOnHover
        {
            get { return _FocusOnHover; }
            set { _FocusOnHover = value; }
        }

        [Category("Options")]
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                if (TB != null)
                {
                    TB.Text = value;
                }
            }
        }

        [Category("Options")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                if (TB != null)
                {
                    TB.Font = value;
                    TB.Location = new Point(3, 5);
                    TB.Width = Width - 6;

                    if (!_Multiline)
                    {
                        Height = TB.Height + 11;
                    }
                }
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (!Controls.Contains(TB))
            {
                Controls.Add(TB);
            }
        }

        private void OnBaseTextChanged(object s, EventArgs e)
        {
            Text = TB.Text;
        }

        private void OnBaseKeyDown(object s, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                TB.SelectAll();
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                TB.Copy();
                e.SuppressKeyPress = true;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            TB.Location = new Point(5, 5);
            TB.Width = Width - 10;

            if (_Multiline)
            {
                TB.Height = Height - 11;
            }
            else
            {
                Height = TB.Height + 11;
            }

            base.OnResize(e);
        }

        [Category("Colors")]
        public Color TextColor
        {
            get { return _TextColor; }
            set { _TextColor = value; }
        }

        public override Color ForeColor
        {
            get { return _TextColor; }
            set { _TextColor = value; }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            TB.Focus();
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (FocusOnHover) TB.Focus();
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Invalidate();
        }

        private Color _BaseColor = Color.FromArgb(25,25,25);
        private Color _TextColor = Color.FromArgb(192, 192, 192);
        private Color _BorderColor = Color.FromArgb(21, 21, 21);

        public yinTextBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;

            BackColor = Color.Transparent;

            TB = new System.Windows.Forms.TextBox();
            TB.Font = new Font("Verdana", 7);
            TB.Text = Text;
            TB.BackColor = _BaseColor;
            TB.ForeColor = _TextColor;
            TB.MaxLength = _MaxLength;
            TB.Multiline = _Multiline;
            TB.ReadOnly = _ReadOnly;
            TB.UseSystemPasswordChar = _UseSystemPasswordChar;
            TB.BorderStyle = BorderStyle.None;
            TB.Location = new Point(5, 5);
            TB.Width = Width - 10;

            TB.Cursor = Cursors.IBeam;
            
             if (_Multiline)
            {
                TB.Height = Height - 11;
            }
            else
            {
                Height = TB.Height + 11;
            }

            TB.TextChanged += OnBaseTextChanged;
            TB.KeyDown += OnBaseKeyDown;

        }
        public Color ColorTop { get; set; } = Color.FromArgb(23, 23, 23);
        public Color ColorBottom { get; set; } = Color.FromArgb(25, 25, 25);
        private StringFormat strFormat = new StringFormat();
        public Pen FakeWhite { get; set; } = new Pen(Color.FromArgb(50, 50, 50));
        protected override void OnPaint(PaintEventArgs e)
        {

            Rectangle ree = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle ree2 = new Rectangle(1, 1, Width - 3, Height - 3);
            LinearGradientBrush gradient = new LinearGradientBrush(ree, this.ColorBottom, this.ColorTop, 90.0f);
            e.Graphics.FillRectangle(gradient, ree);
            e.Graphics.DrawRectangle(Pens.Black, ree);
            e.Graphics.DrawRectangle(FakeWhite, ree2);

          
        

            base.OnPaint(e);
        }
    }
}
