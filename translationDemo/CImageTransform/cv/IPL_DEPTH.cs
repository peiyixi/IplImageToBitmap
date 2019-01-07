using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IplImageToBitmap.cv
{
   public enum IplDepth : uint
    {
        /// <summary>
        /// indicates if the value is signed
        /// </summary>
        IplDepthSign = 0x80000000,
        /// <summary>
        /// 1bit unsigned
        /// </summary>
        IplDepth_1U = 1,
        /// <summary>
        /// 8bit unsigned (Byte)
        /// </summary>
        IplDepth_8U = 8,
        /// <summary>
        /// 16bit unsigned
        /// </summary>
        IplDepth16U = 16,
        /// <summary>
        /// 32bit float (Single)
        /// </summary>
        IplDepth32F = 32,
        /// <summary>
        /// 8bit signed
        /// </summary>
        IplDepth_8S = (IplDepthSign | 8),
        /// <summary>
        /// 16bit signed
        /// </summary>
        IplDepth16S = (IplDepthSign | 16),
        /// <summary>
        /// 32bit signed 
        /// </summary>
        IplDepth32S = (IplDepthSign | 32),
        /// <summary>
        /// double
        /// </summary>
        IplDepth64F = 64
    }

}
