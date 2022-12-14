namespace _4162_barkov
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pboxFWorkArea = new System.Windows.Forms.PictureBox();
            this.panelFControlArea = new System.Windows.Forms.Panel();
            this.btnFPasteButton = new System.Windows.Forms.Button();
            this.btnFCopyButton = new System.Windows.Forms.Button();
            this.btnFRedrawDefaultButton = new System.Windows.Forms.Button();
            this.btnFRedrawButton = new System.Windows.Forms.Button();
            this.lblFVertexELabel = new System.Windows.Forms.Label();
            this.lblFVertexDLabel = new System.Windows.Forms.Label();
            this.lblFVertexCLabel = new System.Windows.Forms.Label();
            this.lblFVertexBLabel = new System.Windows.Forms.Label();
            this.lblFVertexALabel = new System.Windows.Forms.Label();
            this.btnFFigureColorButton = new System.Windows.Forms.Button();
            this.btnFTrajectoryColorButton = new System.Windows.Forms.Button();
            this.btnFPboxColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbarFFigureBreatheRate = new System.Windows.Forms.TrackBar();
            this.tbarFFigureSpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFDotButton = new System.Windows.Forms.Button();
            this.labelFTrajectorySizeXY = new System.Windows.Forms.Label();
            this.tbarFTrajectoryFrequency = new System.Windows.Forms.TrackBar();
            this.tbarFTrajectorySizeX = new System.Windows.Forms.TrackBar();
            this.labelFTrajectorySizeX = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cdFCanvasColorDialog = new System.Windows.Forms.ColorDialog();
            this.cdFTrajectoryColorDialog = new System.Windows.Forms.ColorDialog();
            this.cdFFigureColorDialog = new System.Windows.Forms.ColorDialog();
            this.tboxFVertexBox = new MyTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFWorkArea)).BeginInit();
            this.panelFControlArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFFigureBreatheRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFFigureSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectoryFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeX)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxFWorkArea
            // 
            this.pboxFWorkArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxFWorkArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pboxFWorkArea.Location = new System.Drawing.Point(0, 1);
            this.pboxFWorkArea.Name = "pboxFWorkArea";
            this.pboxFWorkArea.Size = new System.Drawing.Size(792, 711);
            this.pboxFWorkArea.TabIndex = 0;
            this.pboxFWorkArea.TabStop = false;
            this.pboxFWorkArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxFWorkArea_Paint);
            // 
            // panelFControlArea
            // 
            this.panelFControlArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFControlArea.Controls.Add(this.tboxFVertexBox);
            this.panelFControlArea.Controls.Add(this.btnFPasteButton);
            this.panelFControlArea.Controls.Add(this.btnFCopyButton);
            this.panelFControlArea.Controls.Add(this.btnFRedrawDefaultButton);
            this.panelFControlArea.Controls.Add(this.btnFRedrawButton);
            this.panelFControlArea.Controls.Add(this.lblFVertexELabel);
            this.panelFControlArea.Controls.Add(this.lblFVertexDLabel);
            this.panelFControlArea.Controls.Add(this.lblFVertexCLabel);
            this.panelFControlArea.Controls.Add(this.lblFVertexBLabel);
            this.panelFControlArea.Controls.Add(this.lblFVertexALabel);
            this.panelFControlArea.Controls.Add(this.btnFFigureColorButton);
            this.panelFControlArea.Controls.Add(this.btnFTrajectoryColorButton);
            this.panelFControlArea.Controls.Add(this.btnFPboxColorButton);
            this.panelFControlArea.Controls.Add(this.label2);
            this.panelFControlArea.Controls.Add(this.tbarFFigureBreatheRate);
            this.panelFControlArea.Controls.Add(this.tbarFFigureSpeed);
            this.panelFControlArea.Controls.Add(this.label1);
            this.panelFControlArea.Controls.Add(this.btnFDotButton);
            this.panelFControlArea.Controls.Add(this.labelFTrajectorySizeXY);
            this.panelFControlArea.Controls.Add(this.tbarFTrajectoryFrequency);
            this.panelFControlArea.Controls.Add(this.tbarFTrajectorySizeX);
            this.panelFControlArea.Controls.Add(this.labelFTrajectorySizeX);
            this.panelFControlArea.Location = new System.Drawing.Point(798, 1);
            this.panelFControlArea.Name = "panelFControlArea";
            this.panelFControlArea.Size = new System.Drawing.Size(322, 699);
            this.panelFControlArea.TabIndex = 1;
            // 
            // btnFPasteButton
            // 
            this.btnFPasteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.btnFPasteButton.Location = new System.Drawing.Point(166, 627);
            this.btnFPasteButton.Name = "btnFPasteButton";
            this.btnFPasteButton.Size = new System.Drawing.Size(153, 50);
            this.btnFPasteButton.TabIndex = 22;
            this.btnFPasteButton.Text = "Вставить";
            this.btnFPasteButton.UseVisualStyleBackColor = true;
            this.btnFPasteButton.Click += new System.EventHandler(this.btnFPasteButton_Click);
            // 
            // btnFCopyButton
            // 
            this.btnFCopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.btnFCopyButton.Location = new System.Drawing.Point(10, 627);
            this.btnFCopyButton.Name = "btnFCopyButton";
            this.btnFCopyButton.Size = new System.Drawing.Size(153, 50);
            this.btnFCopyButton.TabIndex = 21;
            this.btnFCopyButton.Text = "Копировать";
            this.btnFCopyButton.UseVisualStyleBackColor = true;
            this.btnFCopyButton.Click += new System.EventHandler(this.btnFCopyButton_Click);
            // 
            // btnFRedrawDefaultButton
            // 
            this.btnFRedrawDefaultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.btnFRedrawDefaultButton.Location = new System.Drawing.Point(166, 545);
            this.btnFRedrawDefaultButton.Name = "btnFRedrawDefaultButton";
            this.btnFRedrawDefaultButton.Size = new System.Drawing.Size(153, 50);
            this.btnFRedrawDefaultButton.TabIndex = 20;
            this.btnFRedrawDefaultButton.Text = "По умолчанию";
            this.btnFRedrawDefaultButton.UseVisualStyleBackColor = true;
            this.btnFRedrawDefaultButton.Click += new System.EventHandler(this.btnFRedrawDefaultButton_Click);
            // 
            // btnFRedrawButton
            // 
            this.btnFRedrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.btnFRedrawButton.Location = new System.Drawing.Point(166, 487);
            this.btnFRedrawButton.Name = "btnFRedrawButton";
            this.btnFRedrawButton.Size = new System.Drawing.Size(153, 50);
            this.btnFRedrawButton.TabIndex = 19;
            this.btnFRedrawButton.Text = "Перерисовать";
            this.btnFRedrawButton.UseVisualStyleBackColor = true;
            this.btnFRedrawButton.Click += new System.EventHandler(this.btnFRedrawButton_Click);
            // 
            // lblFVertexELabel
            // 
            this.lblFVertexELabel.AutoSize = true;
            this.lblFVertexELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12F);
            this.lblFVertexELabel.Location = new System.Drawing.Point(4, 597);
            this.lblFVertexELabel.Name = "lblFVertexELabel";
            this.lblFVertexELabel.Size = new System.Drawing.Size(23, 24);
            this.lblFVertexELabel.TabIndex = 18;
            this.lblFVertexELabel.Text = "E";
            // 
            // lblFVertexDLabel
            // 
            this.lblFVertexDLabel.AutoSize = true;
            this.lblFVertexDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12F);
            this.lblFVertexDLabel.Location = new System.Drawing.Point(4, 571);
            this.lblFVertexDLabel.Name = "lblFVertexDLabel";
            this.lblFVertexDLabel.Size = new System.Drawing.Size(23, 24);
            this.lblFVertexDLabel.TabIndex = 17;
            this.lblFVertexDLabel.Text = "D";
            // 
            // lblFVertexCLabel
            // 
            this.lblFVertexCLabel.AutoSize = true;
            this.lblFVertexCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12F);
            this.lblFVertexCLabel.Location = new System.Drawing.Point(4, 543);
            this.lblFVertexCLabel.Name = "lblFVertexCLabel";
            this.lblFVertexCLabel.Size = new System.Drawing.Size(23, 24);
            this.lblFVertexCLabel.TabIndex = 16;
            this.lblFVertexCLabel.Text = "C";
            // 
            // lblFVertexBLabel
            // 
            this.lblFVertexBLabel.AutoSize = true;
            this.lblFVertexBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12F);
            this.lblFVertexBLabel.Location = new System.Drawing.Point(5, 515);
            this.lblFVertexBLabel.Name = "lblFVertexBLabel";
            this.lblFVertexBLabel.Size = new System.Drawing.Size(22, 24);
            this.lblFVertexBLabel.TabIndex = 15;
            this.lblFVertexBLabel.Text = "B";
            // 
            // lblFVertexALabel
            // 
            this.lblFVertexALabel.AutoSize = true;
            this.lblFVertexALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12F);
            this.lblFVertexALabel.Location = new System.Drawing.Point(6, 489);
            this.lblFVertexALabel.Name = "lblFVertexALabel";
            this.lblFVertexALabel.Size = new System.Drawing.Size(23, 24);
            this.lblFVertexALabel.TabIndex = 14;
            this.lblFVertexALabel.Text = "A";
            // 
            // btnFFigureColorButton
            // 
            this.btnFFigureColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.btnFFigureColorButton.Location = new System.Drawing.Point(166, 402);
            this.btnFFigureColorButton.Name = "btnFFigureColorButton";
            this.btnFFigureColorButton.Size = new System.Drawing.Size(153, 50);
            this.btnFFigureColorButton.TabIndex = 12;
            this.btnFFigureColorButton.Text = "Цвет фигуры";
            this.btnFFigureColorButton.UseVisualStyleBackColor = true;
            this.btnFFigureColorButton.Click += new System.EventHandler(this.btnFFigureColorButton_Click);
            // 
            // btnFTrajectoryColorButton
            // 
            this.btnFTrajectoryColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.btnFTrajectoryColorButton.Location = new System.Drawing.Point(3, 402);
            this.btnFTrajectoryColorButton.Name = "btnFTrajectoryColorButton";
            this.btnFTrajectoryColorButton.Size = new System.Drawing.Size(159, 50);
            this.btnFTrajectoryColorButton.TabIndex = 11;
            this.btnFTrajectoryColorButton.Text = "Цвет траектории";
            this.btnFTrajectoryColorButton.UseVisualStyleBackColor = true;
            this.btnFTrajectoryColorButton.Click += new System.EventHandler(this.btnFTrajectoryColorButton_Click);
            // 
            // btnFPboxColorButton
            // 
            this.btnFPboxColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.btnFPboxColorButton.Location = new System.Drawing.Point(166, 346);
            this.btnFPboxColorButton.Name = "btnFPboxColorButton";
            this.btnFPboxColorButton.Size = new System.Drawing.Size(153, 50);
            this.btnFPboxColorButton.TabIndex = 2;
            this.btnFPboxColorButton.Text = "Цвет канваса";
            this.btnFPboxColorButton.UseVisualStyleBackColor = true;
            this.btnFPboxColorButton.Click += new System.EventHandler(this.btnFPboxColorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.label2.Location = new System.Drawing.Point(4, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Скорость дыхания";
            // 
            // tbarFFigureBreatheRate
            // 
            this.tbarFFigureBreatheRate.Location = new System.Drawing.Point(8, 284);
            this.tbarFFigureBreatheRate.Minimum = 1;
            this.tbarFFigureBreatheRate.Name = "tbarFFigureBreatheRate";
            this.tbarFFigureBreatheRate.Size = new System.Drawing.Size(261, 56);
            this.tbarFFigureBreatheRate.TabIndex = 9;
            this.tbarFFigureBreatheRate.Value = 1;
            this.tbarFFigureBreatheRate.ValueChanged += new System.EventHandler(this.tbarFFigureBreatheRate_ValueChanged);
            // 
            // tbarFFigureSpeed
            // 
            this.tbarFFigureSpeed.Location = new System.Drawing.Point(8, 196);
            this.tbarFFigureSpeed.Maximum = 12;
            this.tbarFFigureSpeed.Minimum = 3;
            this.tbarFFigureSpeed.Name = "tbarFFigureSpeed";
            this.tbarFFigureSpeed.Size = new System.Drawing.Size(261, 56);
            this.tbarFFigureSpeed.TabIndex = 8;
            this.tbarFFigureSpeed.Value = 3;
            this.tbarFFigureSpeed.ValueChanged += new System.EventHandler(this.tbarFFigureSpeed_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.label1.Location = new System.Drawing.Point(4, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Скорость фигуры";
            // 
            // btnFDotButton
            // 
            this.btnFDotButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFDotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.btnFDotButton.Location = new System.Drawing.Point(3, 346);
            this.btnFDotButton.Name = "btnFDotButton";
            this.btnFDotButton.Padding = new System.Windows.Forms.Padding(5);
            this.btnFDotButton.Size = new System.Drawing.Size(159, 50);
            this.btnFDotButton.TabIndex = 6;
            this.btnFDotButton.Text = "Старт фигуры";
            this.btnFDotButton.UseVisualStyleBackColor = true;
            this.btnFDotButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFDotButton_MouseDown);
            // 
            // labelFTrajectorySizeXY
            // 
            this.labelFTrajectorySizeXY.AutoSize = true;
            this.labelFTrajectorySizeXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.labelFTrajectorySizeXY.Location = new System.Drawing.Point(4, 63);
            this.labelFTrajectorySizeXY.Name = "labelFTrajectorySizeXY";
            this.labelFTrajectorySizeXY.Size = new System.Drawing.Size(81, 20);
            this.labelFTrajectorySizeXY.TabIndex = 5;
            this.labelFTrajectorySizeXY.Text = "Частота";
            // 
            // tbarFTrajectoryFrequency
            // 
            this.tbarFTrajectoryFrequency.Location = new System.Drawing.Point(8, 99);
            this.tbarFTrajectoryFrequency.Maximum = 26;
            this.tbarFTrajectoryFrequency.Minimum = 2;
            this.tbarFTrajectoryFrequency.Name = "tbarFTrajectoryFrequency";
            this.tbarFTrajectoryFrequency.Size = new System.Drawing.Size(261, 56);
            this.tbarFTrajectoryFrequency.TabIndex = 4;
            this.tbarFTrajectoryFrequency.Value = 2;
            this.tbarFTrajectoryFrequency.ValueChanged += new System.EventHandler(this.tbarFTrajectoryFrequency_ValueChanged);
            // 
            // tbarFTrajectorySizeX
            // 
            this.tbarFTrajectorySizeX.Location = new System.Drawing.Point(8, 27);
            this.tbarFTrajectorySizeX.Maximum = 50;
            this.tbarFTrajectorySizeX.Name = "tbarFTrajectorySizeX";
            this.tbarFTrajectorySizeX.Size = new System.Drawing.Size(261, 56);
            this.tbarFTrajectorySizeX.TabIndex = 1;
            this.tbarFTrajectorySizeX.Value = 25;
            this.tbarFTrajectorySizeX.ValueChanged += new System.EventHandler(this.tbarFTrajectorySizeX_ValueChanged);
            // 
            // labelFTrajectorySizeX
            // 
            this.labelFTrajectorySizeX.AutoSize = true;
            this.labelFTrajectorySizeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.11F);
            this.labelFTrajectorySizeX.Location = new System.Drawing.Point(4, 4);
            this.labelFTrajectorySizeX.Name = "labelFTrajectorySizeX";
            this.labelFTrajectorySizeX.Size = new System.Drawing.Size(102, 20);
            this.labelFTrajectorySizeX.TabIndex = 0;
            this.labelFTrajectorySizeX.Text = "Размер по X";
            // 
            // tboxFVertexBox
            // 
            this.tboxFVertexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.13F);
            this.tboxFVertexBox.Location = new System.Drawing.Point(33, 492);
            this.tboxFVertexBox.Multiline = true;
            this.tboxFVertexBox.Name = "tboxFVertexBox";
            this.tboxFVertexBox.Size = new System.Drawing.Size(127, 129);
            this.tboxFVertexBox.TabIndex = 23;
            this.tboxFVertexBox.TextChanged += new System.EventHandler(this.tboxFVertexBox_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 712);
            this.Controls.Add(this.panelFControlArea);
            this.Controls.Add(this.pboxFWorkArea);
            this.Name = "frmMain";
            this.Text = "Гипоциклойда";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pboxFWorkArea)).EndInit();
            this.panelFControlArea.ResumeLayout(false);
            this.panelFControlArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFFigureBreatheRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFFigureSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectoryFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxFWorkArea;
        private System.Windows.Forms.Panel panelFControlArea;
        private System.Windows.Forms.Label labelFTrajectorySizeX;
        private System.Windows.Forms.TrackBar tbarFTrajectorySizeX;
        private System.Windows.Forms.TrackBar tbarFTrajectoryFrequency;
        private System.Windows.Forms.Label labelFTrajectorySizeXY;
        private System.Windows.Forms.Button btnFDotButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbarFFigureSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbarFFigureBreatheRate;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnFPboxColorButton;
        private System.Windows.Forms.Button btnFTrajectoryColorButton;
        private System.Windows.Forms.Button btnFFigureColorButton;
        private System.Windows.Forms.ColorDialog cdFCanvasColorDialog;
        private System.Windows.Forms.ColorDialog cdFTrajectoryColorDialog;
        private System.Windows.Forms.ColorDialog cdFFigureColorDialog;
        private System.Windows.Forms.Label lblFVertexALabel;
        private System.Windows.Forms.Label lblFVertexELabel;
        private System.Windows.Forms.Label lblFVertexDLabel;
        private System.Windows.Forms.Label lblFVertexCLabel;
        private System.Windows.Forms.Label lblFVertexBLabel;
        private System.Windows.Forms.Button btnFRedrawButton;
        private System.Windows.Forms.Button btnFRedrawDefaultButton;
        private System.Windows.Forms.Button btnFPasteButton;
        private System.Windows.Forms.Button btnFCopyButton;
        private MyTextBox tboxFVertexBox;
    }
}

