using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIP_Projects
{
    public partial class frmBase: Form
    {
        protected Bitmap _imgSource;
        protected Bitmap _imgResult;
        public frmBase()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Bitmap files |*.bmp| JPEG files|*.jpg| PNG file|*.png";
            openFileDialog.FileName = "";
            DialogResult r = openFileDialog.ShowDialog();
            if (r == DialogResult.OK && openFileDialog.FileName != "")
            {
                lblImgPath.Text = openFileDialog.FileName;
                _imgSource = new Bitmap(openFileDialog.FileName); // read bmp data
                picSource.Image = _imgSource; // Show bitmap in picturebox
                picSource.Refresh();

                _imgResult = new Bitmap(_imgSource); // Clone original bitmap image to result
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
    }
}
