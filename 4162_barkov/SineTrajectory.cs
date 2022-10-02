using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _4162_barkov
{
    internal class SineTrajectory: Dot 
    {
        public float floatPScaleX = 0.5f;
        public float floatPScaleY = 0.5f;
        public int intPFrequency = 2;

        // properties of trajectory
        public float floatPPeriod;
        public float floatPAmplitude;
        public float floatPx0;
        public float floatPy0;

        public SineTrajectory(int size) : base(size)
        {
            pointsSize = size;
            points = new PointF[pointsSize];
        }

        public void Draw(PictureBox pbox, Graphics g) 
        {
            // x0 right end coordinates
            // y0 horizontal line coordinates
            floatPx0 = (pbox.Width + pbox.Width * floatPScaleX) / 2;
            floatPy0 = pbox.Height / 2;

            // width of sine by x with public multiplier (period)
            floatPPeriod = pbox.Width * floatPScaleX;

            // height of sine by y with public multiplier (amplitude)
            floatPAmplitude = (pbox.Height / 2) * floatPScaleY;

            Pen pen = new Pen(Brushes.Maroon, 0.01f);

            // draw back lines from 0 to 10
            for (float f = 0; f < pbox.Width; f += (pbox.Width / 10))
            {
                g.DrawLine(new Pen(Brushes.Silver, 0.01F), f, pbox.Height, f, 0);
            }

            float dubFi = 0;
            float dubDeltaFi = intPFrequency * (float)Math.PI / points.Length;

            for (int i = 0; i < points.Length; i++)
            {
                float x = floatPx0 - ((floatPPeriod * dubFi) / (float)(intPFrequency * Math.PI));
                float y = floatPy0 - floatPAmplitude * (float)Math.Sin(dubFi);
                points[i] = (new PointF(x, y));
                dubFi = dubFi + dubDeltaFi;
            }

            g.DrawPolygon(pen, points);
        }
    }
}
