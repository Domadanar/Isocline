using Isocline.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Isocline.Model
{
    internal class IsoclineModel
    {
        public double DeltaX(double slope, double step, double arrowLength)
        {
            return Math.Cos(Math.Atan(slope)) * step / 2.0 * arrowLength;
        }
        public double DeltaY(double slope, double step, double arrowLength) 
        {
            return Math.Sin(Math.Atan(slope)) * step / 2.0 * arrowLength;
        }
        
    }
}
