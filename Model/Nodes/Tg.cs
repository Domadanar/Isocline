using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isocline.Nodes
{
    class Tg : INode
    {
        private INode value;

        public Tg(INode value)
        {
            this.value = value;
        }

        public double Value(Dictionary<string, double> variables)
        {
            return Math.Tan(value.Value(variables));
        }
    }
}
