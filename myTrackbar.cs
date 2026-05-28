using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DonkeyCarrot
{
    public partial class myTrackbar : UserControl
    {
        // 내부 변수 설정 (기본값 설정)
        private int _value = 30;
        private int _minimum = 0;
        private int _maximum = 100;

        // 🎨 디자인 색상 설정 (원하는 색으로 언제든 변경 가능!)
        private Color _trackColor = Color.FromArgb(70, 70, 70);      // 비어있는 레일 색상 (짙은 회색)
        private Color _activeColor = Color.FromArgb(30, 215, 96);    // 값이 채워지는 색상 (포인트 녹색)
        private Color _thumbColor = Color.White;                    // 동그란 조절 손잡이 색상 (흰색)

        // 🛠️ 경고(CS8618) 해결: ?를 붙여 nullable로 선언하여 무조건 경고를 지워줍니다.
        public event EventHandler? ValueChanged;

        // 🛠️ 에러(WFO100) 해결: [DesignerSerializationVisibility] 속성을 추가하여 코드 직렬화 기능을 명시합니다.
        [Category("ModernStyle"), Description("슬라이더의 현재 값입니다.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Value
        {
            get => _value;
            set
            {
                // 값이 최소값과 최대값 범위를 벗어나지 않도록 안전장치
                _value = Math.Max(_minimum, Math.Min(_maximum, value));
                Invalidate(); // 값이 바뀌면 화면을 다시 그리도록 명령
                ValueChanged?.Invoke(this, EventArgs.Empty); // 이벤트 발생
            }
        }

        [Category("ModernStyle"), Description("슬라이더의 최소값입니다.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Minimum
        {
            get => _minimum;
            set { _minimum = value; Invalidate(); }
        }

        [Category("ModernStyle"), Description("슬라이더의 최대값입니다.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int Maximum
        {
            get => _maximum;
            set { _maximum = value; Invalidate(); }
        }

        public myTrackbar()
        {
            InitializeComponent();

            // 🚀 중요: WinForms 특유의 화면 깜빡임을 방지하는 더블 버퍼링 설정
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            Size = new Size(250, 30);      // 기본 컨트롤 크기 설정
            BackColor = Color.Transparent; // 배경을 투명하게 해서 Form 디자인 위에 자연스럽게 얹어지도록 설정
        }

        // 🎨 컨트롤을 직접 그리는 부분 (Graphics 구현)
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // 선과 원의 외각선을 부드럽게 깎아주는 그래픽 옵션 (계단현상 방지)
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int trackHeight = 6; // 슬라이더 레일의 세련된 두께
            int trackY = (Height - trackHeight) / 2;
            int thumbSize = 16;  // 조절 손잡이 크기
            int usableWidth = Width - thumbSize;

            // 현재 Value 값에 따른 퍼센트 가중치 계산
            float percent = (float)(_value - _minimum) / (_maximum - _minimum);
            int thumbX = (int)(percent * usableWidth);

            // 1. 배경 레일 그리기 (둥근 사각형 막대)
            Rectangle bgRect = new Rectangle(thumbSize / 2, trackY, usableWidth, trackHeight);
            using (GraphicsPath bgPath = GetRoundRectanglePath(bgRect, trackHeight))
            using (SolidBrush bgBrush = new SolidBrush(_trackColor))
            {
                g.FillPath(bgBrush, bgPath);
            }

            // 2. 가치 채워진 레일 그리기 (손잡이까지 이어지는 하이라이트 바)
            if (thumbX > 0)
            {
                Rectangle activeRect = new Rectangle(thumbSize / 2, trackY, thumbX, trackHeight);
                using (GraphicsPath activePath = GetRoundRectanglePath(activeRect, trackHeight))
                using (SolidBrush activeBrush = new SolidBrush(_activeColor))
                {
                    g.FillPath(activeBrush, activePath);
                }
            }

            // 3. 마우스로 붙잡을 동그란 손잡이(Thumb) 그리기
            int thumbY = (Height - thumbSize) / 2;
            Rectangle thumbRect = new Rectangle(thumbX, thumbY, thumbSize, thumbSize);
            using (SolidBrush thumbBrush = new SolidBrush(_thumbColor))
            {
                g.FillEllipse(thumbBrush, thumbRect);
            }
        }

        // 🖱️ 마우스 클릭 및 드래그 조작 연동 함수들
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            // 마우스 왼쪽 버튼을 누른 채 움직일 때만 작동
            if (e.Button == MouseButtons.Left)
            {
                int thumbSize = 16;
                int usableWidth = Width - thumbSize;

                // 마우스 좌표 기준으로 퍼센트 계산
                float percent = (float)(e.X - thumbSize / 2) / usableWidth;
                percent = Math.Max(0, Math.Min(1, percent)); // 0% ~ 100% 사이로 제한

                // 퍼센트 값을 실제 데이터 수치로 환산하여 대입
                Value = _minimum + (int)(percent * (_maximum - _minimum));
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            // 클릭하는 순간에도 바로 그 자리에 조절바가 툭 찍혀 이동할 수 있도록 연동
            OnMouseMove(e);
        }

        // 📐 모서리가 부드럽게 깎인 둥근 사각형 경로를 만드는 헬퍼 함수
        private GraphicsPath GetRoundRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}