using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Project13InsuranceManagement
{
    public class GradientButton : Button
    {
        public Color C1 { get; set; } = Color.Blue;
        public Color C2 { get; set; } = Color.Red;
        public bool IsMouseDown { get; private set; }
        private int Angle { get; set; }
        private int Step { get; set; } = 1;
        private static Timer slowTimer = new Timer();

        public GradientButton()
        {
            slowTimer.Interval = 20;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;
            g.DrawLine(new Pen(Color.Red), 0, 0, 150, 150);
            LinearGradientBrush brush;
            if (!IsMouseDown)
            {
                brush = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), C1, C2, Angle);
            }
            else
            {
                brush = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), ControlPaint.Dark(C1, 0.3f), ControlPaint.Dark(C2, 0.3f), Angle);
            }
            g.FillRectangle(brush, 0, 0, Width, Height);
            SizeF textSize = g.MeasureString(Text, Font);
            float x = (Width - textSize.Width) / 2f;
            float y = (Height - textSize.Height) / 2f;
            g.DrawString(Text, Font, new SolidBrush(ForeColor), x, y);
            Console.WriteLine(Width);
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            slowTimer.Start();
            slowTimer.Tick += Rotate;
        }

        public void Rotate(object sender, EventArgs e)
        {
            Angle += Step;
            Angle = Angle % 360;
            Invalidate();
        }

        public void RotateBack(object sender, EventArgs e)
        {
            if (Angle <= 0)
            {
                Angle = 0;
                slowTimer.Tick -= RotateBack;
                slowTimer.Stop();
            }
            else
            {
                Angle -= Step * 20;
            }
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            slowTimer.Tick -= Rotate;
            slowTimer.Tick += RotateBack;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            IsMouseDown = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            IsMouseDown = false;
            Invalidate();
        }
    }
}