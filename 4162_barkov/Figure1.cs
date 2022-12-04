using System.Drawing;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace _4162_barkov
{
    internal class Figure1: HypocycloidTrajectory
    {
        private Timer timer;
        private PointF pointFPpointPosition;

        public void DrawFigure(PictureBox pbox, Graphics g)
        {
            timer = new Timer();
            int iteration = 0;
            timer.Interval = 25;

            timer.Elapsed += (_, __) =>
            {
                pointFPpointPosition = points[iteration];

                if (iteration > points.Length - 1)
                {
                    iteration = 0;
                }

                iteration++; // iteration = iteration + 1;
            };

            Pen pen = new Pen(Color.Gold, 3f);

            g.DrawEllipse(pen, pointFPpointPosition.X, pointFPpointPosition.Y, 5, 5);
        }

        public void RunFigure()
        {
            timer.Start();
        }
    }
}
