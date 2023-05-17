using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Isocline.Model;

namespace Isocline.Controller
{
    internal class IsoclineControler
    {
        private IsoclineModel isoclineModel;
        public IsoclineControler(IsoclineModel isoclineModel)
        {
            this.isoclineModel = isoclineModel;
        }
        public double CalculateX(double slope, double steps,double lenght)
        {
            return isoclineModel.DeltaX(slope, steps, lenght);
        }
        public double CalculateY(double slope, double steps, double lenght)
        {
            return isoclineModel.DeltaY(slope, steps, lenght);
        }
    }
}
