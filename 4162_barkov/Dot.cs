using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace _4162_barkov
{
    internal class Dot
    {
        public float floatPScaleX = 0.5f;
        public float floatPScaleY = 0.5f;
        public int intPFrequency = 2;

        private float floatPx0;
        private float floatPy0;
        private float floatPPeriod;
        private float floatPAmplitude;
        private float floatPDotAngle = 0;

        // running dot
        private PointF pointFPpointPosition;

        public void Draw(PictureBox pbox, Graphics g)
        {
            Pen pen = new Pen(Brushes.Red, 3f);
            int d = 5;
            int r = d / 2;

            floatPx0 = (pbox.Width + pbox.Width * floatPScaleX) / 2;
            floatPy0 = pbox.Height / 2;

            // width of sine by x with public multiplier (period)
            floatPPeriod = pbox.Width * floatPScaleX;

            // height of sine by y with public multiplier (amplitude)
            floatPAmplitude = (pbox.Height / 2) * floatPScaleY;

            pointFPpointPosition = getXY();

            g.DrawEllipse(pen, pointFPpointPosition.X - r, pointFPpointPosition.Y - r, d, d);
        }

        public void RunDot()
        {
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Elapsed += (_, __) =>
            {
                floatPDotAngle += 0.01f;

                pointFPpointPosition = getXY();
            };
            timer.Start();
        }

        private PointF getXY()
        {
            float x = floatPx0 - ((floatPPeriod * floatPDotAngle) / (float)(intPFrequency * Math.PI));
            float y = floatPy0 - floatPAmplitude * (float)Math.Sin(floatPDotAngle);

            return new PointF(x, y);
        }
    }
}
