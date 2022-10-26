using System;
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
        private float delta = 25;
        private float size;

        public int speed = 1;
        public int breateRate = 1;

        public void DrawFigure(Graphics g)
        {

            tmrPTimer = new Timer();

            int iteration = 0;
            tmrPTimer.Interval = 25;
            float a = 0;
            float deltaA = 2 * (float)Math.PI / points.Length;

            tmrPTimer.Elapsed += (_, __) =>
            {
                PointF currentPoint = points[iteration];

                pointFPpointPosition = currentPoint;

                if (iteration >= points.Length - (speed / 3))
                {
                    iteration = 0;
                    return;
                }

                a = a + deltaA;
                size = Math.Abs((float)Math.Cos(a * breateRate));
                iteration = iteration + (speed / 3);
            };

            if (!visible)
            {
                return;
            }

            //delta = scale * size * 25;
            //or from 0 to big
            delta = (scale + size) * 25;

            Pen pen = new Pen(Brushes.Red, 0.5f);
            g.DrawLine(
                pen,
                pointFPpointPosition.X,
                pointFPpointPosition.Y,
                pointFPpointPosition.X - 1 * delta,
                pointFPpointPosition.Y
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X - 1 * delta,
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
