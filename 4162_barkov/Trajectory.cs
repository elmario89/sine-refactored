using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _4162_barkov
{
    internal class Trajectory
    {
        public float floatPScaleX = 0.5f;
        public float floatPScaleY = 0.5f;
        public int intPFrequency = 2;

        // properties of trajectory
        public float floatPPeriod;
        public float floatPAmplitude;
        public float floatPx0;
        public float floatPy0;

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

            Pen pen = new Pen(Brushes.Black, 0.01f);

            float x = 0, y = 0;

            // draw back lines from 0 to 10
            for (float f = 0; f < pbox.Width; f += (pbox.Width / 10))
            {
                g.DrawLine(new Pen(Brushes.Silver, 0.01F), f, pbox.Height, f, 0);
            }

            for (float angle = 0; angle <= intPFrequency * Math.PI; angle += 0.001f)
            {
                x = floatPx0 - ((floatPPeriod * angle) / (float)(intPFrequency * Math.PI));
                y = floatPy0 - floatPAmplitude * (float)Math.Sin(angle);
                g.DrawLine(pen, x, y, x + 0.1f, y + 0.1f);
            }

            int r = 6;
            int R = 24;
            int k = R / r - 1;

            float x1 = 0, y1 = 0;

            for (double angle = 3 * Math.PI / 2; angle <= 5 * Math.PI / 2; angle += 0.001f)
            {
                x1 = (float)(floatPx0 + (R - r) * Math.Cos(angle) + r * Math.Cos((R - r) / r * angle));
                y1 = (float)(floatPx0 + (R - r) * Math.Sin(angle) - r * Math.Sin((R - r) / r * angle));
                //x1 = (float)(floatPx0 + xx * Math.Cos(angle));
                //y1 = (float)(floatPy0 + yy * Math.Sin(angle));

                g.DrawLine(new Pen(Color.Red, 0.3f), x1, y1, x1 + 0.1f, y1 + 0.1f);
            }

            // draw horizontal line
            g.DrawLine(pen, floatPx0, floatPy0, x, y);
        }
    }
}
