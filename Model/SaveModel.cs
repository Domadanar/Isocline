using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isocline.Model
{
    internal class SaveModel
    {
        private PictureBox picture;
        public SaveModel(PictureBox picture)
        {
            this.picture = picture;
        }

        public void Save(string filePath)
        {
            picture.Image.Save(filePath);
        }
    }
}
