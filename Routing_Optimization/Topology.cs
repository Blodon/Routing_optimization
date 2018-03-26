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

        public Router searchNearestRouter(int x, int y)
        {
            ////// TODO

            return new Router();
        }

        private Link searchLinkBetween(int routerID1, int routerID2)
        {
            /////// TODO
            return new Link();
        }

        public Link showLinkBetween(int x1, int y1, int x2, int y2)
        {

            return searchLinkBetween(
                searchNearestRouter(x1, y1).getID(),
                searchNearestRouter(x2, y2).getID()
                );
        }

        public void newRouter(int x, int y)
        {

            Router newRouterTemp = new Router(x, y);
            /// Error - copy object
            routerList.Add(newRouterTemp);

        }

    }
}