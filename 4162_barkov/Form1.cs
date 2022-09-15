using System;
using System.Drawing;
using System.Windows.Forms;

namespace _4162_barkov
{
    public partial class frmMain : Form
    {
        private Trajectory _Trajectory;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _Trajectory = new Trajectory();
        }

        private void pboxFWorkArea_Paint(object sender, PaintEventArgs e)
        {
            int baseWidth = ClientSize.Width - panelFControlArea.ClientSize.Width;

            pboxFWorkArea.Height = ClientSize.Height;
            pboxFWorkArea.Width = baseWidth;

            _Trajectory.floatPScaleX = tbarFTrajectorySizeX.Value * 0.02f;
            _Trajectory.floatPScaleY = tbarFTrajectorySizeY.Value * 0.02f;
            _Trajectory.intPFrequency = tbarFTrajectoryFrequency.Value;
            _Trajectory.Draw(pboxFWorkArea, e.Graphics);

            pboxFWorkArea.Invalidate();
        }
    }
}
