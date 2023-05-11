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

namespace Isocline
{
    public partial class Form1 : KryptonForm
    {
        private GraphView graphView;
        private SaveView saveView;
        private HelpView helpView;

        private SaveModel saveModel;

        private FunctionController functionController;
        private GraphController graphController;
        private SaveController saveController;

        public Form1()
        {
            InitializeComponent();
            //Model
            saveModel = new SaveModel(picture);
            //Controller
            graphController = new GraphController();
            saveController = new SaveController(saveModel);
            functionController = new FunctionController(box_fxy);    
            //View
            graphView = new GraphView(picture, panel, box_fxy, b_min, b_max, b_x, b_y, graphController, functionController);
            saveView = new SaveView(picture,saveController);
            helpView = new HelpView();

            graphView.PrintGraph(null, null);
            this.Resize += graphView.PrintGraph;
            button.Click += graphView.PrintGraph;
            saveButton.Click += saveView.SaveButtonClick;
            helpButton.Click += helpView.HelpButton_Click;
            this.picture.MouseWheel += graphView.Picture_MouseWheel;
            picture.MouseMove += graphView.Picture_MouseMove;
            picture.MouseDown += graphView.Picture_MouseDown;
        }
       
        private void Form1_Load_1(object sender, EventArgs e)
        {
          
        }

        
    }
}
