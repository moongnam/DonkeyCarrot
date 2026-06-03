using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DonkeyCarrot
{
    public partial class myTrackbar : UserControl
    {
        private int _value = 30;
        private int _minimum = 0;
        private int _maximum = 100;

        private Color _trackColor = Color.FromArgb(70, 70, 70);
        private Color _activeColor = Color.FromArgb(30, 215, 96);
        private Color _thumbColor = Color.White;

        public event EventHandler? ValueChanged;

        [Category("ModernStyle")]
        [Description("슬라이더의 현재 값입니다.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Value
        {
            get => _value;
            set
            {
                int newValue = Math.Max(_minimum, Math.Min(_maximum, value));

                if (_value == newValue)
                    return;

                _value = newValue;
                Invalidate();
                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        [Category("ModernStyle")]
        [Description("슬라이더의 최소값입니다.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Minimum
        {
            get => _minimum;
            set
            {
                _minimum = value;

                if (_maximum < _minimum)
                    _maximum = _minimum;

                Value = Math.Max(_minimum, Math.Min(_maximum, _value));
                Invalidate();
            }
        }

        [Category("ModernStyle")]
        [Description("슬라이더의 최대값입니다.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Maximum
        {
            get => _maximum;
            set
            {
                _maximum = value;

                if (_minimum > _maximum)
                    _minimum = _maximum;

                Value = Math.Max(_minimum, Math.Min(_maximum, _value));
                Invalidate();
            }
        }

        public myTrackbar()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);

            Size = new Size(250, 30);

            // Designer 오류 방지 때문에 Transparent 사용 안 함
            BackColor = SystemColors.Control;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int trackHeight = 6;
            int trackY = (Height - trackHeight) / 2;
            int thumbSize = 16;
            int usableWidth = Math.Max(1, Width - thumbSize);

            float percent = 0;

            if (_maximum != _minimum)
            {
                percent = (float)(_value - _minimum) / (_maximum - _minimum);
            }

            percent = Math.Max(0, Math.Min(1, percent));

            int thumbX = (int)(percent * usableWidth);

            Rectangle bgRect = new Rectangle(thumbSize / 2, trackY, usableWidth, trackHeight);

            using (GraphicsPath bgPath = GetRoundRectanglePath(bgRect, trackHeight))
            using (SolidBrush bgBrush = new SolidBrush(_trackColor))
            {
                g.FillPath(bgBrush, bgPath);
            }

            if (thumbX > 0)
            {
                Rectangle activeRect = new Rectangle(thumbSize / 2, trackY, thumbX, trackHeight);

                using (GraphicsPath activePath = GetRoundRectanglePath(activeRect, trackHeight))
                using (SolidBrush activeBrush = new SolidBrush(_activeColor))
                {
                    g.FillPath(activeBrush, activePath);
                }
            }

            int thumbY = (Height - thumbSize) / 2;
            Rectangle thumbRect = new Rectangle(thumbX, thumbY, thumbSize, thumbSize);

            using (SolidBrush thumbBrush = new SolidBrush(_thumbColor))
            {
                g.FillEllipse(thumbBrush, thumbRect);
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                SetValueFromMouse(e.X);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            SetValueFromMouse(e.X);
        }

        private void SetValueFromMouse(int mouseX)
        {
            int thumbSize = 16;
            int usableWidth = Math.Max(1, Width - thumbSize);

            float percent = (float)(mouseX - thumbSize / 2) / usableWidth;
            percent = Math.Max(0, Math.Min(1, percent));

            Value = _minimum + (int)(percent * (_maximum - _minimum));
        }

        private GraphicsPath GetRoundRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            if (rect.Width <= 0 || rect.Height <= 0)
                return path;

            int diameter = Math.Min(radius, Math.Min(rect.Width, rect.Height));

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}