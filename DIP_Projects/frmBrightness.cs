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
    public partial class frmBrightness: frmBase
    {
        public frmBrightness()
        {
            InitializeComponent();
        }

        private void trbC_ValueChanged(object sender, EventArgs e)
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
    }
}
