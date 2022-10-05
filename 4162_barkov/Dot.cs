using System.Drawing;
using Timer = System.Timers.Timer;

namespace _4162_barkov
{
    internal class Dot
    {
        // running dot
        private PointF pointFPpointPosition;
        private Timer tmrPTimer;

        // points for polygon, size is dynamic
        public PointF[] points;
        public int pointsSize = 100;

        public Dot(int size)
        {
            pointsSize = size;
            points = new PointF[pointsSize];
        }

        public void DrawDot(Graphics g)
        {
            int i = 0;
            tmrPTimer = new Timer();
            tmrPTimer.Interval = 100;
            tmrPTimer.Elapsed += (_, __) =>
            {
                PointF currentPoint = points[i];

                pointFPpointPosition = currentPoint;

                if (i >= points.Length - 1)
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
