using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isocline.Nodes
{
    public interface INode
    {
        double Value(Dictionary<String, double> variables = null);
    }
}
