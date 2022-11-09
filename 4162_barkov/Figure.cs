using System;
using System.Drawing;
using System.Windows.Forms;
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
        public int breatheRate = 1;
        public Color figureColor = Color.Red;

        public void DrawFigure(PictureBox pbox, Graphics g)
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
                size = Math.Abs((float)Math.Cos(a * breatheRate));
                iteration = iteration + (speed / 3);

                pbox.Invalidate();
            };

            if (!visible)
            {
                return;
            }

            //delta = scale * size * 25;
            //or from 0 to big
            //delta = (scale + size) * 25;
            float deltaVertexA = (scale + size) * 200;
            float deltaVertexB = (scale + size) * 56;
            float deltaVertexC = (scale + size) * 90;
            float deltaVertexD = (scale + size) * 45;
            float deltaVertexE = (scale + size) * 100;

            Font font = new Font("Arial", 10);

            Pen pen = new Pen(figureColor, 2f);
            g.DrawString(
                "A", 
                font, 
                Brushes.Black, 
                pointFPpointPosition.X - 1 * deltaVertexA - 10, 
                pointFPpointPosition.Y
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X,
                pointFPpointPosition.Y,
                pointFPpointPosition.X - 1 * deltaVertexA,
                pointFPpointPosition.Y
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X - 1 * deltaVertexA,
                pointFPpointPosition.Y,
                pointFPpointPosition.X - 0.5f * deltaVertexB,
                pointFPpointPosition.Y - 1 * deltaVertexB
            );
            g.DrawString(
                "B",
                font,
                Brushes.Black,
                pointFPpointPosition.X - 0.5f * deltaVertexB - 10,
                pointFPpointPosition.Y - 1 * deltaVertexB - 15
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X - 0.5f * deltaVertexB,
                pointFPpointPosition.Y - 1 * deltaVertexB,
                pointFPpointPosition.X,
                pointFPpointPosition.Y
            );
            g.DrawString(
                "C",
                font,
                Brushes.Black,
                pointFPpointPosition.X + 0.5f * deltaVertexC - 10,
                pointFPpointPosition.Y - 1 * deltaVertexC - 15
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X,
                pointFPpointPosition.Y,
                pointFPpointPosition.X + 0.5f * deltaVertexC,
                pointFPpointPosition.Y - 1 * deltaVertexC
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X + 0.5f * deltaVertexC,
                pointFPpointPosition.Y - 1 * deltaVertexC,
                pointFPpointPosition.X + 1 * deltaVertexD,
                pointFPpointPosition.Y
            );
            g.DrawString(
                "D",
                font,
                Brushes.Black,
                pointFPpointPosition.X + 1 * deltaVertexD,
                pointFPpointPosition.Y
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X + 1 * deltaVertexD,
                pointFPpointPosition.Y,
                pointFPpointPosition.X,
                pointFPpointPosition.Y
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X + 0.5f * deltaVertexD,
                pointFPpointPosition.Y,
                pointFPpointPosition.X,
                pointFPpointPosition.Y + 1 * deltaVertexE
            );
            g.DrawString(
                "E",
                font,
                Brushes.Black,
                pointFPpointPosition.X,
                pointFPpointPosition.Y + 1 * deltaVertexE
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X,
                pointFPpointPosition.Y + 1 * deltaVertexE,
                pointFPpointPosition.X - 0.5f * deltaVertexE,
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
