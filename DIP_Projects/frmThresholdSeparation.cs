using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DIP_Projects
{
    public partial class frmThresholdSeparation: frmBase
    {
        public frmThresholdSeparation()
        {
            InitializeComponent();
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

        private void trbC_ValueChanged(object sender, EventArgs e)
        {
            txtC.Text = trbC.Value.ToString();
            int thres = trbC.Value;
            _imgResult = thresholdSeparation(_imgSource, thres);
            picResult.Image = _imgResult; 
            picResult.Refresh();
        }

        private void btnAutoThreshold_Click(object sender, EventArgs e)
        {
            byte threshold = FindThreshold(_imgSource);
            _imgResult = thresholdSeparation(_imgSource, threshold);
            picResult.Image = _imgResult;

            trbC.Value = threshold;
            txtC.Text = threshold.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _imgResult = new Bitmap(_imgSource);
            picResult.Image = _imgResult; 
            picResult.Refresh(); 

            txtC.Text = "0";
        }
    }
}
