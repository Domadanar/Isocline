using Isocline.Nodes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isocline
{
   public static class Helpers
    {

        public static Point Transform(double x, double y,double min, double max,int width, int height)
        {
            return new Point((int)((x + (max - min) / 2) / (max - min) * width),
                             (int)((-y + (max - min) / 2) / (max - min) * height));
        }
    }
}
