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
    public class yinComboBox : ComboBox
    {
        private int W;
        private int H;
        private int _StartIndex = 0;
        private int x;
        private int y;

        
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            Invalidate();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            x = e.Location.X;
            y = e.Location.Y;
            Invalidate();
            if (e.X < Width - 41)
                Cursor = Cursors.IBeam;
            else
                Cursor = Cursors.Hand;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            Invalidate();
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                Invalidate();
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Invalidate();
        }

   


        private int StartIndex
        {
            get { return _StartIndex; }
            set
            {
                _StartIndex = value;
                try
                {
                    base.SelectedIndex = value;
                }
                catch
                {
                }
                Invalidate();
            }
        }

        public void DrawItem_(System.Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            e.DrawBackground();
            e.DrawFocusRectangle();

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
           
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                //-- Selected item
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(25,25,25)), e.Bounds);
            }
            else
            {
                //-- Not Selected
                e.Graphics.FillRectangle(new SolidBrush(_BaseColor), e.Bounds);
            }

            //-- Text
            e.Graphics.DrawString(base.GetItemText(base.Items[e.Index]), new Font("Segoe UI", 8), Brushes.White, new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height));


            e.Graphics.Dispose();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Height = 18;
        }

        private Color _BaseColor = Color.FromArgb(25, 27, 29);
        private Color _BGColor = Color.FromArgb(45, 47, 49);
        //private Color _HoverColor = Color.FromArgb(35, 168, 109);

        public yinComboBox()
        {
            DrawItem += DrawItem_;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;

            DrawMode = DrawMode.OwnerDrawFixed;
            BackColor = Color.FromArgb(45, 45, 48);
            ForeColor = Color.White;
            DropDownStyle = ComboBoxStyle.DropDownList;
            Cursor = Cursors.Hand;
            StartIndex = 0;
            ItemHeight = 18;
            Font = new Font("Segoe UI", 8, FontStyle.Regular);
        }

        public Color ColorTop { get; set; } = Color.FromArgb(23, 23, 23);
        public Color ColorBottom { get; set; } = Color.FromArgb(25, 25, 25);
        private bool active = false;
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

        
            e.Graphics.DrawString(Text, Font,  Brushes.White , new Point(4, 6));
            e.Graphics.DrawString("v", new Font("Verdana", 7), Brushes.White, new Point(Width - 15 , 6));

        }
    }
}
