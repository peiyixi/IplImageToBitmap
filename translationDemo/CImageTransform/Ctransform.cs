using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using IplImageToBitmap.cv;
using IplImageToBitmap;
using System.Drawing.Imaging;
namespace IplImageToBitmap
{
    public static class Ctransform
    {
        /// <summary>
        /// 将IplImage指针转换成位图对象;
        /// </summary>
        /// <param name="ptr">IplImage指针</param>
        /// <returns>返回位图对象</returns>

        public static Bitmap IplImageToBitmap(IntPtr ptr)
        {
            IntPtr pp = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(MIplImage)));
            pp = ptr;
            PixelFormat pixelFormat;   //像素格式

            MIplImage mptr = (MIplImage)Marshal.PtrToStructure((IntPtr)(pp.ToInt32()), typeof(MIplImage));
            IntPtr aa = new IntPtr();
            aa = mptr.ImageData;
            int width = mptr.Width;
            int height = mptr.Height;
            int step = mptr.WidthStep;
            string unsupportedDepth = "不支持的像素位深度IPL_DEPTH";
            string unsupportedChannels = "不支持的通道数（仅支持1，2，4通道）";
            switch (mptr.NChannels)
            {
                case 1:    //Grayscale image;         
                    switch (mptr.Depth)
                    {
                        case IplDepth.IplDepth_8U:
                            pixelFormat = PixelFormat.Format8bppIndexed;
                            break;
                        case IplDepth.IplDepth16U:
                            pixelFormat = PixelFormat.Format16bppGrayScale;
                            break;
                        default:
                            throw new NotImplementedException(unsupportedDepth);
                    }
                    break;
                case 3: //BGR image           
                    switch (mptr.Depth)
                    {
                        case IplDepth.IplDepth_8U:
                            pixelFormat = PixelFormat.Format24bppRgb;
                            break;
                        case IplDepth.IplDepth16U:
                            pixelFormat = PixelFormat.Format48bppRgb;

                            break;
                        default:
                            throw new NotImplementedException(unsupportedDepth);

                    }
                    break;

                case 4:
                    switch (mptr.Depth)
                    {
                        case IplDepth.IplDepth_8U:
                            pixelFormat = PixelFormat.Format32bppArgb;
                            break;
                        case IplDepth.IplDepth16U:
                            pixelFormat = PixelFormat.Format64bppArgb;
                            break;
                        default:
                            throw new NotImplementedException(unsupportedDepth);
                    }
                    break;
                default:
                    throw new NotImplementedException(unsupportedChannels);
            }
           Bitmap img = new Bitmap(width, height, step, pixelFormat, aa);
           //对于灰度图像，还要修改调色板
           if (pixelFormat == PixelFormat.Format8bppIndexed)
           {
               img.Palette = CvToolbox.GrayscalePalette;
           }

            return img;
        }
        ///// <summary>
        ///// 将位图转换成IplImage指针
        ///// </summary>
        ///// <param name="bitmap">位图对象</param>
        ///// <returns>返回IplImage指针</returns>
        //public static IntPtr BitmapToIplImagePointer(Bitmap bitmap)
        //{
        //    IImage iimage = null;
        //    MIplImage mptr = new MIplImage();
        //    switch (bitmap.PixelFormat)
        //    {
        //        case PixelFormat.Format8bppIndexed:
        //            mptr.NChannels = 1;
        //            mptr.Depth = IplDepth.IplDepth_8U;
        //            break;
        //        case PixelFormat.Format16bppGrayScale:
        //            iimage = new Image<Gray, UInt16>(bitmap);
        //            break;
        //        case PixelFormat.Format24bppRgb:
        //            iimage = new Image<Bgr, Byte>(bitmap);
        //            break;
        //        case PixelFormat.Format32bppArgb:
        //            iimage = new Image<Bgra, Byte>(bitmap);
        //            break;
        //        case PixelFormat.Format48bppRgb:
        //            iimage = new Image<Bgr, UInt16>(bitmap);
        //            break;
        //        case PixelFormat.Format64bppArgb:
        //            iimage = new Image<Bgra, UInt16>(bitmap);
        //            break;
        //        default:
        //            Image<Bgra, Byte> tmp1 = new Image<Bgra, Byte>(bitmap.Size);
        //            Byte[, ,] data = tmp1.Data;
        //            for (int i = 0; i < bitmap.Width; i++)
        //            {
        //                for (int j = 0; j < bitmap.Height; j++)
        //                {
        //                    Color color = bitmap.GetPixel(i, j);
        //                    data[j, i, 0] = color.B;
        //                    data[j, i, 1] = color.G;
        //                    data[j, i, 2] = color.R;
        //                    data[j, i, 3] = color.A;
        //                }
        //            }
        //            iimage = tmp1;
        //            break;
        //    }

        //    return iimage.Ptr;
        //}


       
    }
}
