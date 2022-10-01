using System;
using System.CodeDom;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace _4162_barkov
{
    public partial class frmMain : Form
    {
        private Trajectory trajectory;
        private Trajectory1 trajectory1;
        private Dot dot;

        private const float tbarMultiplier = 0.02f;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            trajectory = new Trajectory();
            dot = new Dot();
            trajectory1 = new Trajectory1();
            ResizeRedraw = true;
        }

        private void pboxFWorkArea_Paint(object sender, PaintEventArgs e)
        {
            int baseWidth = ClientSize.Width - panelFControlArea.ClientSize.Width;

            pboxFWorkArea.Height = ClientSize.Height;
            pboxFWorkArea.Width = baseWidth;

            trajectory.floatPScaleX = tbarFTrajectorySizeX.Value * tbarMultiplier;
            trajectory.floatPScaleY = tbarFTrajectorySizeY.Value * tbarMultiplier;
            trajectory.intPFrequency = tbarFTrajectoryFrequency.Value;

            dot.floatPScaleX = tbarFTrajectorySizeX.Value * tbarMultiplier;
            dot.floatPScaleY = tbarFTrajectorySizeY.Value * tbarMultiplier;
            dot.intPFrequency = tbarFTrajectoryFrequency.Value;

            trajectory.Draw(pboxFWorkArea, e.Graphics);
            
            trajectory1.Draw(pboxFWorkArea, e.Graphics);
            trajectory1.scale = tbarFTrajectorySizeX.Value * 0.02f;

            dot.Draw(trajectory1.points, e.Graphics);
            //dot.Draw(trajectory.points, e.Graphics);

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
