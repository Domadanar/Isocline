﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isocline.Nodes
{
    class UnaryMinus: INode
    {
        private INode value;

        public UnaryMinus(INode value)
        {
            this.value = value;
        }

        public double Value(Dictionary<string, double> variables)
        {
            return - value.Value(variables);
        }
    }
}
