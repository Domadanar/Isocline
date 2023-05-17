using ComponentFactory.Krypton.Toolkit;
using Isocline.Controller;
using Isocline.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isocline.View
{
    internal class IsoclineView
    {
        private IsoclineControler isoclineControler;
        private FunctionController functionController;
        private PictureBox picture;
        private KryptonPanel panel;
        private KryptonTextBox box_fxy;
        private KryptonTextBox b_min;
        private KryptonTextBox b_max;
        private KryptonTextBox b_x;
        private KryptonTextBox b_y;
        private KryptonTextBox b_step;
        private KryptonTextBox b_length;

        public IsoclineView(PictureBox picture, KryptonPanel panel, KryptonTextBox box_fxy, KryptonTextBox b_min, KryptonTextBox b_max, KryptonTextBox b_x, KryptonTextBox b_y, KryptonTextBox b_step,KryptonTextBox b_length,IsoclineControler isoclineControler,FunctionController functionController)
        {
            this.picture = picture;
            this.panel = panel;
            this.box_fxy = box_fxy;
            this.b_min = b_min;
            this.b_max = b_max;
            this.b_x = b_x;
            this.b_y = b_y;
            this.b_step = b_step;
            this.b_length = b_length;
            this.isoclineControler = isoclineControler;
            this.functionController = functionController;
        }

        public void ShowDirectionField(object sender, EventArgs e)
        {
            Graphics graphics = picture.CreateGraphics();
            picture.Width = panel.Width;
            picture.Height = panel.Height;
            var f = functionController.FuncParser(box_fxy.Text);
            var min = double.Parse(b_min.Text);
            var max = double.Parse(b_max.Text);
            var steps = double.Parse(b_step.Text);
            var lenght = double.Parse(b_length.Text);
            double Min = min; 
            double Max = max; 
            double step = steps; 
            double arrowLength = lenght;  
            for (double x = Min; x <= Max; x += step)
            {
                for (double y = Min; y <= Max; y += step)
                {
                    double slope = f(x, y);
                    double deltaX = isoclineControler.CalculateX(slope,steps,lenght);
                    double deltaY = isoclineControler.CalculateY(slope, steps, lenght);
                    graphics.DrawLine(Pens.Black, Helpers.Transform((float)(x - deltaX), (float)(y - deltaY),min,max, picture.Width, picture.Height), Helpers.Transform((float)(x + deltaX), (float)(y + deltaY), min, max, picture.Width, picture.Height));
                }
            }
        }
    }
}
