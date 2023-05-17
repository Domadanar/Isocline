using Isocline;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Isocline.View;
using Isocline.Controller;
using System.Runtime.Remoting.Messaging;
using Isocline.Model;
using Isocline.Nodes;
using System.Web.UI.WebControls;

namespace Isocline
{
    public partial class Form1 : KryptonForm
    {
        private GraphView graphView;
        private SaveView saveView;
        private HelpView helpView;
        private IsoclineView isoclineView;

        private SaveModel saveModel;
        private IsoclineModel isoclineModel;

        private FunctionController functionController;
        private GraphController graphController;
        private SaveController saveController;
        private IsoclineControler isoclineControler;

        public Form1()
        {
            InitializeComponent();
            //Model
            saveModel = new SaveModel(picture);
            isoclineModel = new IsoclineModel();
            //Controller
            graphController = new GraphController();
            saveController = new SaveController(saveModel);
            functionController = new FunctionController(box_fxy);  
            isoclineControler = new IsoclineControler(isoclineModel);
            //View
            graphView = new GraphView(picture, panel, box_fxy, b_min, b_max, b_x, b_y, graphController, functionController);
            isoclineView = new IsoclineView(picture, panel, box_fxy, b_min, b_max, b_x, b_y,b_step,b_length,isoclineControler,functionController);
            saveView = new SaveView(picture,saveController);
            helpView = new HelpView();

            graphView.PrintGraph(null, null);
            this.Resize += graphView.PrintGraph;
            button.Click += ShowGraph;
            saveButton.Click += saveView.SaveButtonClick;
            helpButton.Click += helpView.HelpButton_Click;
            this.picture.MouseWheel += graphView.Picture_MouseWheel;
            picture.MouseMove += graphView.Picture_MouseMove;
            picture.MouseDown += graphView.Picture_MouseDown;
        }
        private void ShowGraph(object sender, EventArgs e)
        {

            bool showLine = kryptonCheckBox2.Checked;
            bool showBar = kryptonCheckBox3.Checked;
            bool showScatter = kryptonCheckBox1.Checked;
            {
                if (showLine)
                {
                    graphView.PrintGraph(null, null);
                }

                if (showBar)
                {
                    
                }

                if (showScatter)
                {
                    isoclineView.ShowDirectionField(null, null);
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
          
        }

        
    }
}
