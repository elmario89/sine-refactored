using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace _4162_barkov
{
    internal class Dot
    {
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
        }

        public void RunDot()
        {
            tmrPTimer.Start();
        }

        public void StopDot()
        {
            tmrPTimer.Stop();
        }
    }
}
