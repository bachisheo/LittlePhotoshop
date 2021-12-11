
namespace KGRastr
{
    partial class MainWindowForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.загрузитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьИзмененияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.constrasrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nagetiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shadesOfGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.histogramBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ContrastValue = new System.Windows.Forms.TextBox();
            this.ContractTrackBar = new System.Windows.Forms.TrackBar();
            this.updateButton = new System.Windows.Forms.Button();
            this.LightValue = new System.Windows.Forms.TextBox();
            this.LightTrackBar = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьФайлToolStripMenuItem,
            this.отменитьИзмененияToolStripMenuItem,
            this.colorCorrectionToolStripMenuItem,
            this.coloringToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1428, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // загрузитьФайлToolStripMenuItem
            // 
            this.загрузитьФайлToolStripMenuItem.Name = "загрузитьФайлToolStripMenuItem";
            this.загрузитьФайлToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.загрузитьФайлToolStripMenuItem.Text = "Загрузить файл";
            this.загрузитьФайлToolStripMenuItem.Click += new System.EventHandler(this.UploadImage);
            // 
            // отменитьИзмененияToolStripMenuItem
            // 
            this.отменитьИзмененияToolStripMenuItem.Name = "отменитьИзмененияToolStripMenuItem";
            this.отменитьИзмененияToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.отменитьИзмененияToolStripMenuItem.Text = "Отменить изменения";
            this.отменитьИзмененияToolStripMenuItem.Click += new System.EventHandler(this.RollbackChanges_Click);
            // 
            // colorCorrectionToolStripMenuItem
            // 
            this.colorCorrectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brightnessToolStripMenuItem,
            this.constrasrToolStripMenuItem});
            this.colorCorrectionToolStripMenuItem.Name = "colorCorrectionToolStripMenuItem";
            this.colorCorrectionToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.colorCorrectionToolStripMenuItem.Text = "Цветокоррекция";
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.brightnessToolStripMenuItem.Text = "Яркость";
            this.brightnessToolStripMenuItem.Click += new System.EventHandler(this.ChangeBrightnessWindow);
            // 
            // constrasrToolStripMenuItem
            // 
            this.constrasrToolStripMenuItem.Name = "constrasrToolStripMenuItem";
            this.constrasrToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.constrasrToolStripMenuItem.Text = "Контраст";
            this.constrasrToolStripMenuItem.Click += new System.EventHandler(this.ChangeContrastWindow);
            // 
            // coloringToolStripMenuItem
            // 
            this.coloringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryToolStripMenuItem,
            this.nagetiveToolStripMenuItem,
            this.shadesOfGrayToolStripMenuItem});
            this.coloringToolStripMenuItem.Name = "coloringToolStripMenuItem";
            this.coloringToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.coloringToolStripMenuItem.Text = "Изменение цветности";
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.binaryToolStripMenuItem.Text = "Бинаризация";
            this.binaryToolStripMenuItem.Click += new System.EventHandler(this.binaryToolStripMenuItem_Click);
            // 
            // nagetiveToolStripMenuItem
            // 
            this.nagetiveToolStripMenuItem.Name = "nagetiveToolStripMenuItem";
            this.nagetiveToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.nagetiveToolStripMenuItem.Text = "Негатив";
            this.nagetiveToolStripMenuItem.Click += new System.EventHandler(this.nagetiveToolStripMenuItem_Click);
            // 
            // shadesOfGrayToolStripMenuItem
            // 
            this.shadesOfGrayToolStripMenuItem.Name = "shadesOfGrayToolStripMenuItem";
            this.shadesOfGrayToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.shadesOfGrayToolStripMenuItem.Text = "Оттенки серого";
            this.shadesOfGrayToolStripMenuItem.Click += new System.EventHandler(this.shadesOfGrayToolStripMenuItem_Click);
            // 
            // openImageFileDialog
            // 
            this.openImageFileDialog.FileName = "openImageFileDialog";
            // 
            // histogramBox
            // 
            this.histogramBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.histogramBox.Location = new System.Drawing.Point(6, 26);
            this.histogramBox.Name = "histogramBox";
            this.histogramBox.Size = new System.Drawing.Size(539, 225);
            this.histogramBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.histogramBox.TabIndex = 2;
            this.histogramBox.TabStop = false;
            this.histogramBox.Paint += new System.Windows.Forms.PaintEventHandler(this.histogramBox_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.histogramBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 261);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Гистограмма яркости";
            // 
            // ImageBox
            // 
            this.ImageBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ImageBox.Location = new System.Drawing.Point(16, 26);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(819, 456);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBox.TabIndex = 1;
            this.ImageBox.TabStop = false;
            this.ImageBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawSelectedRectangleOnPictureBox);
            this.ImageBox.DoubleClick += new System.EventHandler(this.ImageBox_SelectAll);
            this.ImageBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageBox_MouseDown);
            this.ImageBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChangeArea);
            this.ImageBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ImageBox);
            this.groupBox2.Location = new System.Drawing.Point(569, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 515);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ContrastValue);
            this.groupBox3.Controls.Add(this.ContractTrackBar);
            this.groupBox3.Controls.Add(this.updateButton);
            this.groupBox3.Controls.Add(this.LightValue);
            this.groupBox3.Controls.Add(this.LightTrackBar);
            this.groupBox3.Location = new System.Drawing.Point(12, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 214);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цветокоррекция";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Констрастность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Яркость";
            // 
            // ContrastValue
            // 
            this.ContrastValue.Location = new System.Drawing.Point(452, 100);
            this.ContrastValue.MaxLength = 4;
            this.ContrastValue.Name = "ContrastValue";
            this.ContrastValue.Size = new System.Drawing.Size(56, 27);
            this.ContrastValue.TabIndex = 5;
            this.ContrastValue.Text = "0";
            // 
            // ContractTrackBar
            // 
            this.ContractTrackBar.Location = new System.Drawing.Point(15, 100);
            this.ContractTrackBar.Maximum = 1000;
            this.ContractTrackBar.Name = "ContractTrackBar";
            this.ContractTrackBar.Size = new System.Drawing.Size(431, 56);
            this.ContractTrackBar.TabIndex = 4;
            this.ContractTrackBar.TickFrequency = 0;
            this.ContractTrackBar.Value = 100;
            this.ContractTrackBar.Scroll += new System.EventHandler(this.ContractTrackBar_Scroll);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(432, 162);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(104, 29);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Применить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // LightValue
            // 
            this.LightValue.Location = new System.Drawing.Point(452, 54);
            this.LightValue.MaxLength = 4;
            this.LightValue.Name = "LightValue";
            this.LightValue.Size = new System.Drawing.Size(56, 27);
            this.LightValue.TabIndex = 2;
            this.LightValue.Text = "0";
            // 
            // LightTrackBar
            // 
            this.LightTrackBar.Location = new System.Drawing.Point(15, 46);
            this.LightTrackBar.Maximum = 255;
            this.LightTrackBar.Minimum = -255;
            this.LightTrackBar.Name = "LightTrackBar";
            this.LightTrackBar.Size = new System.Drawing.Size(431, 56);
            this.LightTrackBar.TabIndex = 0;
            this.LightTrackBar.Scroll += new System.EventHandler(this.LightTrackBar_Scroll);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1428, 565);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindowForm";
            this.Text = "MainWindowForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histogramBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem загрузитьФайлToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openImageFileDialog;
        private System.Windows.Forms.PictureBox histogramBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem отменитьИзмененияToolStripMenuItem;
        private System.Windows.Forms.TrackBar LightTrackBar;
        private System.Windows.Forms.TextBox LightValue;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ContrastValue;
        private System.Windows.Forms.TrackBar ContractTrackBar;
        private System.Windows.Forms.ToolStripMenuItem coloringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nagetiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shadesOfGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem constrasrToolStripMenuItem;
    }
}

