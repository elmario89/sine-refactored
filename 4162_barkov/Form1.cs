using System;
using System.CodeDom;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace _4162_barkov
{
    public partial class frmMain : Form
    {
        private SineTrajectory sine;
        private HypocycloidTrajectory hypocycloid;

        private const float tbarMultiplier = 0.02f;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            sine = new SineTrajectory(200);
            hypocycloid = new HypocycloidTrajectory(100);
        }

        private void pboxFWorkArea_Paint(object sender, PaintEventArgs e)
        {
            int baseWidth = ClientSize.Width - panelFControlArea.ClientSize.Width;

            pboxFWorkArea.Height = ClientSize.Height;
            pboxFWorkArea.Width = baseWidth;

            sine.floatPScaleX = tbarFTrajectorySizeX.Value * tbarMultiplier;
            sine.floatPScaleY = tbarFTrajectorySizeY.Value * tbarMultiplier;
            sine.intPFrequency = tbarFTrajectoryFrequency.Value;

            sine.Draw(pboxFWorkArea, e.Graphics);
            sine.DrawDot(e.Graphics);

            hypocycloid.Draw(pboxFWorkArea, e.Graphics);
            hypocycloid.DrawDot(e.Graphics);
            hypocycloid.scale = tbarFTrajectorySizeX.Value * tbarMultiplier;
            hypocycloid.intPFrequency = tbarFTrajectoryFrequency.Value * 2;

            pboxFWorkArea.Invalidate();
        }

        private void btnFDotButton_MouseDown(object sender, MouseEventArgs e)
        {
            hypocycloid.RunDot();
            sine.RunDot();
        }

        private void btnFDotButtonStop_Click(object sender, EventArgs e)
        {
            hypocycloid.StopDot();
            sine.StopDot();
        }
    }
}
