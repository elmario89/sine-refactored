﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace _4162_barkov
{
    public partial class frmMain : Form
    {
        private Trajectory _trajectory;
        private Dot _dot;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _trajectory = new Trajectory();
            _dot = new Dot();
        }

        private void pboxFWorkArea_Paint(object sender, PaintEventArgs e)
        {
            int baseWidth = ClientSize.Width - panelFControlArea.ClientSize.Width;

            pboxFWorkArea.Height = ClientSize.Height;
            pboxFWorkArea.Width = baseWidth;

            _trajectory.floatPScaleX = tbarFTrajectorySizeX.Value * 0.02f;
            _trajectory.floatPScaleY = tbarFTrajectorySizeY.Value * 0.02f;
            _trajectory.intPFrequency = tbarFTrajectoryFrequency.Value;
            _trajectory.Draw(pboxFWorkArea, e.Graphics);
            _dot.Draw(pboxFWorkArea, e.Graphics);

            pboxFWorkArea.Invalidate();
        }

        private void btnFDotButton_MouseDown(object sender, MouseEventArgs e)
        {
            _dot.RunDot();
        }
    }
}
