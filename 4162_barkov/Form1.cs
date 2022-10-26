using System;
using System.Windows.Forms;

namespace _4162_barkov
{
    public partial class frmMain : Form
    {
        private Figure hypocycloid;

        private const float tbarMultiplier = 0.02f;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            hypocycloid = new Figure();
        }

        private void pboxFWorkArea_Paint(object sender, PaintEventArgs e)
        {

            hypocycloid.Draw(pboxFWorkArea, e.Graphics);
            hypocycloid.DrawFigure(e.Graphics);
            hypocycloid.scale = tbarFTrajectorySizeX.Value * tbarMultiplier;
            hypocycloid.intPFrequency = tbarFTrajectoryFrequency.Value * 2;
            hypocycloid.speed = tbarFFigureSpeed.Value;
            hypocycloid.breateRate = tbarFFigureBreatheRate.Value;

            pboxFWorkArea.Invalidate();
        }

        private void btnFDotButton_MouseDown(object sender, MouseEventArgs e)
        {
            hypocycloid.RunFigure();
        }
    }
}
