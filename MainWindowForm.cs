﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KGRastr
{
    public partial class MainWindowForm : Form
    {
        public struct TransInfo
        {
            public string Label;
            public int min, max, current;
            public getValue getv;
            public Transformation tr;
        }
        public delegate double getValue(int trackValue);

        private TransInfo brigthnessInfo;
        private TransInfo contrastInfo;

        public Rectangle _activeImageArea, _activeBoxArea;
        public Point zeroPoint = new Point(0, 0);
        private int _contrastBaseValue;
        private TrueBitmap _image, _clearImage, _reserve;
        private bool _isSelection = false;
        public MainWindowForm()
        {
            InitializeComponent();
            brigthnessInfo = new TransInfo();
            brigthnessInfo.tr = new LightTransformation(1);
            brigthnessInfo.Label = "Яркость";
            brigthnessInfo.max = 255;
            brigthnessInfo.min = -255;
            brigthnessInfo.current = 0;
            brigthnessInfo.getv = (int x) => x;
            int maxTrackValue = 1000;
            contrastInfo = new TransInfo();
            contrastInfo.tr = new ContrastTransformation(1);
            contrastInfo.Label = "Контрастность";
            contrastInfo.max = 1000;
            contrastInfo.min = 0;
            contrastInfo.current = 1;
            contrastInfo.getv = (int x) => (double) (x * 10)/ contrastInfo.max;

        }

        void SetImageArea()
        {
            float kx = (float)_image.Width / ImageBox.Width;
            float ky = (float)_image.Height / ImageBox.Height;
            int[] bar = new int[256];
            _activeImageArea.X = (int)(_activeBoxArea.X * kx);
            _activeImageArea.Y = (int)(_activeBoxArea.Y * ky);
            _activeImageArea.Width = Math.Min((int)(_activeBoxArea.Width * kx), _image.Width);
            _activeImageArea.Height = Math.Min((int)(_activeBoxArea.Height * ky), _image.Height);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _contrastBaseValue = ContractTrackBar.Value;
            ContrastValue.Text = ((float)ContractTrackBar.Value / 100).ToString();
        }

        private void UploadImage(object sender, EventArgs e)
        {

            openImageFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _clearImage = new TrueBitmap(new Bitmap(openImageFileDialog.FileName));
                    _image = new TrueBitmap(_clearImage.Bitmap);
                    _activeBoxArea = ImageBox.DisplayRectangle;
                    SetImageArea();
                    Update();
                }
                catch
                {
                     MessageBox.Show("Не удалось загрузить файл",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void Update()
        {
            this.ImageBox.Image = _image.Bitmap;
            histogramBox.Refresh();
            Invalidate();
        }

        private void histogramBox_Paint(object sender, PaintEventArgs e)
        {
            if (_image != null)
                Rastr.DrawBar(e.Graphics, _image, _activeImageArea);
        }

        private void LightTrackBar_Scroll(object sender, EventArgs e)
        {
            LightValue.Text = LightTrackBar.Value.ToString();
        }

        private void ContractTrackBar_Scroll(object sender, EventArgs e)
        {
            ContrastValue.Text = ((float)ContractTrackBar.Value / 100).ToString();
        }

        private void RollbackChanges_Click(object sender, EventArgs e)
        {
            _image.Dispose();
            _image = new TrueBitmap(_clearImage.Bitmap);
            Update();
        }

        private void binaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transformation tr = new Binarization(128);
            tr.Execute(_image, _activeImageArea);
            Update();
        }

        private void shadesOfGrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transformation tr = new ShadowOfGray();
            tr.Execute(_image, _activeImageArea);
            Update();
        }

        private void nagetiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transformation tr = new Negative();
            tr.Execute(_image, _activeImageArea);
            Update();
        }

        private void coloringToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        //on mouseMove event
        private void ChangeArea(object sender, MouseEventArgs e)
        {
            if (_isSelection)
            {
                int x = Math.Clamp(e.Location.X, 0, ImageBox.DisplayRectangle.Width);
                int y = Math.Clamp(e.Location.Y, 0, ImageBox.DisplayRectangle.Height);
                _activeBoxArea.X = Math.Min(zeroPoint.X, x);
                _activeBoxArea.Y = Math.Min(zeroPoint.Y, y);
                _activeBoxArea.Width = Math.Abs(zeroPoint.X - x);
                _activeBoxArea.Height = Math.Abs(zeroPoint.Y - y);
                SetImageArea();
                Update();
            }
        }

        private void DrawSelectedRectangleOnPictureBox(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.AntiqueWhite), _activeBoxArea);
        }

        private void ImageBox_SelectAll(object sender, EventArgs e)
        {
            _activeBoxArea = ImageBox.DisplayRectangle;
            SetImageArea();
            Update();
        }

        private void ImageBox_MouseDown(object sender, MouseEventArgs e)
        {
            _isSelection = true;
            zeroPoint = e.Location;
        }
        

        private void TransformWindow(TransInfo info)
        {
            _reserve = new TrueBitmap(_image.Bitmap);
            OneTrackBar choose = new OneTrackBar(this, info);
            var result = choose.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                _image.Dispose();
                _image = new TrueBitmap(_reserve.Bitmap);
            }
            _reserve.Dispose();
            Update();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isSelection = false;
            SetImageArea();
            ImageBox.Invalidate();
        }

        private void ChangeBrightnessWindow(object sender, EventArgs e)
        {
            TransformWindow(brigthnessInfo);
        }
        private void ChangeContrastWindow(object sender, EventArgs e)
        {
            TransformWindow(contrastInfo);
        }

        public void transform(Transformation trans)
        {
            trans.Execute(_image,_activeImageArea);
            Update();
        }
        public void transformCopy(Transformation trans)
        {
            _image.Dispose();
            _image = new TrueBitmap(_reserve.Bitmap);
            trans.Execute(_image,_activeImageArea);
            Update();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            Transformation tr = new LightTransformation(Int32.Parse(LightValue.Text));
            tr.Execute(_image, _activeImageArea);
            LightTrackBar.Value = 0;
            LightValue.Text = LightTrackBar.Value.ToString();
            //
            tr = new ContrastTransformation(Double.Parse(ContrastValue.Text));
            tr.Execute(_image, _activeImageArea);
            ContractTrackBar.Value = 100;
            ContractTrackBar.Text = "1";
            Update();
        }
    }
}