using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IplImageToBitmap.cv
{
    public static class CvToolbox
    { // #region Color Pallette
        /// <summary>
        /// The ColorPalette of Grayscale for Bitmap Format8bppIndexed
        /// </summary>
        public static readonly ColorPalette GrayscalePalette = GenerateGrayscalePalette();
 
        private static ColorPalette GenerateGrayscalePalette()
        {
            using (Bitmap image = new Bitmap(1, 1, PixelFormat.Format8bppIndexed))
            {
                ColorPalette palette = image.Palette;
                for (int i = 0; i < 256; i++)
                {
                    palette.Entries[i] = Color.FromArgb(i, i, i);
                }
                return palette;
            }
        }

    }
}
