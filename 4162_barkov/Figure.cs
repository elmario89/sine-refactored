using System.Drawing;
using Timer = System.Timers.Timer;

namespace _4162_barkov
{
    internal class Figure: HypocycloidTrajectory
    {
        // figure position
        private PointF pointFPpointPosition;
        private Timer tmrPTimer;
        private bool visible = false;

        public int speed = 1;

        public void DrawFigure(Graphics g)
        {
            tmrPTimer = new Timer();

            int iteration = 0;
            tmrPTimer.Interval = 100;
            tmrPTimer.Elapsed += (_, __) =>
            {
                PointF currentPoint = points[iteration];

                pointFPpointPosition = currentPoint;

                if (iteration >= points.Length - (speed / 2))
                {
                    tmrPTimer.Stop();
                    iteration = 0;
                    tmrPTimer.Start();
                    return;
                }
                iteration = iteration + (speed / 3);
            };

            Pen pen = new Pen(Brushes.Red, 0.5f);

            if (!visible)
            {
                return;
            }

            float delta = 25 * scale;

            g.DrawLine(
                pen, 
                pointFPpointPosition.X, 
                pointFPpointPosition.Y, 
                pointFPpointPosition.X - 1 * delta,
                pointFPpointPosition.Y
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X - 1 * delta ,
                pointFPpointPosition.Y,
                pointFPpointPosition.X - 0.5f * delta,
                pointFPpointPosition.Y - 1 * delta
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X - 0.5f * delta,
                pointFPpointPosition.Y - 1 * delta,
                pointFPpointPosition.X,
                pointFPpointPosition.Y
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X,
                pointFPpointPosition.Y,
                pointFPpointPosition.X + 0.5f * delta,
                pointFPpointPosition.Y - 1 * delta
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X + 0.5f * delta,
                pointFPpointPosition.Y - 1 * delta,
                pointFPpointPosition.X + 1 * delta,
                pointFPpointPosition.Y
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X + 1 * delta,
                pointFPpointPosition.Y,
                pointFPpointPosition.X,
                pointFPpointPosition.Y
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X + 0.5f * delta,
                pointFPpointPosition.Y,
                pointFPpointPosition.X,
                pointFPpointPosition.Y + 1 * delta
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X,
                pointFPpointPosition.Y + 1 * delta,
                pointFPpointPosition.X - 0.5f * delta,
                pointFPpointPosition.Y
            );
        }

        public void RunFigure()
        {
            visible = true;
            tmrPTimer.Start();
        }
    }
}
