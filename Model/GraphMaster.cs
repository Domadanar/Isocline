using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Isocline
{
    class GraphMaster
    {
        private double min = -10;
        private double max = 10;
        private int width;
        private int height;
        private static Font font = new Font("Times New Roman", 14);
        private PictureBox picture;
        public GraphMaster(double _min, double _max)
        {
            min = _min;
            max = _max;
        }

        public Image CreateGraph(int w, int h, Action<Graphics> drawing)
        {
            width = w;
            height = h;
            var bmp = new Bitmap(w, h);
            using (var g = Graphics.FromImage(bmp))
            {
                g.FillRectangle(Brushes.White, 0, 0, w, h);
                drawing(g);
                DrawCoord(g);
            }
            return bmp;
        }

        private void DrawCoord(Graphics g)
        {
            g.DrawLine(Pens.Black, Transform(0, min), Transform(0, max));
            g.DrawLine(Pens.Black, Transform(min, 0), Transform(max, 0));
            var step = (max - min) / 20;
            for (var i = min; i < max; i += step)
            {
                g.DrawString(String.Format("{0}", Math.Round(i, 2)), font, Brushes.Black, Transform(0, i));
                g.DrawString(String.Format("{0}", Math.Round(i, 2)), font, Brushes.Black, Transform(i, 0));
            }
        }

        private Point Transform(double x, double y)
        {

            return new Point((int)((x + (max - min) / 2) / (max - min) * width),
                             (int)((-y + (max - min) / 2) / (max - min) * height));
        }

        public void DrawFX(Graphics g, Func<double, double> f)
        {
            int pixelWidth = picture.Width;
            int pixelHeight = picture.Height;
            double xScale = pixelWidth / (max - min);
            double yScale = pixelHeight / (max - min);

            int prevX = 0;
            int prevY = (int)Math.Round(f(min) * yScale);

            for (int i = 1; i < pixelWidth; i++)
            {
                double x = min + i / xScale;
                double y = f(x);
                int currX = i;
                int currY = (int)Math.Round((max - y) * yScale);

                // Draw the line segment using the efficient algorithm
                int dx = Math.Abs(currX - prevX);
                int dy = Math.Abs(currY - prevY);
                int sx = prevX < currX ? 1 : -1;
                int sy = prevY < currY ? 1 : -1;
                int err = dx - dy;

                while (true)
                {
                    g.FillRectangle(Brushes.Black, currX, currY, 1, 1);

                    if (currX == prevX && currY == prevY)
                        break;

                    int e2 = 2 * err;
                    if (e2 > -dy)
                    {
                        err -= dy;
                        currX += sx;
                    }
                    if (e2 < dx)
                    {
                        err += dx;
                        currY += sy;
                    }
                }

                prevX = currX;
                prevY = currY;
            }
        }

        public void DrawSolution(Graphics g, Func<double, double, double> dy, double x0, double y0)
        {
            double x = x0, y = y0;
            double step = 0.001; // Adjust the step size as needed

            while (x <= max)
            {
                var k1 = step * dy(x, y);
                var k2 = step * dy(x + 0.5 * step, y + 0.5 * k1);
                var k3 = step * dy(x + 0.5 * step, y + 0.5 * k2);
                var k4 = step * dy(x + step, y + k3);

                var nx = x + step;
                var ny = y + (k1 + 2 * k2 + 2 * k3 + k4) / 6;

                try
                {
                    g.DrawLine(Pens.Black, Transform(x, y), Transform(nx, ny));
                }
                catch { }

                x = nx;
                y = ny;
            }

            x = x0;
            y = y0;

            while (x >= min)
            {
                var k1 = step * dy(x, y);
                var k2 = step * dy(x - 0.5 * step, y - 0.5 * k1);
                var k3 = step * dy(x - 0.5 * step, y - 0.5 * k2);
                var k4 = step * dy(x - step, y - k3);

                var nx = x - step;
                var ny = y - (k1 + 2 * k2 + 2 * k3 + k4) / 6;

                try
                {
                    g.DrawLine(Pens.Black, Transform(x, y), Transform(nx, ny));
                }
                catch { }

                x = nx;
                y = ny;
            }
        }

    }
}
