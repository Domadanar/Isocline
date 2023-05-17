using Isocline.Nodes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isocline.Controller
{
    internal class GraphController
    {
        public Image CreateGraphImage(double min, double max, int width, int height, Func<double, double, double> f,double x0,double y0)
        {
            var gm = new GraphMaster(min, max);
            return gm.CreateGraph(width, height,
                    (g) => gm.DrawLinearInterpolation(g, f, x0, y0));
        }
    }
}
