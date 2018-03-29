using System;
using System.Collections.Generic;
using System.Drawing;
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
        private List<int> connectionsList;
        private int positionX;
        private int positionY;

        Router(int routerID, int numberOfConnections){

            this.routerID = routerID;
            this.numberOfConnections = numberOfConnections;
            
            status = true;

        }

        public Router(int positionX, int positionY, int routerID)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.routerID = routerID;
            numberOfConnections = 0;
            connectionsList = new List<int>();
            
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

        public List<int> ShowConnections()
        {
            return connectionsList;
        }

        public int getPositionX()
        {
            return positionX;
        }

        public int getPositionY()
        {
            return positionY;
        }

        public Point getPoint()
        {
            Point tempPoint = new Point(positionX, positionY);
            return tempPoint;
        }

        public void addConnection(int connectedRouterID)
        {
            numberOfConnections++;
            connectionsList.Add(connectedRouterID);

        }

        public String informations()
        {
            String infos = "ID routera: ";
            infos += routerID.ToString();
            infos += "\n\nIlość połączeń: ";
            infos += numberOfConnections.ToString();
            infos += "\nPołączony z:\n";
            foreach(int connection in connectionsList)
            {
                infos += connection.ToString();
                if(connection != connectionsList.Last()) infos += ", ";
            }

            return infos;
        }

        public int getNumberOfConnections()
        {
            return numberOfConnections;
        }

        public bool isConnectedTo(int routerNumber)
        {
            bool connectionStatus = false;
            foreach(int routerID in connectionsList)
            {
                if (routerID == routerNumber) connectionStatus = true;
            }

            return connectionStatus;
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
