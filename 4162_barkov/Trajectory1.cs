using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _4162_barkov
{
    internal class Trajectory1
    {
        // start angle
        private const double startAngle = 3 * Math.PI / 2;

        // end angle
        private const double endAngle = 5 * Math.PI / 2;

        // step for angle
        private const double angleStep = 0.1;
        
        // fixed radius
        private float r;

        // spin radius
        private float R;

        // center of figure
        private PointF basePoint;

        // scale
        public float scale = 0.5f;

        // points
        public List<PointF> points = new List<PointF>();

        // draw trajectory
        public void Draw(PictureBox pbox, Graphics g)
        {
            points.Clear();
            R = pbox.Height * scale / 2;
            r = R / 4;

            basePoint = new PointF(
                (pbox.Width - r) / 2,
                pbox.Height / 2
            );

            Pen pen = new Pen(Brushes.Green, 1.5f);


            for (double angle = startAngle; angle <= endAngle; angle += angleStep)
            {
                float x = (float)(basePoint.X + (R - r) * Math.Cos(angle) + r * Math.Cos((R - r) / r * angle));
                float y = (float)(basePoint.Y + (R - r) * Math.Sin(angle) - r * Math.Sin((R - r) / r * angle));

                points.Add(new PointF(x, y));
            }

            g.DrawPolygon(pen, points.ToArray());
        }
    }
}
