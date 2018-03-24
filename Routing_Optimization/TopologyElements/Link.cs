using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Routing_Optimization.TopologyElements
{
    
    class Link
    {
        private bool linkStatus;
        private int bandWidth;
        private int[] routersConnected;

        Link(int bandWidth, int firstConnectedRouter, int secondConnectedRouter)
        {
            routersConnected[0] = firstConnectedRouter;
            routersConnected[1] = secondConnectedRouter;
            this.bandWidth = bandWidth;
            linkStatus = true;
        }

        public bool CheckLink(int firstConnectedRouter, int secondConnectedRouter)
        {
            if ((routersConnected[0] == firstConnectedRouter ||
                routersConnected[1] == firstConnectedRouter)
                &&
                (routersConnected[0] == secondConnectedRouter ||
                routersConnected[1] == secondConnectedRouter))
                return true;

            else return false;
        }

        public bool CheckBandWidth(int bandWidth)
        {
            if (this.bandWidth == bandWidth) return true;
            else return false;
        }

        public void ChangeBandWidth(int bandWidth)
        {
            this.bandWidth = bandWidth;
        }

        public bool CheckStatus()
        {
            return linkStatus;
        }

        public void TurnOnLink()
        {
            linkStatus = true;
        }
        public void TurnOffLink()
        {
            linkStatus = false;
        }

        public void routerTurnOff(int routerID)
        {
            if(linkStatus)
            if (routerID == routersConnected[0] || routerID == routersConnected[1]) linkStatus = false;
        }



    }
}
