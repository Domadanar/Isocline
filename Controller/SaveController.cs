using Isocline.Model;
using Isocline.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isocline.Controller
{
    internal class SaveController
    {
        private SaveModel saveModel;
        public SaveController(SaveModel saveModel)
        {
            this.saveModel = saveModel;
        }
        public void SaveImage(string filePath)
        {
            saveModel.Save(filePath);
        }
    }
}
