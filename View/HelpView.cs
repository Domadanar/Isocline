using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isocline.View
{
    internal class HelpView
    {
        public void HelpButton_Click(object sender, EventArgs e)
        {
            CustomMessageBox.Show("+ \n - \n * \n /  \n -? \n ^  \n sin(х) \n cos(х) \n tg(x) \nctg(x) \n asin(x) \n acos(x) \n atg(x) \n actg(x) \n log(x)",
                " додати\n відняти\n помножити\n поділити \n унарний мінус\n піднести до степеня \n синус\n косинус\n тангенс \n котангенс\n арксинус\n арккосинус\n арктангенс\n арккотангенс\n логарифм",
                "Пояснення", 12, FontStyle.Bold);

        }
        public class CustomMessageBox
        {
            public static void Show(string message, string mеssage1, string caption, int fontSize, FontStyle fontStyle)
            {
                Form form = new Form();
                form.Text = caption;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Width = 340;
                form.Height = 400;

                TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                tableLayoutPanel.ColumnCount = 2;
                tableLayoutPanel.Dock = DockStyle.Fill;

                Label label = new Label();
                label.Text = message;
                label.Font = new Font(label.Font.FontFamily, fontSize, fontStyle);
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleLeft;

                Label label2 = new Label();
                label2.Text = mеssage1;
                label2.Font = new Font(label2.Font.FontFamily, fontSize);
                label2.Dock = DockStyle.Fill;
                label2.TextAlign = ContentAlignment.MiddleLeft;

                tableLayoutPanel.Controls.Add(label, 0, 0);
                tableLayoutPanel.Controls.Add(label2, 1, 0);

                Button buttonOK = new Button();
                buttonOK.Text = "OK";
                buttonOK.DialogResult = DialogResult.OK;
                buttonOK.Dock = DockStyle.Bottom;

                form.Controls.Add(tableLayoutPanel);
                form.Controls.Add(buttonOK);

                form.ShowDialog();
            }
        }
    }
}
