using System;
using System.Drawing;
using System.Windows.Forms;

namespace _4162_barkov
{
    internal class HypocycloidTrajectory: Dot
    {
        // fixed radius
        private float r;

        // spin radius
        private float R;

        // center of figure
        private PointF basePoint;

        // scale
        public float scale = 0.5f;
        public int intPFrequency = 4;

        public HypocycloidTrajectory(int size) : base(size)
        {
            pointsSize = size;
            points = new PointF[pointsSize];
        }

        // draw trajectory
        public void Draw(PictureBox pbox, Graphics g)
        {
            R = pbox.Height * scale / 2;
            r = R / intPFrequency;

            basePoint = new PointF(
                (pbox.Width - r) / 2,
                pbox.Height / 2
            );

            Pen pen = new Pen(Brushes.Green, 1.5f);

            float dubFi = 3 * (float)Math.PI / 2;
            float dubDeltaFi = (float)Math.PI / points.Length;

            for (int i = 0; i < points.Length; i++)
            {
                float x = (float)(basePoint.X + (R - r) * Math.Cos(dubFi) + r * Math.Cos((R - r) / r * dubFi));
                float y = (float)(basePoint.Y + (R - r) * Math.Sin(dubFi) - r * Math.Sin((R - r) / r * dubFi));

                points[i] = new PointF(x, y);
                dubFi = dubFi + dubDeltaFi;
            }

            g.DrawPolygon(pen, points);
        }
    }
}
