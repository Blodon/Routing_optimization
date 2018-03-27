using Routing_Optimization.TopologyElements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Routing_Optimization
{
    class Topology
    {
        private bool isSet;
        private int routerNumber;
        private List<Router> routerList;
        private List<Link> linkList;
        private Bitmap topologyGraph;



        public Topology()
        {
            routerNumber = 0;
            routerList = new List<Router>();
            linkList = new List<Link>();

        }

        ~Topology()
        {

        }

        public void SetNewDevice()
        {

        }

        public void RandomGeneration(int routerNumber, int minBandwidth, int maxBandwidth, int links)
        {


        }

        public int searchNearestRouter(int x, int y)
        {
            int routerIDtemp = 0;
            ////// TODO

            foreach(Router router in routerList)
            {
                if (Math.Abs(router.getPositionX() - x) <= 25 && Math.Abs(router.getPositionY() - y) <= 25)
                    routerIDtemp = router.getID();
            }

            return routerIDtemp;
        }

        public Router getRouterByID(int routerID)
        {
            Router tempRouter;

            foreach(Router router in routerList)
            {
                if (router.getID() == routerID) return router;
            }

            return new Router();
        }

        private Link searchLinkBetween(int routerID1, int routerID2)
        {
            /////// TODO
            return new Link();
        }

        public Link showLinkBetween(int x1, int y1, int x2, int y2)
        {

            Link tempLink = new Link();

            return tempLink;
        }

        public void newLink(int router1ID, int router2ID, int bandWidth)
        {
            Point firstPointtemp = new Point();
            Point secondPointtemp = new Point();

            foreach (Router router in routerList)
            {
                if (router.getID() == router1ID)
                {
                    router.addConnection(router2ID);
                    firstPointtemp.X = router.getPositionX();
                    firstPointtemp.Y = router.getPositionY();
                }
                if (router.getID() == router2ID)
                {
                    router.addConnection(router1ID);
                    secondPointtemp.X = router.getPositionX();
                    secondPointtemp.Y = router.getPositionY();
                }

            }

            Link temp = new Link(firstPointtemp.X, firstPointtemp.Y, secondPointtemp.X, secondPointtemp.Y, router1ID, router2ID, bandWidth);

            linkList.Add(temp);


        }

        public bool checkLinkBetween(int selectedRouterID, int tempRouterID)
        {
            bool alreadyExists = false;
            foreach(Link link in linkList)
            {
                if (link.CheckLink(selectedRouterID, tempRouterID)) alreadyExists = true;
            }
            return alreadyExists;
        }

        public void newRouter(int x, int y)
        {
            routerNumber++;
            Router newRouterTemp = new Router(x, y, routerNumber);
            /// Error - copy object
            routerList.Add(newRouterTemp);

        }

        public String informations()
        {
            String infos = "Liczba routerów: ";
            infos += routerList.Count.ToString();
            infos += "\n";
            infos += "Liczba połączeń: ";
            infos += linkList.Count.ToString();
            infos += "\n";
            infos += "Routery bez połączeń: ";

            int linklessRouters = 0;
            foreach (Router router in routerList)
                if (router.ShowConnections().Count == 0)
                    linklessRouters++;
            infos += linklessRouters.ToString();

            return infos;
        }

        public Bitmap drawGraph()
        {
            topologyGraph = new Bitmap(1000, 700);
            Graphics graphics = Graphics.FromImage(topologyGraph);

            Brush aBrush = (Brush)Brushes.Green;
            Brush bBrush = (Brush)Brushes.Black;
            Brush cBrush = (Brush)Brushes.Blue;

            
            Font font = new Font("Arial", 12);
            Pen pen = new Pen(cBrush);

            foreach (Link link in linkList)
            {
                graphics.DrawLine(pen, link.getFirstPoint(), link.getSecondPoint());

            }

            foreach (Router routerek in routerList)
            {
                graphics.FillEllipse(aBrush, routerek.getPositionX() - 10, routerek.getPositionY() - 10, 22, 22);
                int toMiddle = 6;
                if (routerek.getID() >= 10) toMiddle = 12;
                graphics.DrawString(routerek.getID().ToString(), font, bBrush, routerek.getPositionX() - toMiddle, routerek.getPositionY() - 8);
            }

            return topologyGraph;
        }

    }
}