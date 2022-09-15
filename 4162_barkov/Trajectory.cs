using System;
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
        private float _floatPPeriod;
        private float _floatPAmplitude;
        private float _floatPx0;
        private float _floatPy0;

        public void Draw(PictureBox pbox, Graphics g) 
        {
            _floatPx0 = pbox.Width / 2 + pbox.Width / 2 * floatPScaleX;
            _floatPy0 = pbox.Height / 2;

            // width of sine by x with public multiplier (period)
            _floatPPeriod = pbox.Width;

            // height of sine by y with public multiplier (amplitude)
            _floatPAmplitude = (pbox.Height / 2);

            Pen pen = new Pen(Brushes.Black, 0.01f);

            float x = 0, y = 0;

            // draw back lines from 0 to 10
            for (float f = 0; f < pbox.Width; f += (pbox.Width / 10))
            {
                g.DrawLine(new Pen(Brushes.Silver, 0.01F), f, pbox.Height, f, 0);
            }

            for (float angle = 0; angle <= intPFrequency * Math.PI; angle += 0.001f)
            {
                x = _floatPx0 - (((_floatPPeriod * floatPScaleX) * angle) / (float)(intPFrequency * Math.PI));
                y = _floatPy0 - (_floatPAmplitude * floatPScaleY) * (float)Math.Sin(angle);
                g.DrawLine(pen, x, y, x + 0.1f, y + 0.1f);
            }

            // draw horizontal line
            g.DrawLine(pen, _floatPx0, _floatPy0, x, y);
        }
    }
}
