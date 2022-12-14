using System;
using System.Drawing;
using System.Windows.Forms;

namespace _4162_barkov
{
    internal class HypocycloidTrajectory
    {
        // center of figure
        protected PointF basePoint;
        protected PointF[] points = new PointF[300];

        // scale
        public float scale = 0.5f;
        public int intPFrequency = 4;
        public Color trajectoryColor = Color.Green;
                
        // draw trajectory
        public void Draw(PictureBox pbox, Graphics g)
        {
            float R = (pbox.Height < pbox.Width ? pbox.Height : pbox.Width) * scale / 2;
            float r = R / intPFrequency;

            basePoint = new PointF(
                (pbox.Width - r) / 2,
                pbox.Height / 2
            );

            Pen pen = new Pen(trajectoryColor, 1.5f);

            float a = 0;
            float deltaA = 2 * (float)Math.PI / points.Length;

            // draw back lines from 0 to 10
            for (float f = 0; f < pbox.Width; f += (pbox.Width / 10))
            {
                g.DrawLine(new Pen(Brushes.Silver, 0.01F), f, pbox.Height, f, 0);
            }

            for (int i = 0; i < points.Length; i++)
            {
                float x = (float)(basePoint.X + (R - r) * Math.Cos(a) + r * Math.Cos((R - r) / r * a));
                float y = (float)(basePoint.Y + (R - r) * Math.Sin(a) - r * Math.Sin((R - r) / r * a));

                if (a > Math.PI / 2 && a < 3 * Math.PI / 2) // 3.14
                {
                    x = basePoint.X;
                }

                points[i] = new PointF(x, y);
                a = a + deltaA;
            }

            g.DrawPolygon(pen, points);
        }
    }
}
