using System.Drawing;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace _4162_barkov
{
    internal class Dot1: HypocycloidTrajectory
    {
        private Timer timer;
        private PointF currentPointPosition;

        public void DrawDot(PictureBox pbox, Graphics g)
        {
            timer = new Timer();
            timer.Interval = 50;

            int iteration = 0;

            timer.Elapsed += (_, __) =>
            {
                if (iteration > points.Length - 1)
                {
                    iteration = 0;
                }

                currentPointPosition = points[iteration];
                iteration = iteration + 1;
            };

            g.DrawEllipse(new Pen(Color.Blue, 1f), currentPointPosition.X, currentPointPosition.Y, 5, 5);
        }

        public void RunDot()
        {
            timer.Start();
        }
    }
}
