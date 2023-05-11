using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isocline.Controller
{
    internal class FunctionController
    {
        private KryptonTextBox box_fxy;
        public FunctionController(KryptonTextBox box_fxy) 
        {
            this.box_fxy = box_fxy;
        } 
        public Func<double, double, double> FuncParser(String experssion)
        {
            var f = FunctionParser.CreateFXY(box_fxy.Text);
            return f;
        }
    }
}
