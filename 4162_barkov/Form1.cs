using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace _4162_barkov
{
    public partial class frmMain : Form
    {
        private Figure hypocycloid;

        private const float tbarMultiplier = 0.02f;
        private string[] settingVertices;
        private string[] defaultVertices;

        public frmMain()
        {
            settingVertices = parseVertices(ConfigurationManager.AppSettings["Vertices"]);
            defaultVertices = parseVertices(ConfigurationManager.AppSettings["DefaultVertices"]);
            InitializeComponent();
        }

        private string[] parseVertices(string input)
        {
            return input
                .Split(';')
                .ToArray();
        }

        private string parseVerticesToSettings(string[] input)
        {
            return String.Join(";", input);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            hypocycloid = new Figure();
            tboxFVertexBox.Lines = settingVertices;
            hypocycloid.Vertices = tboxFVertexBox.Lines;
        }

        private void pboxFWorkArea_Paint(object sender, PaintEventArgs e)
        {
            hypocycloid.Draw(pboxFWorkArea, e.Graphics);
            hypocycloid.DrawFigure(pboxFWorkArea, e.Graphics);
            hypocycloid.scale = tbarFTrajectorySizeX.Value * tbarMultiplier;
            hypocycloid.intPFrequency = tbarFTrajectoryFrequency.Value * 2;
            hypocycloid.speed = tbarFFigureSpeed.Value;
            hypocycloid.breatheRate = tbarFFigureBreatheRate.Value;
        }

        private void btnFDotButton_MouseDown(object sender, MouseEventArgs e)
        {
            hypocycloid.RunFigure();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            pboxFWorkArea.Invalidate();
        }

        private void tbarFTrajectorySizeX_ValueChanged(object sender, EventArgs e)
        {
            pboxFWorkArea.Invalidate();
        }

        private void tbarFTrajectoryFrequency_ValueChanged(object sender, EventArgs e)
        {
            pboxFWorkArea.Invalidate();
        }

        private void tbarFFigureSpeed_ValueChanged(object sender, EventArgs e)
        {
            pboxFWorkArea.Invalidate();
        }

        private void tbarFFigureBreatheRate_ValueChanged(object sender, EventArgs e)
        {
            pboxFWorkArea.Invalidate();
        }

        private void btnFTrajectoryColorButton_Click(object sender, EventArgs e)
        {
            if (cdFTrajectoryColorDialog.ShowDialog() == DialogResult.OK)
            {
                hypocycloid.trajectoryColor = cdFTrajectoryColorDialog.Color;
                pboxFWorkArea.Invalidate();
            }
        }

        private void btnFPboxColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pboxFWorkArea.BackColor = colorDialog1.Color;
                pboxFWorkArea.Invalidate();
            }
        }

        private void btnFFigureColorButton_Click(object sender, EventArgs e)
        {
            if (cdFFigureColorDialog.ShowDialog() == DialogResult.OK)
            {
                hypocycloid.figureColor = cdFFigureColorDialog.Color;
                pboxFWorkArea.Invalidate();
            }
        }

        private void btnFRedrawButton_Click(object sender, EventArgs e)
        {
            hypocycloid.Vertices = tboxFVertexBox.Lines;
        }

        private void btnFRedrawDefaultButton_Click(object sender, EventArgs e)
        {
            tboxFVertexBox.Lines = defaultVertices;
            hypocycloid.Vertices = tboxFVertexBox.Lines;
        }

        private void btnFCopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tboxFVertexBox.Text);
        }

        private void btnFPasteButton_Click(object sender, EventArgs e)
        {
            tboxFVertexBox.Text = Clipboard.GetText();
            hypocycloid.Vertices = tboxFVertexBox.Lines;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["Vertices"].Value = parseVerticesToSettings(tboxFVertexBox.Lines);
            config.Save();
        }

        private void tboxFVertexBox_TextChanged(object sender, EventArgs e)
        {
            tboxFVertexBox.Pasted += (_, args) =>
            {
                string[] stringSeparators = new string[] { "\r\n" };
                tboxFVertexBox.Lines = args.ClipboardText.Split(stringSeparators, StringSplitOptions.None);
                hypocycloid.Vertices = tboxFVertexBox.Lines;
            };
        }
    }
}
