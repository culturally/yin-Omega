using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace SkeetFramework
{
    [DefaultEvent("CheckedChanged")]
    public class yinToggle : Control
    {
        private bool _Checked = false;

        public event CheckedChangedEventHandler CheckedChanged;
        public delegate void CheckedChangedEventHandler(object sender);

        public bool Checked
        {
            get { return _Checked; }
            set { _Checked = value; }
        }



        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }


        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            Invalidate();
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Invalidate();
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            Invalidate();
        }
        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Invalidate();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            _Checked = !_Checked;
            if (CheckedChanged != null)
            {
                CheckedChanged(this);
            }
        }

        public Color ColorTop { get; set; } = Color.FromArgb(45, 45, 45);
        public Color ColorBottom { get; set; } = Color.FromArgb(35, 35, 35);
        private StringFormat strFormat = new StringFormat();
        public Pen FakeWhite { get; set; } = new Pen(Color.FromArgb(50, 50, 50));


        public Color ColorTop1 { get; set; } = Color.FromArgb(154, 197, 39);
        public Color ColorBottom1 { get; set; } = Color.FromArgb(124, 161, 27);
        public Pen FakeWhite1 { get; set; } = new Pen(Color.FromArgb(50, 50, 50));
        public yinToggle()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;
            BackColor = Color.Transparent;
            Font = new Font("Verdana", 7);
            
        }
        public bool active = false;
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle red = new Rectangle(2, 2, 8, 8);
          
            Rectangle ree = new Rectangle(1, 1,  9,  9);
            Rectangle ree2 = new Rectangle(1, 1, 9,  9);
            LinearGradientBrush gradient = new LinearGradientBrush(ree, this.ColorBottom, this.ColorTop, 90.0f);
            LinearGradientBrush gradient1 = new LinearGradientBrush(ree, this.ColorBottom1, this.ColorTop1, 90.0f);
            e.Graphics.FillRectangle(gradient, ree);
            //e.Graphics.DrawRectangle(Pens.Black, ree);
            e.Graphics.DrawRectangle(FakeWhite, ree2);
            e.Graphics.DrawString(Text, Font, (active) ? Brushes.White : Brushes.White, 15,-1);
            if (Checked)
            {
                //e//.Graphics.DrawRectangle(Pens.Black, ree);
                e.Graphics.DrawRectangle(FakeWhite, ree2);
                e.Graphics.FillRectangle(gradient1, red);
            }

            base.OnPaint(e);
        }

    }
}

