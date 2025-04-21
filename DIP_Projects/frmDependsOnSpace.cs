using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIP_Projects
{
    public partial class frmDependsOnSpace: frmBase
    {
        public frmDependsOnSpace()
        {
            InitializeComponent();
        }

        private readonly int[,] kernelH1 =
        {
            { -1, -1, -1 },
            {  0,  0,  0 },
            {  1,  1,  1 }
        };

        private readonly int[,] kernelH2 =
        {
            { -1,  0,  1 },
            { -1,  0,  1 },
            { -1,  0,  1 }
        };

        private readonly int[,] kernelH3 =
        {
            { 0, 1, 1 },
            { -1, 0, 1 },
            { -1, -1, 0 }
        };

        private readonly int[,] kernelH4 =
{
            { -1, -1, 0 },
            { -1, 0, 1 },
            { 0, 1, 1 }
        };

        private readonly int[,] kernelSx =
        {
            { -1,  0,  1 },
            { -2,  0,  2 },
            { -1,  0,  1 }
        };

        private readonly int[,] kernelSy =
                {
            { -1, -2, -1 },
            {  0,  0,  0 },
            {  1,  2,  1 }
        };

        private Bitmap ApplyConvolution(Bitmap img, int[,] kernel)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap result = new Bitmap(width, height);

            int kernelSize = 3;
            int offset = kernelSize / 2;

            for (int x = offset; x < width - offset; x++)
            {
                for (int y = offset; y < height - offset; y++)
                {
                    int sum = 0;

                    for (int i = 0; i < kernelSize; i++)
                    {
                        for (int j = 0; j < kernelSize; j++)
                        {
                            int pixelX = x + i - offset;
                            int pixelY = y + j - offset;
                            Color pixel = img.GetPixel(pixelX, pixelY);
                            sum += pixel.R * kernel[i, j];
                        }
                    }

                    sum = Math.Max(0, Math.Min(255, sum));
                    result.SetPixel(x, y, Color.FromArgb(sum, sum, sum));
                }
            }
            return result;
        }

        private void btnVertical_Click(object sender, EventArgs e)
        {
            if (_imgSource == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _imgResult = ApplyConvolution(_imgSource, kernelH2);
            picResult.Image = _imgResult;
        }

        private void btnHorizontal_Click(object sender, EventArgs e)
        {
            if (_imgSource == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _imgResult = ApplyConvolution(_imgSource, kernelH1);
            picResult.Image = _imgResult;
        }

        private void btnLeftPath_Click(object sender, EventArgs e)
        {
            if (_imgSource == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _imgResult = ApplyConvolution(_imgSource, kernelH3);
            picResult.Image = _imgResult;
        }

        private void btnRightPath_Click(object sender, EventArgs e)
        {
            if (_imgSource == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _imgResult = ApplyConvolution(_imgSource, kernelH4);
            picResult.Image = _imgResult;
        }

        private void btnConvoSy_Click(object sender, EventArgs e)
        {
            if (_imgSource == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _imgResult = ApplyConvolution(_imgSource, kernelSy);
            picResult.Image = _imgResult;
        }

        private void btnConvoSx_Click(object sender, EventArgs e)
        {
            if (_imgSource == null)
            {
                MessageBox.Show("Vui lòng chọn ảnh trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _imgResult = ApplyConvolution(_imgSource, kernelSx);
            picResult.Image = _imgResult;
        }

        private Bitmap ApplyMedianFilter(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap result = new Bitmap(width, height);

            int kernelSize = 3;
            int offset = kernelSize / 2;

            for (int x = offset; x < width - offset; x++)
            {
                for (int y = offset; y < height - offset; y++)
                {
                    List<int> pixelValues = new List<int>();

                    for (int i = -offset; i <= offset; i++)
                    {
                        for (int j = -offset; j <= offset; j++)
                        {
                            Color pixel = img.GetPixel(x + i, y + j);
                            int gray = (pixel.R + pixel.G + pixel.B) / 3;
                            pixelValues.Add(gray);
                        }
                    }

                    pixelValues.Sort();

                    int medianValue = pixelValues[pixelValues.Count / 2];

                    result.SetPixel(x, y, Color.FromArgb(medianValue, medianValue, medianValue));
                }
            }

            return result;
        }

        private void btnFilterMid_Click(object sender, EventArgs e)
        {
            if (_imgSource != null)
            {
                _imgResult = ApplyMedianFilter(_imgSource);
                picResult.Image = _imgResult;
            }
        }

        private Bitmap ApplyMeanFilter(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap result = new Bitmap(width, height);

            int kernelSize = 3;
            int offset = kernelSize / 2;

            for (int x = offset; x < width - offset; x++)
            {
                for (int y = offset; y < height - offset; y++)
                {
                    int sum = 0;
                    int count = 0;

                    for (int i = -offset; i <= offset; i++)
                    {
                        for (int j = -offset; j <= offset; j++)
                        {
                            Color pixel = img.GetPixel(x + i, y + j);
                            int gray = (pixel.R + pixel.G + pixel.B) / 3;
                            sum += gray;
                            count++;
                        }
                    }

                    int meanValue = sum / count;

                    result.SetPixel(x, y, Color.FromArgb(meanValue, meanValue, meanValue));
                }
            }

            return result;
        }

        private void btnFilterMean_Click(object sender, EventArgs e)
        {
            if (_imgSource != null)
            {
                _imgResult = ApplyMeanFilter(_imgSource);
                picResult.Image = _imgResult;
            }
        }

        private Bitmap ApplyKNearestMeanFilter(Bitmap img, int k, int threshold = 0)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap result = new Bitmap(width, height);

            int kernelSize = 3; 
            int offset = kernelSize / 2;

            for (int x = offset; x < width - offset; x++)
            {
                for (int y = offset; y < height - offset; y++)
                {
                    List<int> neighbors = new List<int>();
                    int centerPixel = img.GetPixel(x, y).R;

                    for (int i = -offset; i <= offset; i++)
                    {
                        for (int j = -offset; j <= offset; j++)
                        {
                            int gray = img.GetPixel(x + i, y + j).R;
                            neighbors.Add(gray);
                        }
                    }

                    neighbors = neighbors.OrderBy(p => Math.Abs(p - centerPixel)).ToList();

                    int meanValue = (int)neighbors.Take(k).Average();

                    if (Math.Abs(centerPixel - meanValue) > threshold)
                    {
                        result.SetPixel(x, y, Color.FromArgb(meanValue, meanValue, meanValue));
                    }
                    else
                    {
                        result.SetPixel(x, y, Color.FromArgb(centerPixel, centerPixel, centerPixel));
                    }
                }
            }

            return result;
        }

        private void btnFilterMidByNearK_Click(object sender, EventArgs e)
        {
            if (_imgSource != null)
            {
                int k = Convert.ToInt32(txtKValue.Text);
                int threshold = Convert.ToInt32(txtThreshold.Text);

                _imgResult = ApplyKNearestMeanFilter(_imgSource, k, threshold);
                picResult.Image = _imgResult;
            }
        }

        private Bitmap ApplyLocalMeanEdgeDetection(Bitmap img, int windowSize, int threshold)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap result = new Bitmap(width, height);

            int offset = windowSize / 2;

            for (int x = offset; x < width - offset; x++)
            {
                for (int y = offset; y < height - offset; y++)
                {
                    int sum = 0;
                    int count = 0;

                    for (int i = -offset; i <= offset; i++)
                    {
                        for (int j = -offset; j <= offset; j++)
                        {
                            Color pixel = img.GetPixel(x + i, y + j);
                            sum += pixel.R;
                            count++;
                        }
                    }
                    int meanGray = sum / count;

                    Color centerPixel = img.GetPixel(x, y);
                    int gray = centerPixel.R;
                    if (Math.Abs(gray - meanGray) > threshold)
                    {
                        result.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        result.SetPixel(x, y, Color.Black);
                    }
                }
            }
            return result;
        }

        private void btnLocalAve_Click(object sender, EventArgs e)
        {
            if (_imgSource != null)
            {
                _imgResult = ApplyLocalMeanEdgeDetection(_imgSource, 3, 15);
                picResult.Image = _imgResult;
            }
        }
    }
}
