using Isocline.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isocline.View
{
    internal class SaveView
    {
        private PictureBox picture;
        private SaveController saveController;
        public SaveView(PictureBox picture, SaveController saveController)
        {
            this.picture = picture;
            this.saveController = saveController;
        }

        public void SaveButtonClick(object sender, EventArgs e)
        {
            if (picture.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Зберегти зображення як...";
                sfd.OverwritePrompt = true;
                sfd.CheckPathExists = true;
                sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG|All files(*.*)|*.*";
                sfd.ShowHelp = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        saveController.SaveImage(sfd.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Неможливо зберегти зображення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}
