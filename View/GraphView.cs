using Isocline.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Drawing;

namespace Isocline.View
{
    internal class GraphView
    {
        private GraphController graphController;
        private FunctionController functionController;
        private PictureBox picture;
        private KryptonPanel panel;
        private KryptonTextBox box_fxy;
        private KryptonTextBox b_min;
        private KryptonTextBox b_max;
        private KryptonTextBox b_x;
        private KryptonTextBox b_y;
        public GraphView(PictureBox picture, KryptonPanel panel,KryptonTextBox box_fxy,KryptonTextBox b_min,KryptonTextBox b_max, KryptonTextBox b_x, KryptonTextBox b_y,GraphController graphController,FunctionController functionController)
        {
            this.picture = picture;
            this.panel = panel;
            this.box_fxy = box_fxy;
            this.b_min = b_min;
            this.b_max = b_max;
            this.b_x = b_x;
            this.b_y = b_y;
            this.graphController = graphController;
            this.functionController = functionController;
        }

        public void PrintGraph(object sender, EventArgs args)
        {
            try
            {
                picture.Width = panel.Width;
                picture.Height = panel.Height;
                var f = functionController.FuncParser(box_fxy.Text);
                var min = double.Parse(b_min.Text);
                var max = double.Parse(b_max.Text);
                var x0 = double.Parse(b_x.Text);
                var y0 = double.Parse(b_y.Text);

                picture.Image = graphController.CreateGraphImage(min,max,picture.Width,picture.Height,f,x0,y0);

            }
            catch (Exception )
            {
                //  Console.WriteLine(e.Message);
            };
        }
        public void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            prewmouspos = Cursor.Position;
        }

        Point prewmouspos = new Point();

        public void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                picture.Location = new Point(picture.Location.X + (Cursor.Position.X - prewmouspos.X), picture.Location.Y + (Cursor.Position.Y - prewmouspos.Y));
                prewmouspos = Cursor.Position;
            }
        }

        public void Picture_MouseWheel(object sender, MouseEventArgs e)
        {
            Point savedpicturepos = picture.Location;
            if (e.Delta > 0)
            {
                if (picture.Width + 50 <= 2000 && picture.Height + 50 <= 2000)
                {
                    picture.Width = picture.Width + 50;
                    picture.Height = picture.Height + 50;
                    int x = panel.Width / 2 - picture.Width / 2;
                    int y = panel.Height / 2 - picture.Height / 2;

                    picture.Location = new Point(x, y);
                }
            }
            else
            {
                if (picture.Width - 50 >= 950 && picture.Height - 50 >= 600)
                {
                    picture.Width = picture.Width - 50;
                    picture.Height = picture.Height - 50;
                    int x = panel.Width / 2 - picture.Width / 2;
                    int y = panel.Height / 2 - picture.Height / 2;

                    picture.Location = new Point(x, y);
                }
            }
        }

    }
}
