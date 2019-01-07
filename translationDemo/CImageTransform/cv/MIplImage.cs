using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IplImageToBitmap.cv

{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct MIplImage
    {
        /// <summary>
        /// sizeof(IplImage) 
        /// </summary>
        public int NSize;
        /// <summary>
        /// version (=0)
        /// </summary>
        public int ID;
        /// <summary>
        /// Most of OpenCV functions support 1,2,3 or 4 channels 
        /// </summary>
        public int NChannels;
        /// <summary>
        /// ignored by OpenCV 
        /// </summary>
        public int AlphaChannel;
        /// <summary>
        /// pixel depth in bits: IPL_DEPTH_8U, IPL_DEPTH_8S, IPL_DEPTH_16U, IPL_DEPTH_16S, IPL_DEPTH_32S, IPL_DEPTH_32F and IPL_DEPTH_64F are supported 
        /// </summary>
        public IplDepth Depth;

        /// <summary>
        /// ignored by OpenCV 
        /// </summary>
        public byte ColorModel0;
        /// <summary>
        /// ignored by OpenCV 
        /// </summary>
        public byte ColorModel1;
        /// <summary>
        /// ignored by OpenCV 
        /// </summary>
        public byte ColorModel2;
        /// <summary>
        /// ignored by OpenCV 
        /// </summary>
        public byte ColorModel3;

        /// <summary>
        /// ignored by OpenCV 
        /// </summary>
        public byte ChannelSeq0;
        /// <summary>
        /// ignored by OpenCV 
        /// </summary>
        public byte ChannelSeq1;
        /// <summary>
        /// ignored by OpenCV 
        /// </summary>
        public byte ChannelSeq2;
        /// <summary>
        /// ignored by OpenCV 
        /// </summary>
        public byte ChannelSeq3;

        /// <summary>
        /// 0 - interleaved color channels, 1 - separate color channels.
        /// cvCreateImage can only create interleaved images 
        /// </summary>
        public int DataOrder;
        /// <summary>
        /// 0 - top-left origin,
        /// 1 - bottom-left origin (Windows bitmaps style)
        /// </summary>
        public int Origin;
        /// <summary>
        /// Alignment of image rows (4 or 8).
        /// OpenCV ignores it and uses widthStep instead 
        /// </summary>
        public int Align;
        /// <summary>
        /// image width in pixels 
        /// </summary>
        public int Width;
        /// <summary>
        /// image height in pixels 
        /// </summary>
        public int Height;
        /// <summary>
        /// image ROI. when it is not NULL, this specifies image region to process 
        /// </summary>
        public IntPtr Roi;
        /// <summary>
        /// must be NULL in OpenCV 
        /// </summary>
        public IntPtr MaskROI;
        /// <summary>
        /// ditto
        /// </summary>
        public IntPtr ImageId;
        /// <summary>
        /// ditto 
        /// </summary>
        public IntPtr TileInfo;
        /// <summary>
        /// image data size in bytes
        /// (=image->height*image->widthStep in case of interleaved data)
        /// </summary>
        public int ImageSize;
        /// <summary>
        /// pointer to aligned image data 
        /// </summary>
        public IntPtr ImageData;
        /// <summary>
        /// size of aligned image row in bytes 
        /// </summary>
        public int WidthStep;

        /// <summary>
        /// border completion mode, ignored by OpenCV 
        /// </summary>
        public int BorderMode0;
        /// <summary>
        /// border completion mode, ignored by OpenCV 
        /// </summary>
        public int BorderMode1;
        /// <summary>
        /// border completion mode, ignored by OpenCV 
        /// </summary>
        public int BorderMode2;
        /// <summary>
        /// border completion mode, ignored by OpenCV 
        /// </summary>
        public int BorderMode3;

        /// <summary>
        /// border const, ignored by OpenCV 
        /// </summary>
        public int BorderConst0;
        /// <summary>
        /// border const, ignored by OpenCV 
        /// </summary>
        public int BorderConst1;
        /// <summary>
        /// border const, ignored by OpenCV 
        /// </summary>
        public int BorderConst2;
        /// <summary>
        /// border const, ignored by OpenCV 
        /// </summary>
        public int BorderConst3;

        /// <summary>
        ///  pointer to a very origin of image data (not necessarily aligned) - it is needed for correct image deallocation 
        /// </summary>
        public IntPtr ImageDataOrigin;
    }

}
