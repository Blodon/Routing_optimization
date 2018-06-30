using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Routing_Optimization.TopologyElements
{
    
    public class Link
    {
        private bool linkStatus;
        private int bandWidth;
        private int delay;
        private int[] routersConnected;
        private Point firstPoint;
        private Point secondPoint;

        bool trace = false;
        public Pen color;
        private Brush blueBrush = (Brush)Brushes.Blue;
        private Brush redBrush = (Brush)Brushes.Red;

        Link(int bandWidth, int firstConnectedRouter, int secondConnectedRouter)
        {
            routersConnected[0] = firstConnectedRouter;
            routersConnected[1] = secondConnectedRouter;
            this.bandWidth = bandWidth;
            delay = 0;
            linkStatus = true;
            color = new Pen(blueBrush);
        }

        Link(int bandWidth, int delay, int firstConnectedRouter, int secondConnectedRouter)
        {
            routersConnected[0] = firstConnectedRouter;
            routersConnected[1] = secondConnectedRouter;
            this.bandWidth = bandWidth;
            this.delay = delay;
            linkStatus = true;
            color = new Pen(blueBrush);
        }

        public Link()
        {
            Brush blueBrush = (Brush)Brushes.Blue;
            color = new Pen(blueBrush);

        }

        public void resetColor()
        {
            trace = false;
            Brush blueBrush = (Brush)Brushes.Blue;
            color = new Pen(blueBrush);
        }

        public void setRedColor()
        {
            trace = true;
            color = new Pen(redBrush);
        }

        public Brush getColor()
        {
            if (trace) return redBrush;
            else return blueBrush;
        }

        public Link(int x1, int y1, int x2, int y2, int firstConnectedRouter, int secondConnectedRouter, int bandWidth)
        {
            firstPoint = new Point(x1, y1);
            secondPoint = new Point(x2, y2);
            routersConnected = new int[2];
            routersConnected[0] = firstConnectedRouter;
            routersConnected[1] = secondConnectedRouter;
            this.bandWidth = bandWidth;

        }
        public Link(int x1, int y1, int x2, int y2, int firstConnectedRouter, int secondConnectedRouter, int bandWidth, int delay)
        {
            firstPoint = new Point(x1, y1);
            secondPoint = new Point(x2, y2);
            routersConnected = new int[2];
            routersConnected[0] = firstConnectedRouter;
            routersConnected[1] = secondConnectedRouter;
            this.bandWidth = bandWidth;
            this.delay = delay;

        }

        public bool CheckLink(int firstConnectedRouter, int secondConnectedRouter)
        {
            if ((routersConnected[0] == firstConnectedRouter ||
                routersConnected[1] == firstConnectedRouter)
                &&
                (routersConnected[0] == secondConnectedRouter ||
                routersConnected[1] == secondConnectedRouter))
            {
                return true;
            }
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

        public Point getFirstPoint()
        {
            return firstPoint;
        }
        public Point getSecondPoint()
        {
            return secondPoint;
        }

        public int firsRouterID()
        {
            return routersConnected[0];
        }
        public int secondRouterID()
        {
            return routersConnected[1];
        }
        public int getBandwidth()
        {
            return bandWidth;
        }

        public void setDelay(int delay)
        {
            this.delay = delay;
        }

        public int getDelay()
        {
            return delay;
        }

        public void ChangeDelay(int delay)
        {
            this.delay = delay;
        }
    }
}
