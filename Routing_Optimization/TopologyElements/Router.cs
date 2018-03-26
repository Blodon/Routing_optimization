using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Routing_Optimization.TopologyElements
{

    class Router
    {
        private bool status;
        private int routerID;
        private int numberOfConnections;
        private int[] connections;
        private int positionX;
        private int positionY;

        Router(int routerID, int numberOfConnections, int[] connections){

            this.routerID = routerID;
            this.numberOfConnections = numberOfConnections;
            this.connections = connections;
            status = true;

        }

        public Router(int positionX, int positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;
        }

        public Router()
        {
        }

        ~Router()
        {

        }

        public void turnOff()
        {
            status = false;
        }

        internal int getID()
        {
            return routerID;
        }

        public void turnOn()
        {
            status = true;
        }

        public int[] ShowConnections()
        {
            return connections;
        }

        public int getPositionX()
        {
            return positionX;
        }

        public int getPositionY()
        {
            return positionY;
        }


        /**
        public int[] getPositionVector()
        {
            int[] vector;
            return vector;
        }
        **/

    }
}
