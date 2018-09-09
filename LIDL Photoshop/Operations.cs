using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;

namespace LIDL_Photoshop
{
    public static class Operations
    {
        public static Bitmap Resize(this Bitmap bitmap, int width, int height)
        {
            ResizeBicubic filter = new ResizeBicubic(width, height);
            return filter.Apply(bitmap);
        }
    }
}
