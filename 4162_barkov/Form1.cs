using System;
using System.Drawing;
using System.Windows.Forms;

namespace _4162_barkov
{
    public partial class frmMain : Form
    {
        private Trajectory trajectory;
        private Dot dot;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            trajectory = new Trajectory();
            dot = new Dot();
        }

        private void pboxFWorkArea_Paint(object sender, PaintEventArgs e)
        {
            int baseWidth = ClientSize.Width - panelFControlArea.ClientSize.Width;

            pboxFWorkArea.Height = ClientSize.Height;
            pboxFWorkArea.Width = baseWidth;

            trajectory.floatPScaleX = tbarFTrajectorySizeX.Value * 0.02f;
            trajectory.floatPScaleY = tbarFTrajectorySizeY.Value * 0.02f;
            trajectory.intPFrequency = tbarFTrajectoryFrequency.Value;

            dot.floatPScaleX = tbarFTrajectorySizeX.Value * 0.02f;
            dot.floatPScaleY = tbarFTrajectorySizeY.Value * 0.02f;
            dot.intPFrequency = tbarFTrajectoryFrequency.Value;

            trajectory.Draw(pboxFWorkArea, e.Graphics);
            dot.Draw(pboxFWorkArea, e.Graphics);

            pboxFWorkArea.Invalidate();
        }

        private void btnFDotButton_MouseDown(object sender, MouseEventArgs e)
        {
            dot.RunDot();
        }

        private void btnFDotButtonStop_Click(object sender, EventArgs e)
        {
            dot.StopDot();
        }
    }
}
