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
            this.btnFDotButton = new System.Windows.Forms.Button();
            this.labelFTrajectorySizeXY = new System.Windows.Forms.Label();
            this.tbarFTrajectoryFrequency = new System.Windows.Forms.TrackBar();
            this.labelFTrajectorySizeY = new System.Windows.Forms.Label();
            this.tbarFTrajectorySizeY = new System.Windows.Forms.TrackBar();
            this.tbarFTrajectorySizeX = new System.Windows.Forms.TrackBar();
            this.labelFTrajectorySizeX = new System.Windows.Forms.Label();
            this.btnFDotButtonStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFWorkArea)).BeginInit();
            this.panelFControlArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectoryFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeX)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxFWorkArea
            // 
            this.pboxFWorkArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pboxFWorkArea.Location = new System.Drawing.Point(0, 1);
            this.pboxFWorkArea.Name = "pboxFWorkArea";
            this.pboxFWorkArea.Size = new System.Drawing.Size(513, 449);
            this.pboxFWorkArea.TabIndex = 0;
            this.pboxFWorkArea.TabStop = false;
            this.pboxFWorkArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pboxFWorkArea_Paint);
            // 
            // panelFControlArea
            // 
            this.panelFControlArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFControlArea.Controls.Add(this.btnFDotButtonStop);
            this.panelFControlArea.Controls.Add(this.btnFDotButton);
            this.panelFControlArea.Controls.Add(this.labelFTrajectorySizeXY);
            this.panelFControlArea.Controls.Add(this.tbarFTrajectoryFrequency);
            this.panelFControlArea.Controls.Add(this.labelFTrajectorySizeY);
            this.panelFControlArea.Controls.Add(this.tbarFTrajectorySizeY);
            this.panelFControlArea.Controls.Add(this.tbarFTrajectorySizeX);
            this.panelFControlArea.Controls.Add(this.labelFTrajectorySizeX);
            this.panelFControlArea.Location = new System.Drawing.Point(519, 1);
            this.panelFControlArea.Name = "panelFControlArea";
            this.panelFControlArea.Size = new System.Drawing.Size(274, 449);
            this.panelFControlArea.TabIndex = 1;
            // 
            // btnFDotButton
            // 
            this.btnFDotButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFDotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.btnFDotButton.Location = new System.Drawing.Point(0, 245);
            this.btnFDotButton.Name = "btnFDotButton";
            this.btnFDotButton.Padding = new System.Windows.Forms.Padding(5);
            this.btnFDotButton.Size = new System.Drawing.Size(100, 50);
            this.btnFDotButton.TabIndex = 6;
            this.btnFDotButton.Text = "Старт";
            this.btnFDotButton.UseVisualStyleBackColor = true;
            this.btnFDotButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnFDotButton_MouseDown);
            // 
            // labelFTrajectorySizeXY
            // 
            this.labelFTrajectorySizeXY.AutoSize = true;
            this.labelFTrajectorySizeXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.labelFTrajectorySizeXY.Location = new System.Drawing.Point(4, 173);
            this.labelFTrajectorySizeXY.Name = "labelFTrajectorySizeXY";
            this.labelFTrajectorySizeXY.Size = new System.Drawing.Size(81, 20);
            this.labelFTrajectorySizeXY.TabIndex = 5;
            this.labelFTrajectorySizeXY.Text = "Частота";
            // 
            // tbarFTrajectoryFrequency
            // 
            this.tbarFTrajectoryFrequency.Location = new System.Drawing.Point(7, 196);
            this.tbarFTrajectoryFrequency.Maximum = 50;
            this.tbarFTrajectoryFrequency.Minimum = 1;
            this.tbarFTrajectoryFrequency.Name = "tbarFTrajectoryFrequency";
            this.tbarFTrajectoryFrequency.Size = new System.Drawing.Size(261, 56);
            this.tbarFTrajectoryFrequency.TabIndex = 4;
            this.tbarFTrajectoryFrequency.Value = 2;
            // 
            // labelFTrajectorySizeY
            // 
            this.labelFTrajectorySizeY.AutoSize = true;
            this.labelFTrajectorySizeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.labelFTrajectorySizeY.Location = new System.Drawing.Point(4, 94);
            this.labelFTrajectorySizeY.Name = "labelFTrajectorySizeY";
            this.labelFTrajectorySizeY.Size = new System.Drawing.Size(220, 20);
            this.labelFTrajectorySizeY.TabIndex = 3;
            this.labelFTrajectorySizeY.Text = "Размер по Y (амплитуда)";
            // 
            // tbarFTrajectorySizeY
            // 
            this.tbarFTrajectorySizeY.Location = new System.Drawing.Point(8, 117);
            this.tbarFTrajectorySizeY.Maximum = 50;
            this.tbarFTrajectorySizeY.Name = "tbarFTrajectorySizeY";
            this.tbarFTrajectorySizeY.Size = new System.Drawing.Size(261, 56);
            this.tbarFTrajectorySizeY.TabIndex = 2;
            this.tbarFTrajectorySizeY.Value = 25;
            // 
            // tbarFTrajectorySizeX
            // 
            this.tbarFTrajectorySizeX.Location = new System.Drawing.Point(8, 27);
            this.tbarFTrajectorySizeX.Maximum = 50;
            this.tbarFTrajectorySizeX.Name = "tbarFTrajectorySizeX";
            this.tbarFTrajectorySizeX.Size = new System.Drawing.Size(261, 56);
            this.tbarFTrajectorySizeX.TabIndex = 1;
            this.tbarFTrajectorySizeX.Value = 25;
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
            // btnFDotButtonStop
            // 
            this.btnFDotButtonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F);
            this.btnFDotButtonStop.Location = new System.Drawing.Point(107, 245);
            this.btnFDotButtonStop.Name = "btnFDotButtonStop";
            this.btnFDotButtonStop.Size = new System.Drawing.Size(104, 49);
            this.btnFDotButtonStop.TabIndex = 7;
            this.btnFDotButtonStop.Text = "Стоп";
            this.btnFDotButtonStop.UseVisualStyleBackColor = true;
            this.btnFDotButtonStop.Click += new System.EventHandler(this.btnFDotButtonStop_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFControlArea);
            this.Controls.Add(this.pboxFWorkArea);
            this.Name = "frmMain";
            this.Text = "Синусойда";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxFWorkArea)).EndInit();
            this.panelFControlArea.ResumeLayout(false);
            this.panelFControlArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectoryFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFTrajectorySizeX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxFWorkArea;
        private System.Windows.Forms.Panel panelFControlArea;
        private System.Windows.Forms.Label labelFTrajectorySizeX;
        private System.Windows.Forms.TrackBar tbarFTrajectorySizeX;
        private System.Windows.Forms.Label labelFTrajectorySizeY;
        private System.Windows.Forms.TrackBar tbarFTrajectorySizeY;
        private System.Windows.Forms.TrackBar tbarFTrajectoryFrequency;
        private System.Windows.Forms.Label labelFTrajectorySizeXY;
        private System.Windows.Forms.Button btnFDotButton;
        private System.Windows.Forms.Button btnFDotButtonStop;
    }
}

