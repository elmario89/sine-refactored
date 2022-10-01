using System;
using System.Collections.Generic;
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

        public List<PointF> _points = new List<PointF>();

        private float floatPx0;
        private float floatPy0;
        private float floatPPeriod;
        private float floatPAmplitude;
        private float floatPDotAngle = 0;

        // running dot
        private PointF pointFPpointPosition;
        private Timer tmrPTimer;

        public void Draw(List<PointF> points, Graphics g)
        {
            //points.Clear();

            int i = 0;
            tmrPTimer = new Timer();
            tmrPTimer.Interval = 100;
            tmrPTimer.Elapsed += (_, __) =>
            {
                //floatPDotAngle += 0.01f;
                PointF currentPoint = points.ToArray()[i];

                pointFPpointPosition = currentPoint;

                if (i >= points.ToArray().Length - 1)
                {
                    tmrPTimer.Stop();
                    i = 0;
                    tmrPTimer.Start();
                    return;
                }
                i++;
            };

            Pen pen = new Pen(Brushes.Red, 3f);
            int d = 5;
            int r = d / 2;
            g.DrawEllipse(pen, pointFPpointPosition.X - r, pointFPpointPosition.Y - r, d, d);
            //Pen pen = new Pen(Brushes.Red, 3f);
            //int d = 5;
            //int r = d / 2;

            //floatPx0 = (pbox.Width + pbox.Width * floatPScaleX) / 2;
            //floatPy0 = pbox.Height / 2;

            //// width of sine by x with public multiplier (period)
            //floatPPeriod = pbox.Width * floatPScaleX;

            //// height of sine by y with public multiplier (amplitude)
            //floatPAmplitude = (pbox.Height / 2) * floatPScaleY;

            //pointFPpointPosition = getXY();

            //g.DrawEllipse(pen, pointFPpointPosition.X - r, pointFPpointPosition.Y - r, d, d);
        }

        public void RunDot()
        {
            tmrPTimer.Start();
        }

        public void StopDot()
        {
            tmrPTimer.Stop();
        }

        //private PointF getXY()
        //{
        //    float x = floatPx0 - ((floatPPeriod * floatPDotAngle) / (float)(intPFrequency * Math.PI));
        //    float y = floatPy0 - floatPAmplitude * (float)Math.Sin(floatPDotAngle);

        //    return new PointF(x, y);
        //}
    }
}
