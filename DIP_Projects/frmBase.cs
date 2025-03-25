using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIP_Projects
{
    public partial class frmBase: Form
    {
        protected Bitmap _imgSource;
        protected Bitmap _imgResult;
        protected Bitmap _imgOriginal;
        public frmBase()
        {
            InitializeComponent();
            btnReset.Click += btnReset_Click;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Bitmap files |*.bmp| JPEG files|*.jpg| PNG file|*.png";
            openFileDialog.FileName = "";
            DialogResult r = openFileDialog.ShowDialog();
            if (r == DialogResult.OK && openFileDialog.FileName != "")
            {
                lblImgPath.Text = openFileDialog.FileName;
                _imgOriginal = new Bitmap(openFileDialog.FileName);
                _imgSource = new Bitmap(_imgOriginal);
                picSource.Image = _imgSource; 
                picSource.Refresh();

                _imgResult = new Bitmap(_imgSource); 
                picResult.Image = _imgResult;
                picResult.Refresh();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Bitmap files|*.bmp|JPEG files|*.jpg|PNG file|*.png";
            saveFileDialog.FileName = "";
            DialogResult r = saveFileDialog.ShowDialog();
            if (r == DialogResult.OK && saveFileDialog.FileName != "" && _imgResult != null)
            {
                _imgResult.Save(saveFileDialog.FileName);
            }
        }

        private void picSource_MouseMove(object sender, MouseEventArgs e)
        {
            txtX_source.Text = e.X.ToString();
            txtY_source.Text = e.Y.ToString();
            if (_imgSource == null)
                return;
            if (e.X < _imgSource.Width && e.Y < _imgSource.Height)
            {
                Color c = _imgSource.GetPixel(e.X, e.Y);
                txtRed_source.Text = c.R.ToString();
                txtGreen_source.Text = c.G.ToString();
                txtBlue_source.Text = c.B.ToString();
            }
        }

        private void picResult_MouseMove(object sender, MouseEventArgs e)
        {
            txtX_result.Text = e.X.ToString();
            txtY_result.Text = e.Y.ToString();
            if (_imgSource == null)
                return;
            if (e.X < _imgResult.Width && e.Y < _imgResult.Height)
            {
                Color c = _imgSource.GetPixel(e.X, e.Y);
                txtRed_result.Text = c.R.ToString();
                txtGreen_result.Text = c.G.ToString();
                txtBlue_result.Text = c.B.ToString();
            }
        }

        private Bitmap ConvertToGrayscale(Bitmap original)
        {
            Bitmap grayImage = new Bitmap(original.Width, original.Height);
            Rectangle rect = new Rectangle(0, 0, original.Width, original.Height);

            BitmapData originalData = original.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            BitmapData grayData = grayImage.LockBits(rect, ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            int bytes = originalData.Stride * originalData.Height;
            byte[] buffer = new byte[bytes];
            Marshal.Copy(originalData.Scan0, buffer, 0, bytes);

            for (int i = 0; i < buffer.Length; i += 3)
            {
                byte gray = (byte)(buffer[i] * 0.11 + buffer[i + 1] * 0.59 + buffer[i + 2] * 0.3);
                buffer[i] = buffer[i + 1] = buffer[i + 2] = gray;
            }

            Marshal.Copy(buffer, 0, grayData.Scan0, bytes);
            original.UnlockBits(originalData);
            grayImage.UnlockBits(grayData);

            return grayImage;
        }

        private void btnLoadConvo_Click(object sender, EventArgs e)
        {
            if (_imgSource == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _imgResult = ConvertToGrayscale(_imgSource);
            _imgSource = _imgResult;
            picSource.Image = _imgResult;
            picResult.Image = _imgResult;
        }

        private void btnReconvert_Click(object sender, EventArgs e)
        {
            if (_imgOriginal == null)
            {
                MessageBox.Show("Chưa có ảnh gốc để khôi phục!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _imgSource = new Bitmap(_imgOriginal);
            picSource.Image = _imgSource;
            picResult.Image = _imgSource;
        }

        protected virtual void btnReset_Click(object sender, EventArgs e)
        {
            if (_imgSource != null)
            {
                _imgResult = new Bitmap(_imgSource);
                picResult.Image = _imgResult;
                picResult.Refresh();
            }
        }
    }
}
