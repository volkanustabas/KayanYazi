using System;
using System.Drawing;
using System.Windows.Forms;

namespace KayanYazi
{
    public sealed class KayanYaziLabel : Control
    {
        private readonly Timer _timer = new Timer();
        private int _a;
        private bool _art;
        private bool _slide;

        public KayanYaziLabel()
        {
            SetStyle(
                ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint |
                ControlStyles.SupportsTransparentBackColor | ControlStyles.ResizeRedraw | ControlStyles.UserPaint,
                true);

            AutoSize = false;
            Width = 30;
            Height = 15;
            _a = 0;
            _timer.Tick += timer_Tick;
            _slide = false;
            _timer.Enabled = false;
        }

        public int SlideTime
        {
            get =>
                _timer.Interval;
            set
            {
                _timer.Interval = value;
                Invalidate();
            }
        }

        public bool Slide
        {
            get =>
                _slide;
            set
            {
                _slide = value;
                _slide = true;
                _timer.Enabled = _slide;

                if (!_slide)
                {
                    _a = 0;
                    Invalidate();
                }
            }
        }

        public override string Text
        {
            get => base.Text;
            set
            {
                base.Text = value;
                _timer.Start();
            }
        }

        protected override void Dispose(bool disposing)
        {
            _timer.Stop();
            base.Dispose(disposing);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            Invalidate();
            base.OnBackColorChanged(e);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            Invalidate();
            base.OnForeColorChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Brush brush;
            using (brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
            }

            var size = TextRenderer.MeasureText(Text, Font);
            var num = Height / 2 - size.Height / 2;


            using (brush = new SolidBrush(ForeColor))
            {
                e.Graphics.DrawString(Text, Font, brush, _a, num);
            }

            base.OnPaint(e);
        }

        protected override void OnResize(EventArgs e)
        {
            _timer.Enabled = true;
            base.OnResize(e);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var size = TextRenderer.MeasureText(Text, Font);
            if (size.Width <= Width)
            {
                _timer.Stop();
                _a = 1;
                Invalidate();
            }
            else
            {
                var num = size.Width >= Width ? size.Width - Width : 0;
                if (_a >= 1) _art = false;

                if (-_a >= num + Font.Height) _art = true;

                _a = _art ? _a + 1 : _a - 1;
                Invalidate();
            }
        }
    }
}