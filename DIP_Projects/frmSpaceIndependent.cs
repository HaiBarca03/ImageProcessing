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
    public partial class frmSpaceIndependent: frmBase
    {
        public frmSpaceIndependent()
        {
            InitializeComponent();
        }
        private Bitmap ApplyBunching(Bitmap img, int bunchSize)
        {
            Bitmap result = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Color pixel = img.GetPixel(x, y);
                    int newGray = (pixel.R / bunchSize) * bunchSize;
                    newGray = Math.Min(255, newGray);
                    result.SetPixel(x, y, Color.FromArgb(newGray, newGray, newGray));
                }
            }
            return result;
        }

        private void btnBundle_Click(object sender, EventArgs e)
        {
            if (_imgSource != null)
            {
                int bunchSize = Convert.ToInt32(txtBunchSize.Text);
                _imgResult = ApplyBunching(_imgSource, bunchSize);
                picResult.Image = _imgResult;
            }
        }

        private byte FindThreshold(Bitmap img, byte threshold = 2)
        {
            byte previousThreshold = 128;
            byte newThreshold = 0;

            while (true)
            {
                int sumLow = 0, countLow = 0;
                int sumHigh = 0, countHigh = 0;

                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        Color pixel = img.GetPixel(x, y);
                        if (pixel.R > previousThreshold)
                        {
                            sumHigh += pixel.R;
                            countHigh++;
                        }
                        else
                        {
                            sumLow += pixel.R;
                            countLow++;
                        }
                    }
                }

                if (countLow == 0) countLow = 1;
                if (countHigh == 0) countHigh = 1;

                newThreshold = (byte)((sumHigh / countHigh + sumLow / countLow) / 2);

                if (Math.Abs(newThreshold - previousThreshold) < threshold)
                    break;
                else
                    previousThreshold = newThreshold;
            }

            return previousThreshold;
        }

        private Bitmap thresholdSeparation(Bitmap source, int threshold)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixelColor = source.GetPixel(x, y).R > threshold
                        ? Color.White
                        : Color.Black;

                    result.SetPixel(x, y, pixelColor);
                }
            }

            return result;
        }

        private void btnAutoThreshold_Click(object sender, EventArgs e)
        {
            byte threshold = FindThreshold(_imgSource);
            _imgResult = thresholdSeparation(_imgSource, threshold);
            picResult.Image = _imgResult;

            trbC.Value = threshold;
            txtC.Text = threshold.ToString();
        }

        private int GetBackgroundSymmetryThreshold(Bitmap img, double percentage = 95)
        {
            int[] histogram = new int[256];
            int totalPixels = img.Width * img.Height;

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    int gray = img.GetPixel(x, y).R;
                    histogram[gray]++;
                }
            }

            int maxp = 0;
            for (int i = 1; i < 256; i++)
            {
                if (histogram[i] > histogram[maxp])
                {
                    maxp = i;
                }
            }

            int thresholdP = 0;
            int sum = 0;
            int target = (int)(totalPixels * (percentage / 100.0));

            for (int i = maxp; i < 256; i++)
            {
                sum += histogram[i];
                if (sum >= target)
                {
                    thresholdP = i;
                    break;
                }
            }

            int threshold = maxp - (thresholdP - maxp);
            threshold = Math.Max(0, Math.Min(255, threshold));

            return threshold;
        }

        private Bitmap ApplyBackgroundSymmetryThreshold(Bitmap img, double percentage = 95)
        {
            int threshold = GetBackgroundSymmetryThreshold(img, percentage);
            Bitmap result = new Bitmap(img.Width, img.Height);

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    int gray = img.GetPixel(x, y).R;
                    int newColor = (gray <= threshold) ? 0 : 255;
                    result.SetPixel(x, y, Color.FromArgb(newColor, newColor, newColor));
                }
            }

            return result;
        }
        private void btnBackgroundSymmetry_Click(object sender, EventArgs e)
        {
            if (_imgSource != null)
            {
                _imgResult = ApplyBackgroundSymmetryThreshold(_imgSource);
                picResult.Image = _imgResult;
            }
        }

        protected override void btnReset_Click(object sender, EventArgs e)
        {
            base.btnReset_Click(sender, e);
            txtC.Text = "0"; 
        }

        private void trbC_ValueChanged_1(object sender, EventArgs e)
        {
            if (cbBrightness.Checked)
            {
                txtC.Text = trbC.Value.ToString();
                if (_imgSource == null)
                    return;
                int C = trbC.Value;
                Color color1, color2;
                for (int x = 0; x < _imgSource.Width; x++)
                    for (int y = 0; y < _imgSource.Height; y++)
                    {
                        color1 = _imgSource.GetPixel(x, y);
                        if (color1.R + C > 255)
                            color2 = Color.FromArgb(255, 255, 255);
                        else if (color1.R + C < 0)
                            color2 = Color.FromArgb(0, 0, 0);
                        else
                            color2 = Color.FromArgb(color1.R + C, color1.R + C, color1.R + C);

                        _imgResult.SetPixel(x, y, color2);
                    }

                picResult.Refresh();
            }
            else if (cbThreshold.Checked)
            {
                txtC.Text = trbC.Value.ToString();
                int thres = trbC.Value;
                _imgResult = thresholdSeparation(_imgSource, thres);
                picResult.Image = _imgResult;
                picResult.Refresh();
            } else
            {
                MessageBox.Show("Bạn hãy chọn thuật toán trước khi trượt");
            }
        }

        private Bitmap ApplyHistogramEqualization(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            int totalPixels = width * height;

            int[] histogram = new int[256];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int gray = img.GetPixel(x, y).R;
                    histogram[gray]++;
                }
            }

            int[] cumulativeHistogram = new int[256];
            cumulativeHistogram[0] = histogram[0];
            for (int i = 1; i < 256; i++)
            {
                cumulativeHistogram[i] = cumulativeHistogram[i - 1] + histogram[i];
            }

            int[] newGrayLevels = new int[256];
            double TB = totalPixels / 256.0; 
            for (int i = 0; i < 256; i++)
            {
                newGrayLevels[i] = Math.Max(0, (int)Math.Round(cumulativeHistogram[i] / TB) - 1);
            }

            Bitmap result = new Bitmap(width, height);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int oldGray = img.GetPixel(x, y).R;
                    int newGray = newGrayLevels[oldGray];
                    result.SetPixel(x, y, Color.FromArgb(newGray, newGray, newGray));
                }
            }
            return result;
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            if (_imgSource != null)
            {
                _imgResult = ApplyHistogramEqualization(_imgSource);
                picResult.Image = _imgResult;
            }
        }

        private Bitmap ApplyContrastStretching(Bitmap img)
        {
            var (aLow, aHigh) = GetMinMaxIntensity(img);
            int width = img.Width;
            int height = img.Height;
            Bitmap result = new Bitmap(width, height);

            int L = 255; 

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color originalColor = img.GetPixel(x, y);
                    int gray = originalColor.R;

                    int newGray;
                    if (gray < aLow)
                    {
                        newGray = 0;
                    }
                    else if (gray > aHigh)
                    {
                        newGray = L;
                    }
                    else
                    {
                        newGray = (L * (gray - aLow)) / (aHigh - aLow);
                    }

                    result.SetPixel(x, y, Color.FromArgb(newGray, newGray, newGray));
                }
            }
            return result;
        }

        private (int, int) GetMinMaxIntensity(Bitmap img)
        {
            int minIntensity = 255;
            int maxIntensity = 0;

            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    int gray = img.GetPixel(x, y).R;
                    if (gray < minIntensity) minIntensity = gray;
                    if (gray > maxIntensity) maxIntensity = gray;
                }
            }
            return (minIntensity, maxIntensity);
        }

        private void btnContrastStretching_Click(object sender, EventArgs e)
        {
            if (_imgSource != null)
            {
                _imgResult = ApplyContrastStretching(_imgSource);
                picResult.Image = _imgResult;
            }
        }

        private Bitmap ApplyNegativeEffect(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            Bitmap negativeImg = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixel = img.GetPixel(x, y);
                    int invertedR = 255 - pixel.R;
                    int invertedG = 255 - pixel.G;
                    int invertedB = 255 - pixel.B;

                    negativeImg.SetPixel(x, y, Color.FromArgb(invertedR, invertedG, invertedB));
                }
            }
            return negativeImg;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (_imgSource != null)
            {
                _imgResult = ApplyNegativeEffect(_imgSource);
                picResult.Image = _imgResult;
            }
        }
    }
}
