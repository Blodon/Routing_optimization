using Routing_Optimization.TopologyElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Routing_Optimization
{
    public partial class TopologyEditorForm : Form
    {

        private int editorOption;
        private Topology topology;
        private Router focusedRouter;
        private Link focusedLink;


        public TopologyEditorForm()
        {
            InitializeComponent();
            topology = new Topology();
        }

        private void TopologyEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxTopologyEditorMap_MouseClick(object sender, MouseEventArgs e)
        {
            int x, y;
            x = MousePosition.X -550;
            y = MousePosition.Y - 125;

            if(editorOption == 1)
            {
                setNewRouter(x, y);
            } else if(editorOption == 2)
            {

            } else if(editorOption == 3)
            {
                Router tempRouter = topology.searchNearestRouter(x, y);
            }
            
        }

        private void pictureBoxTopologyEditorMap_MouseHover(object sender, EventArgs e)
        {
            labelMousePositionXValue.Text = (MousePosition.X - 550).ToString();
            labelMousePositionYValue.Text = (MousePosition.Y - 100).ToString();

        }

        private void pictureBoxTopologyEditorMap_MouseMove(object sender, MouseEventArgs e)
        {
            labelMousePositionXValue.Text = (MousePosition.X - 550).ToString();
            labelMousePositionYValue.Text = (MousePosition.Y - 100).ToString();

        }

        private void buttonAddRouter_Click(object sender, EventArgs e)
        {
            editOption(1);
            buttonAddRouter.ForeColor = System.Drawing.Color.Green;

        }

        private void buttonSetLink_Click(object sender, EventArgs e)
        {
            editOption(2);
            buttonSetLink.ForeColor = System.Drawing.Color.Green;
            
        }

        private void buttonShowInfos_Click(object sender, EventArgs e)
        {
            editOption(3);
            buttonShowInfos.ForeColor = System.Drawing.Color.Green;

        }

        private void editOption(int option)
        {
            editorOption = option;
            buttonAddRouter.ForeColor = System.Drawing.Color.Black;
            buttonSetLink.ForeColor = System.Drawing.Color.Black;
            buttonShowInfos.ForeColor = System.Drawing.Color.Black;

        }

        private void setNewRouter(int x, int y)
        {
            topology.newRouter(x,y);

            Point pointer = new Point(x, y);
            Point pointer2 = new Point(500, 350);

           
            Bitmap bitmap = new Bitmap(1000, 700);
            Graphics g = Graphics.FromImage(bitmap);

            Brush aBrush = (Brush)Brushes.Green;
            Brush bBrush = (Brush)Brushes.Black;
            Brush cBrush = (Brush)Brushes.HotPink;

            Pen pen = new Pen(cBrush);

            Font font = new Font("Arial", 12);


            g.DrawLine(pen, pointer, pointer2);
            g.FillEllipse(aBrush, x-10, y-10, 22, 22);

            int toMiddle = 6;
            if (x % 15 >= 10) toMiddle = 12;
            g.DrawString((x%15).ToString(), font, bBrush, x-toMiddle, y-8);

            

            pictureBoxTopologyEditorMap.Image = bitmap;



        }









    }
}
