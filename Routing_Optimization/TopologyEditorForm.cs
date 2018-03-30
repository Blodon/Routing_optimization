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

        public bool ready;
        private int editorOption;
        private Topology topology;
        private Router focusedRouter;
        private Link focusedLink;
        private int selectNumber;

        private SettingBandwidthForm BandwidthForm;

        private int selectedRouterID;


        public TopologyEditorForm()
        {
            InitializeComponent();
            selectNumber = 1;
            this.topology = new Topology();
            BandwidthForm = new SettingBandwidthForm();
            BandwidthForm.TopMost = true;
            labelTopologyAllInfos.Text = topology.informations();
            
        }

        private void TopologyEditorForm_Load(object sender, EventArgs e)
        {
            ready = false;
        }

        private void pictureBoxTopologyEditorMap_MouseClick(object sender, MouseEventArgs e)
        {
            labelErrorMessage.Text = "";
            int x, y;
            x = MousePosition.X -550;
            y = MousePosition.Y - 100;

            if(editorOption == 1)   ///// put new router
            {
                if(topology.searchNearestRouter(x,y) == 0) setNewRouter(x, y);
                else labelErrorMessage.Text = "Inny router jest za blisko!";

            } else if(editorOption == 2)  /////// connect two routers
            {
                int tempRouterID = topology.searchNearestRouter(x, y);

                if (selectNumber == 1)
                {
                    if (tempRouterID != 0)
                    {
                        selectNumber = 2;
                        selectedRouterID = tempRouterID;
                    } else labelErrorMessage.Text = "Nie wybrano routera!";

                }
                else if (selectNumber == 2)
                {
                    if (tempRouterID != 0)
                    {
                        selectNumber = 1;
                        if (selectedRouterID != tempRouterID)
                        {
                            if (!topology.checkLinkBetween(selectedRouterID, tempRouterID))
                            {
                                BandwidthForm.ShowDialog();
                                while (!BandwidthForm.ready);
                                BandwidthForm.ready = false;

                                if(!BandwidthForm.isRefused())
                                topology.newLink(selectedRouterID, tempRouterID, BandwidthForm.getBandwidth());
                                pictureBoxTopologyEditorMap.Image = topology.drawGraph();
                            } else labelErrorMessage.Text = "podane połączenie już istnieje!";
                        } else labelErrorMessage.Text = "wybrano ten sam router!";

                    } else labelErrorMessage.Text = "Nie wybrano routera!";
                }

            } else if(editorOption == 3)  ///////// Show informations about router
            {
               int infoRouterID = topology.searchNearestRouter(x, y);
                Router infoRouter;
                if (infoRouterID != 0) labelRouterInfos.Text = topology.getRouterByID(infoRouterID).informations();
                else labelErrorMessage.Text = "Nie wybrano routera!";

            } else if(editorOption == 4)    ////// Check connection between two routers
            {
                int tempRouterID = topology.searchNearestRouter(x, y);

                if (selectNumber == 1)
                {
                    if (tempRouterID != 0)
                    {
                        selectNumber = 2;
                        selectedRouterID = tempRouterID;
                    }
                    else labelErrorMessage.Text = "Nie wybrano routera!";

                }
                else if (selectNumber == 2)
                {
                    if (tempRouterID != 0)
                    {
                        selectNumber = 1;
                        if (selectedRouterID != tempRouterID)
                        {
                            if(topology.existsWayBetween(selectedRouterID, tempRouterID))
                            {
                                labelErrorMessage.Text = "ISTNIEJE";
                            } else
                            {
                                labelErrorMessage.Text = "NIE ISTNIEJE";
                            }

                        }
                        else labelErrorMessage.Text = "wybrano ten sam router!";

                    }
                    else labelErrorMessage.Text = "Nie wybrano routera!";
                }

            }

            labelTopologyAllInfos.Text = topology.informations();

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
            selectedRouterID = 1;
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
            buttonCheckConnection.ForeColor = System.Drawing.Color.Black;

        }

        private void setNewRouter(int x, int y)
        {
            topology.newRouter(x,y);
            
            pictureBoxTopologyEditorMap.Image = topology.drawGraph();

        }

        public Bitmap getDrawing()
        {
            return topology.drawGraph();
        }

        public void newRandomTopology(int routers, int links, int minBandwidth, int maxBandwidth)
        {
            topology = new Topology();
            topology.randomGeneration(routers, links, minBandwidth, maxBandwidth);
        }

        private void buttonReady_Click(object sender, EventArgs e)
        {
            ready = true;
            this.Close();
        }

        private void buttonTopologyReset_Click(object sender, EventArgs e)
        {
            this.topology = new Topology();
            pictureBoxTopologyEditorMap.Image = topology.drawGraph();
            labelErrorMessage.Text = "";
            labelRouterInfos.Text = "";
            labelTopologyAllInfos.Text = topology.informations();
        }

        private void TopologyEditorForm_Shown(object sender, EventArgs e)
        {
            labelTopologyAllInfos.Text = topology.informations();
            pictureBoxTopologyEditorMap.Image = topology.drawGraph();
        }

        private void buttonCheckConnection_Click(object sender, EventArgs e)
        {
            editOption(4);
            selectedRouterID = 1;
            buttonCheckConnection.ForeColor = System.Drawing.Color.Green;

        }
    }
}
