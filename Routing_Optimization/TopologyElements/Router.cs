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

        Router(int routerID, int numberOfConnections, int[] connections){

            this.routerID = routerID;
            this.numberOfConnections = numberOfConnections;
            this.connections = connections;
            status = true;

        }

        ~Router()
        {

        }

        public void turnOff()
        {
            status = false;
        }

        public void turnOn()
        {
            status = true;
        }

        public int[] ShowConnections()
        {
            return connections;
        }


    }
}
