//----------------------------------------------------------------------------
//  Copyright (C) 2004-2018 by EMGU Corporation. All rights reserved.       
//----------------------------------------------------------------------------
using System;
using System.Drawing;

#if __ANDROID__
using Bitmap =  Android.Graphics.Bitmap;
#elif __IOS__
using CoreGraphics;
using UIKit;
#endif

namespace IplImageToBitmap.cv
{
    /// <summary>
    /// IImage interface
    /// </summary>
    public interface IImage : IDisposable, IInputOutputArray
#if !NETSTANDARD1_4
, ICloneable
#endif
    {
#if NETFX_CORE || NETSTANDARD1_4 || UNITY_ANDROID || UNITY_IOS || UNITY_STANDALONE || UNITY_METRO || UNITY_EDITOR
#elif __IOS__
      /// <summary>
      /// Convert this image to UIImage
      /// </summary>
      /// <returns>
      /// The UIImage
      /// </returns>
      UIImage ToUIImage();
#elif __UNIFIED__
#else
        /// <summary>
        /// Convert this image into Bitmap, when available, data is shared with this image.
        /// </summary>
        /// <returns>The Bitmap, when available, data is shared with this image</returns>
        Bitmap Bitmap
        {
            get;
        }
#endif

        /// <summary>
        /// The size of this image
        /// </summary>
        Size Size
        {
            get;
        }

        /// <summary>
        /// Returns the min / max location and values for the image
        /// </summary>
        /// <returns>
        /// Returns the min / max location and values for the image
        /// </returns>
        void MinMax(out double[] minValues, out double[] maxValues, out Point[] minLocations, out Point[] maxLocations);

        ///<summary> 
        /// Split current IImage into an array of gray scale images where each element 
        /// in the array represent a single color channel of the original image
        ///</summary>
        ///<returns> 
        /// An array of gray scale images where each element 
        /// in the array represent a single color channel of the original image 
        ///</returns>
        IImage[] Split();

        /// <summary>
        /// Get the pointer to the unmanaged memory
        /// </summary>
        IntPtr Ptr
        {
            get;
        }

        /// <summary>
        /// Save the image to the specific <paramref name="fileName"/> 
        /// </summary>
        /// <param name="fileName">The file name of the image</param>
        void Save(String fileName);

        /// <summary>
        /// Get the number of channels for this image
        /// </summary>
        int NumberOfChannels
        {
            get;
        }
    }
}
