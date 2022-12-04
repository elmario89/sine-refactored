using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Timers.Timer;

namespace _4162_barkov
{
    internal class Figure: HypocycloidTrajectory
    {
        // figure position
        private PointF pointFPpointPosition;
        private Timer tmrPTimer;
        private bool visible = false;
        private float size;

        public int speed = 1;
        public int breatheRate = 1;
        public Color figureColor = Color.Red;

        private Point[] _vertices;
        private Point[] ParseVertices(string[] input) 
        {
            Point[] points = new Point[5];

            for (int i = 0; i < points.Length; i++)
            {
                string[] splited = input[i].Split(',');

                points[i] = new Point(
                    Int32.Parse(splited[0]),
                    Int32.Parse(splited[1])
                );
            }

            return points;
        }

        public string[] Vertices
        {
            set { _vertices = this.ParseVertices(value); }
        }

        public void DrawFigure(PictureBox pbox, Graphics g)
        {
            tmrPTimer = new Timer();
            tmrPTimer.Interval = 25;

            if (pointFPpointPosition == null)
            {
                pointFPpointPosition = points[0];
            }

            int iteration = 0;
            float a = 0;
            float deltaA = 2 * (float)Math.PI / points.Length;

            tmrPTimer.Elapsed += (_, __) =>
            {
                pointFPpointPosition = points[iteration];

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

            Pen pen = new Pen(figureColor, 2f);
            Font font = new Font("Arial", 10);

            g.DrawString(
                "A", 
                font, 
                Brushes.Black, 
                pointFPpointPosition.X + _vertices[0].X * (scale + size) - 10, 
                pointFPpointPosition.Y + _vertices[0].Y * (scale + size)
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X,
                pointFPpointPosition.Y,
                pointFPpointPosition.X + _vertices[0].X * (scale + size),
                pointFPpointPosition.Y + _vertices[0].Y * (scale + size)
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X + _vertices[0].X * (scale + size),
                pointFPpointPosition.Y + _vertices[0].Y * (scale + size),
                pointFPpointPosition.X + _vertices[1].X * (scale + size),
                pointFPpointPosition.Y + _vertices[1].Y * (scale + size)
            );
            g.DrawString(
                "B",
                font,
                Brushes.Black,
                pointFPpointPosition.X + _vertices[1].X * (scale + size) - 10,
                pointFPpointPosition.Y + _vertices[1].Y * (scale + size) - 15
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X + _vertices[1].X * (scale + size),
                pointFPpointPosition.Y + _vertices[1].Y * (scale + size),
                pointFPpointPosition.X,
                pointFPpointPosition.Y
            );
            g.DrawString(
                "C",
                font,
                Brushes.Black,
                pointFPpointPosition.X + _vertices[2].X * (scale + size) - 10,
                pointFPpointPosition.Y + _vertices[2].Y * (scale + size) - 15
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X,
                pointFPpointPosition.Y,
                pointFPpointPosition.X + _vertices[2].X * (scale + size),
                pointFPpointPosition.Y + _vertices[2].Y * (scale + size)
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X + _vertices[2].X * (scale + size),
                pointFPpointPosition.Y + _vertices[2].Y * (scale + size),
                pointFPpointPosition.X + _vertices[3].X * (scale + size),
                pointFPpointPosition.Y + _vertices[3].Y * (scale + size)
            );
            g.DrawString(
                "D",
                font,
                Brushes.Black,
                pointFPpointPosition.X + _vertices[3].X * (scale + size),
                pointFPpointPosition.Y + _vertices[3].Y * (scale + size)
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X + _vertices[3].X * (scale + size),
                pointFPpointPosition.Y + _vertices[3].Y * (scale + size),
                pointFPpointPosition.X,
                pointFPpointPosition.Y
            );
            g.DrawString(
                "E",
                font,
                Brushes.Black,
                pointFPpointPosition.X + _vertices[4].X * (scale + size),
                pointFPpointPosition.Y + _vertices[4].Y * (scale + size)
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X + _vertices[4].X * (scale + size),
                pointFPpointPosition.Y + _vertices[4].Y * (scale + size),
                pointFPpointPosition.X + _vertices[3].X * (scale + size) / 2,
                pointFPpointPosition.Y + _vertices[3].Y * (scale + size) / 2
            );
            g.DrawLine(
                pen,
                pointFPpointPosition.X + _vertices[4].X * (scale + size),
                pointFPpointPosition.Y + _vertices[4].Y * (scale + size),
                pointFPpointPosition.X + _vertices[0].X * (scale + size) / 2,
                pointFPpointPosition.Y + _vertices[0].Y * (scale + size) / 2
            );
        }
        public void RunFigure()
        {
            visible = true;
            tmrPTimer.Start();
        }
    }
}
