using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SkeetFramework
{
    public class yinGroupBox : GroupBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            DrawGroupBox(this, e.Graphics, Color.White, Color.FromArgb(44, 42, 46), Color.Black);
        }

        private void DrawGroupBox(yinGroupBox box, Graphics g, Color textColor, Color borderColor, Color borderColor2)
        {
            if (box != null)
            {
                this.Font = new Font("Verdana", 7);
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Brush borderBrush2 = new SolidBrush(borderColor2);
                Pen borderPen = new Pen(borderBrush);
                Pen borderPen2 = new Pen(borderBrush2);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X, box.ClientRectangle.Y + (int)(strSize.Height / 2), box.ClientRectangle.Width - 1, box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);
                g.DrawLine(borderPen, new Point(rect.Location.X + 1, rect.Location.Y), new Point(rect.X + 1, rect.Y + rect.Height));
                g.DrawLine(borderPen, new Point(rect.X + rect.Width - 1, rect.Y), new Point(rect.X + rect.Width - 1, rect.Y + rect.Height));
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height - 1), new Point(rect.X + rect.Width, rect.Y + rect.Height - 1));
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));

                g.DrawLine(borderPen2, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                g.DrawLine(borderPen2, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                g.DrawLine(borderPen2, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                g.DrawLine(borderPen2, new Point(rect.X, rect.Y - 1), new Point(rect.X + box.Padding.Left, rect.Y - 1));
                g.DrawLine(borderPen2, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y - 1), new Point(rect.X + rect.Width, rect.Y - 1));
            }
        }
    }
}
