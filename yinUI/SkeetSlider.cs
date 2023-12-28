using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkeetFramework
{
    public partial class yinSlider : UserControl
    {
        private bool skeetShowTitle = true;
        private bool invertTitleColor = false;
        private string skeetTitle = "Slider";
        private bool skeetShowValue = true;
        private string skeetValueSuffix = "";
        private string skeetValuePrefix = "";
     
        public bool InvertTitleColor
        {
            get { return invertTitleColor; }
            set
            {
                invertTitleColor = value;
                Color shadow = Color.Black;
                Color text = Color.FromArgb(190, 190, 190);
                if (value == true)
                {
                    lbTitle.ForeColor = shadow;
                    lbTitle.ShadowColor = text;
                }
                else
                {
                    lbTitle.ForeColor = text;
                    lbTitle.ShadowColor = shadow;
                }
            }
        }
        
        public bool ShowTitle { get { return skeetShowTitle; } set { skeetShowTitle = value; lbTitle.Visible = value; } }
        public string Title
        {
            get { return skeetTitle; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    skeetTitle = value;
                lbTitle.Text = skeetTitle;
            }
        }
       
        public bool ShowValue { get { return skeetShowValue; } set { skeetShowValue = value; lbSliderValue.Visible = value; } }
        public string ValueSuffix
        {
            get { return skeetValueSuffix; }
            set
            {
                skeetValueSuffix = value;
                updateValue();
            }
        }
        
        public string ValuePrefix
        {
            get { return skeetValuePrefix; }
            set
            {
                skeetValuePrefix = value;
                updateValue();
            }
        }

        private Color sliderColor = Color.FromArgb(154, 197, 39);
        private Color sliderBack = Color.FromArgb(52, 52, 52);
        private double skeetMax = 2.0;
        private double skeetMin = 1.0;
        private double skeetValue = 1.5;
        private int skeetFormatLen = 2;
        public Color SliderColor { get { return sliderColor; } set { sliderColor = value; updateColor(); } }
        public Color SliderBackgroundColor { get { return sliderBack; } set { sliderBack = value; updateColor(); } }
        public int FormatDecimal { get { return skeetFormatLen; } set { if (value >= 0) skeetFormatLen = value; updateValue(); } }
        public double Value
        {
            get { return skeetValue; }
            set
            {
                double temp = value;

                if (temp >= skeetMin && skeetMax >= temp)
                {
                    skeetValue = value;
                    updateValue();
                }
                else
                {
                    MessageBox.Show("Value can't be lower than minimum or higher than maximum.");
                }
            }
        }
     
        public double MaxValue
        {
            get { return skeetMax; }
            set
            {
                double temp = value;

                if (temp >= skeetMin)
                {
                    if (temp >= skeetValue)
                    {
                        skeetMax = value;

                        if (!DesignMode)
                        {
                            skeetValue = value; //temp, else skeetmin bugs out -- skeetvalue is only declared after
                        }

                        updateValue();
                    }
                    else
                    {
                        MessageBox.Show("Current value can't be higher than maximum value (" + skeetValue + ">" + temp + ")");
                    }
                }
                else
                {
                    MessageBox.Show("Max value can't be lower than minimum value (" + temp + ">" + skeetMin + ")");
                }
            }
        }
      
        public double MinValue
        {
            get { return skeetMin; }
            set
            {
                double temp = value;

                if (temp <= skeetMax)
                {
                    if (skeetValue >= temp)
                    {
                        skeetMin = value;
                        updateValue();
                    }
                    else
                    {
                        MessageBox.Show("Current value can't be lower than minimum value (" + temp + ">" + skeetValue + ")");
                    }
                }
                else
                {
                    MessageBox.Show("Minimum value can't be higher than maximum value (" + temp + ">" + skeetMax + ")");
                }
            }
        }


        #region visuals - sliders/values/control
        Bitmap sliderback = new Bitmap(1, 6);
        Bitmap slidercolor = new Bitmap(1, 6);

        public static Color changeColorBrightness(Color color, float correctionFactor)
        {
            float red = (float)color.R;
            float green = (float)color.G;
            float blue = (float)color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }

        private void updateColor()
        {
            sliderback.SetPixel(0, 0, sliderBack);
            slidercolor.SetPixel(0, 0, sliderColor);
            int y = 1;
            for (float i = 0.02f; 0.10f >= i; i += 0.02f, y++)
            {
                sliderback.SetPixel(0, y, changeColorBrightness(sliderBack, i));
                slidercolor.SetPixel(0, y, changeColorBrightness(sliderColor, -i * 2));
            }
            updateSlider();
        }

        int offset = 0;
        private void updateValue()
        {
            offset = 0;
            string text1 = skeetValuePrefix + string.Format("{0:F" + skeetFormatLen + "}", skeetMax) + skeetValueSuffix;
            Font verdanaBold = new Font("Verdana", 7.2F, FontStyle.Bold);
            Size textSize = TextRenderer.MeasureText(text1, verdanaBold);

            if (textSize.Width / 2 > 15)
            {
                int temp = textSize.Width / 2;
                pnlSliderBox.Location = new Point(temp, pnlSliderBox.Location.Y);
                lbTitle.Location = new Point(temp + 1, lbTitle.Location.Y);
                offset = temp;
            }
            else
            {
                offset = 15;
                pnlSliderBox.Location = new Point(15, 0);
                lbTitle.Location = new Point(15, 1);
            }

            lbSliderValue.Text = skeetValuePrefix + string.Format("{0:F" + skeetFormatLen + "}", skeetValue) + skeetValueSuffix;
            pnlSliderBox.Width = Width - offset * 2;
            updateSlider();
        }

        public yinSlider()
        {
            InitializeComponent();
            SetDoubleBuffered(pnlSlider);
            updateColor();
            updateValue();
            MinimumSize = new Size(100, 40);
        }

        void updateSlider()
        {
            double diferenca = skeetMax - skeetMin;
            double coisinha = diferenca / (pnlSliderBox.Width - 2);
            double cords = (skeetValue - skeetMin) / coisinha;

            pnlSlider.BackgroundImage = drawSlider(pnlSliderBox, Convert.ToInt32(cords));
            lbSliderValue.Location = new Point(Convert.ToInt32(cords) + offsetValueSwitch(lbSliderValue.Text.Length), lbSliderValue.Location.Y);
        }

        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo aProp =
                  typeof(System.Windows.Forms.Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            aProp.SetValue(c, true, null);
        }

        private int offsetValueSwitch(int i)
        {
            switch (i)
            {
                case 1:
                    return 9;
                case 2:
                    return 5;
                case 3:
                    return 3;
                default:
                    return 1;
            }
        }

        private Bitmap drawSlider(Control panel, int x)
        {
            Bitmap background = new Bitmap(panel.Width + offset, panel.Height);
            if (x >= 0 && 3 >= x || -1 >= x)
            {
                x = 3;
            }

            if (x >= background.Width)
            {
                x = background.Width;
            }

            using (Graphics g = Graphics.FromImage(background))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;

                g.DrawImage(sliderback, 1 + offset, 1, (background.Width - offset) * 2 - 4, background.Height - 2);
                int lol = 6;
                if (x >= background.Width / 2) { lol = 2; }
                g.DrawImage(slidercolor, 1 + offset, 1, x * 2 - lol, background.Height - 2);
                using (Brush brush = new SolidBrush(Color.FromArgb(0, 0, 0)))
                {
                    Pen cpen = new Pen(brush);
                    g.DrawRectangle(cpen, offset, 0, background.Width - offset - 1, background.Height - 1);
                }
            }

            return background;
        }
        #endregion

        #region visuals - misc
        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            if (this.DesignMode)
                base.SetBoundsCore(x, y, width, 40, specified);
            else
                base.SetBoundsCore(x, y, width, height, specified);
        }
        #endregion

        private void yinSlider_Load(object sender, EventArgs e)
        {
            //nada
        }

        private void pnlClick()
        {
            Point cords = pnlSliderBox.PointToClient(Cursor.Position);
            pnlSlider.BackgroundImage = drawSlider(pnlSliderBox, cords.X);

            lbSliderValue.Location = new Point(cords.X + offsetValueSwitch(lbSliderValue.Text.Length), lbSliderValue.Location.Y);

            double max = skeetMax;
            double min = skeetMin;
            double add = (max - min) / (pnlSliderBox.Width - 2);

            int loc = cords.X;
            if (loc >= pnlSliderBox.Width - 2) { loc = pnlSliderBox.Width - 2; }
            if (loc >= 0)
            {
                double value = min + (loc * add);
                skeetValue = value;
                lbSliderValue.Text = skeetValuePrefix + string.Format("{0:F" + skeetFormatLen + "}", skeetValue) + skeetValueSuffix;
            }
        }

        private void yinSlider_Resize(object sender, EventArgs e)
        {
            pnlSliderBox.Width = Width - offset * 2;
            pnlSlider.Width = Width;
            updateSlider();
        }

        private void pnlSliderBox_Click(object sender, EventArgs e)
        {
            if (pnlSliderBox.ClientRectangle.Contains(pnlSliderBox.PointToClient(Control.MousePosition)))
            {
                pnlClick();
            }
        }

        private void pnlSliderBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (pnlSliderBox.ClientRectangle.Contains(pnlSliderBox.PointToClient(Control.MousePosition)))
                {

                    pnlClick();
                }
            }
        }

        private void InitializeComponent()
        {
            this.pnlSlider = new System.Windows.Forms.Panel();
            this.lbTitle = new shadowLabel();
            this.pnlSliderBox = new transparentPanel();
            this.lbSliderValue = new outlineLabel();
            this.pnlSlider.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSlider
            // 
            this.pnlSlider.BackColor = System.Drawing.Color.Transparent;
            this.pnlSlider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlSlider.Controls.Add(this.pnlSliderBox);
            this.pnlSlider.Controls.Add(this.lbSliderValue);
            this.pnlSlider.Location = new System.Drawing.Point(0, 17);
            this.pnlSlider.Name = "pnlSlider";
            this.pnlSlider.Size = new System.Drawing.Size(158, 23);
            this.pnlSlider.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.EnableShadow = true;
            this.lbTitle.Font = new System.Drawing.Font("Tahoma", 7.23F);
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbTitle.Location = new System.Drawing.Point(15, 2);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.ShadowColor = System.Drawing.Color.Black;
            this.lbTitle.ShadowOffset = 1;
            this.lbTitle.Size = new System.Drawing.Size(53, 12);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Slider";
            // 
            // pnlSliderBox
            // 
            this.pnlSliderBox.BackColor = System.Drawing.Color.Fuchsia;
            this.pnlSliderBox.Location = new System.Drawing.Point(14, 0);
            this.pnlSliderBox.Name = "pnlSliderBox";
            this.pnlSliderBox.Size = new System.Drawing.Size(128, 8);
            this.pnlSliderBox.TabIndex = 6;
            this.pnlSliderBox.Click += new System.EventHandler(this.pnlSliderBox_Click);
            this.pnlSliderBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlSliderBox_MouseMove);
            // 
            // lbSliderValue
            // 
            this.lbSliderValue.AutoSize = true;
            this.lbSliderValue.Font = new System.Drawing.Font("Verdana", 7.2F, System.Drawing.FontStyle.Bold);
            this.lbSliderValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.lbSliderValue.Location = new System.Drawing.Point(65, 0);
            this.lbSliderValue.Name = "lbSliderValue";
            this.lbSliderValue.OutlineForeColor = System.Drawing.Color.Black;
            this.lbSliderValue.OutlineWidth = 1.5F;
            this.lbSliderValue.Size = new System.Drawing.Size(37, 12);
            this.lbSliderValue.TabIndex = 5;
            this.lbSliderValue.Text = "1.523";
            this.lbSliderValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yinSlider
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.pnlSlider);
            this.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Bold);
            this.Name = "yinSlider";
            this.Size = new System.Drawing.Size(158, 40);
            this.Resize += new System.EventHandler(this.yinSlider_Resize);
            this.pnlSlider.ResumeLayout(false);
            this.pnlSlider.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSlider;
        private outlineLabel lbSliderValue;
        private transparentPanel pnlSliderBox;
        private shadowLabel lbTitle;
        private void Slider_Load(object sender, EventArgs e)
        {

        }
    }
     class outlineLabel : Label
    {
        //sources:    
        //https://stackoverflow.com/questions/19842722/setting-a-font-with-outline-color-in-c-sharp - label outline
        public outlineLabel()
        {
            OutlineForeColor = Color.Green;
            OutlineWidth = 1.5f;
        }
        public Color OutlineForeColor { get; set; }
        public float OutlineWidth { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(BackColor), ClientRectangle);
            using (GraphicsPath gp = new GraphicsPath())
            using (Pen outline = new Pen(OutlineForeColor, OutlineWidth)
            { LineJoin = LineJoin.Round })
            using (StringFormat sf = new StringFormat())
            using (Brush foreBrush = new SolidBrush(ForeColor))
            {
                gp.AddString(Text, Font.FontFamily, (int)Font.Style,
                    Font.Size, ClientRectangle, sf);
                e.Graphics.ScaleTransform(1.3f, 1.35f);
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.DrawPath(outline, gp);
                e.Graphics.FillPath(foreBrush, gp);
            }
        }
    }
     class transparentPanel : Panel
    {
        //sources:
        //somewhere on stackoverflow
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //base.OnPaintBackground(e);
        }
    }

     class shadowLabel : Label
    {
        //sources:
        //https://gist.github.com/mjs3339/1dceee0c4d395eaaf01cc06107a8aaf9 - custom label

        public enum Angles
        {        
            LeftToRight = 0,         
            TopToBottom = 90,           
            RightToLeft = 180,        
            BottomToTop = 270
        }

        private Angles _angle = Angles.LeftToRight;

        private bool _enableShadow;
        private Color _shadowColor = Color.LightGray;
        private int _shadowOffset = 1;

        public shadowLabel()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.OptimizedDoubleBuffer, true);
        }
        public Color ShadowColor
        {
            get => _shadowColor;
            set
            {
                _shadowColor = value;
                Invalidate();
            }
        }
    
        public int ShadowOffset
        {
            get => _shadowOffset;
            set
            {
                _shadowOffset = value;
                Invalidate();
            }
        }
      
        public bool EnableShadow
        {
            get => _enableShadow;
            set
            {
                _enableShadow = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (_enableShadow)
            {
                var rc0 = new Rectangle(_shadowOffset, _shadowOffset, Width, Height);
                var b0 = new SolidBrush(Color.FromArgb(255, _shadowColor));
                e.Graphics.DrawString(Text, Font, b0, rc0, ContentAlignmentToStringAlignment(TextAlign));
            }

            var size = e.Graphics.VisibleClipBounds.Size;
            switch (_angle)
            {
                case Angles.LeftToRight:
                    e.Graphics.TranslateTransform(0, 0);
                    e.Graphics.RotateTransform(0);
                    e.Graphics.DrawString(Text, Font, new SolidBrush(Color.FromArgb(255, ForeColor)), new RectangleF(0, 0, size.Width, size.Height), ContentAlignmentToStringAlignment(TextAlign));
                    e.Graphics.ResetTransform();
                    break;
                case Angles.TopToBottom:
                    e.Graphics.TranslateTransform(size.Width, 0);
                    e.Graphics.RotateTransform(90);
                    e.Graphics.DrawString(Text, Font, new SolidBrush(Color.FromArgb(255, ForeColor)), new RectangleF(0, 0, size.Height, size.Width), ContentAlignmentToStringAlignment(TextAlign));
                    e.Graphics.ResetTransform();
                    break;
                case Angles.RightToLeft:
                    e.Graphics.TranslateTransform(size.Width, size.Height);
                    e.Graphics.RotateTransform(180);
                    e.Graphics.DrawString(Text, Font, new SolidBrush(Color.FromArgb(255, ForeColor)), new RectangleF(0, 0, size.Width, size.Height), ContentAlignmentToStringAlignment(TextAlign));
                    e.Graphics.ResetTransform();
                    break;
                case Angles.BottomToTop:
                    e.Graphics.TranslateTransform(0, size.Height);
                    e.Graphics.RotateTransform(270);
                    e.Graphics.DrawString(Text, Font, new SolidBrush(Color.FromArgb(255, ForeColor)), new RectangleF(0, 0, size.Height, size.Width), ContentAlignmentToStringAlignment(TextAlign));
                    e.Graphics.ResetTransform();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        private static StringFormat ContentAlignmentToStringAlignment(ContentAlignment ca)
        {
            var format = new StringFormat();
            var l2 = (int)Math.Log((double)ca, 2);
            format.LineAlignment = (StringAlignment)(l2 / 4);
            format.Alignment = (StringAlignment)(l2 % 4);
            return format;
        }
    }
}
