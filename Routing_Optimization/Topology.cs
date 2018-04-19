using Routing_Optimization.TopologyElements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
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


        public void randomGeneration(int routers, int links, int minBandwidth, int maxBandwidth)
        {
            int[] routerNoOfLinks = new int[links];

            // Random randlink = new Random(System.DateTime.Now.Minute * System.DateTime.Now.Hour * System.DateTime.Now.Second);
            Random randlink = new Random();

            int maxLinks = (routers * (routers - 1) / 2);

            for(int i=0; i<routers; i++)
            {
                newRouter(randlink.Next(10, 990), randlink.Next(10, 690));
            }

            double condition = (routers / 2);
            condition = Math.Ceiling(condition);


            //// first single connections
            for(int i=0; i < condition; i++)
            {
                bool notFound = true;
                int routerNo1;
                int routerNo2 = 0;

                do
                {
                    routerNo1 = randlink.Next(0, routers);

                    if (routerList.ElementAt(routerNo1).getNumberOfConnections() == 0)
                    {
                        bool notFound2 = true;

                        do
                        {
                            routerNo2 = randlink.Next(0, routers);
                            if ((routerList.ElementAt(routerNo2).getNumberOfConnections() == 0) &&
                                (routerNo1 != routerNo2))
                            {
                                if (!routerList.ElementAt(routerNo1).isConnectedTo(routerList.ElementAt(routerNo2).getID()))
                                {
                                    notFound2 = false;
                                }
                            }

                        } while (notFound2);
                        notFound = false;
                    }

                } while (notFound);

                if (!routerList.ElementAt(routerNo1).isConnectedTo(routerList.ElementAt(routerNo2).getID()))
                    newLink(routerList.ElementAt(routerNo1).getID(), routerList.ElementAt(routerNo2).getID(), 100);

            }

            
            foreach(Router router in routerList)
            {
                if(router.getNumberOfConnections() == 0)
                {
                    
                    int routerNo2 = 0;                    
              
                            bool notFound2 = true;

                            do
                            {
                                routerNo2 = randlink.Next(0, routers);
                                if ((routerList.ElementAt(routerNo2).getNumberOfConnections() == 1) &&
                                    (router.getID() != routerNo2) &&
                                    !existsWayBetween(router.getID(), routerNo2))
                                {
                                    if (!router.isConnectedTo(routerList.ElementAt(routerNo2).getID()))
                                    {
                                        notFound2 = false;
                                    }
                                }

                            } while (notFound2);
                           
                        
                        
                    if (!router.isConnectedTo(routerList.ElementAt(routerNo2).getID()))
                        newLink(router.getID(), routerList.ElementAt(routerNo2).getID(), 100);
                                                                          

                }
            }


            foreach(Router router in routerList)
            {
                for(int i = 0; i < routers; i++)
                {
                    if(router.getID()!= routerList.ElementAt(i).getID())
                    {
                        if (!existsWayBetween(router.getID(), routerList.ElementAt(i).getID())){
                            newLink(router.getID(), routerList.ElementAt(i).getID(), 100);
                        }
                    }
                    
                }

            }


            //// Rest of connections random
            for (int i = (routers-1); i < links; i++)
            {
                bool notFound = true;
                int routerNo1;
                int routerNo2 = 0;

                do
                {
                    routerNo1 = randlink.Next(0, routers);
                    
                    if (routerList.ElementAt(routerNo1).getNumberOfConnections() < routers-1)
                    {
                        bool notFound2 = true;

                        do
                        {
                            routerNo2 = randlink.Next(0, routers);
                            if ((routerList.ElementAt(routerNo2).getNumberOfConnections() < routers) &&
                                (routerNo1 != routerNo2))
                            {                                
                                if (!routerList.ElementAt(routerNo1).isConnectedTo(routerList.ElementAt(routerNo2).getID()))
                                {
                                    notFound2 = false;
                                }
                            }                                

                        } while (notFound2);
                        notFound = false;
                    }                
                    
                } while (notFound);

                if (!routerList.ElementAt(routerNo1).isConnectedTo(routerList.ElementAt(routerNo2).getID()))
                    newLink(routerList.ElementAt(routerNo1).getID(), routerList.ElementAt(routerNo2).getID(), 100);
               
            }


        }

        private Point pointer()
        {
            Point poni = new Point();

            return poni;
        }

        public bool existsWayBetween(int r1, int r2)
        {

            bool[] checkedRouters = new bool[routerNumber];

            
            for (int i = 0; i < routerNumber; i++)
            {
                checkedRouters[i] = false;
                if (routerList.ElementAt(i).getID() == r1) checkedRouters[i] = true;
            }

            for (int i = 0; i < routerNumber; i++)
            {
                for (int j = 0; j < routerNumber; j++)
                {
                    if (checkedRouters[j] == true)
                    {
                        foreach (int routerIDs in routerList.ElementAt(j).ShowConnections())
                        {
                            foreach (Router router in routerList)
                            {
                                if (router.getID() == routerIDs) checkedRouters[routerList.IndexOf(router)] = true;
                            }
                        }
                    }
                }
            }


            for (int i = 0; i < routerNumber; i++)            
                if (routerList.ElementAt(i).getID() == r2)
                    if (checkedRouters[i] == true) return true;
                         
                    
            return false;
        }

        public void WriteTextToFile(String fileName)
        {

            FileStream fileStream = File.Open(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter fileWriter = new StreamWriter(fileStream);

            fileWriter.WriteLine("Ilość wprowadzonych routerów: ");
            fileWriter.WriteLine(routerList.Count.ToString());
            foreach (Router position in routerList)
            {

                fileWriter.WriteLine("ID routera : ");
                fileWriter.WriteLine(position.getID().ToString());
                fileWriter.WriteLine("Wspolrzedna X i Y: ");
                fileWriter.WriteLine(position.getPositionX().ToString());
                fileWriter.WriteLine(position.getPositionY().ToString());

            }

            fileWriter.WriteLine("Ilość wprowadzonych połączeń: ");
            fileWriter.WriteLine(linkList.Count.ToString());
            foreach (Link link in linkList)
            {
                //fileWriter.WriteLine("Polaczenie miedzy routerem "+ link.firsRouterID()+" a "+ link.secondRouterID());
                fileWriter.WriteLine("Polaczenie miedzy routerem ");
                fileWriter.WriteLine(link.firsRouterID().ToString());
                fileWriter.WriteLine("a");
                fileWriter.WriteLine(link.secondRouterID().ToString());
                fileWriter.WriteLine("Przepustowość łącza: ");
                fileWriter.WriteLine(link.getBandwidth().ToString());
            }
            fileWriter.Flush();
            fileWriter.Close();
        }


        public void ReadTextFromFile(String fileName)
        {
            FileInfo fileInfo = new FileInfo(fileName);
            // If techcoil.txt exists 
            if (fileInfo.Exists)
            {
                // Get an instance of FileStream that represents
                // techcoil.txt
                FileStream fileStream = fileInfo.Open(FileMode.Open, FileAccess.Read);
                // Encapsulate the file stream instance in a StreamReader
                // instance
                StreamReader reader = new StreamReader(fileStream);
                String line;
                line = reader.ReadLine();
                // Read the file, line by line
                if ((line = reader.ReadLine()) != null)
                {
                    // Print out the line to console
                    int numberOfRouters = int.Parse(line);
                    for (int i = 0; i < numberOfRouters; i++)
                    {
                        for (int j = 0; j < 3; j++) line = reader.ReadLine();
                        newRouter(int.Parse(reader.ReadLine()), int.Parse(reader.ReadLine()));
                    }

                    line = reader.ReadLine();
                    line = reader.ReadLine();
                    int numberOfLinks = int.Parse(line);
                    for (int i = 0; i < numberOfLinks; i++)  // zczytywanie połączeń (linków) pomiędzy routerami wraz z parametrami
                    {
                        line = reader.ReadLine();
                        int IDRouter1 = int.Parse(reader.ReadLine());
                        line = reader.ReadLine();
                        int IDRouter2 = int.Parse(reader.ReadLine());
                        line = reader.ReadLine();
                        int bandWidth = int.Parse(reader.ReadLine());
                        newLink(IDRouter1, IDRouter2, bandWidth);
                    }

                } // end while

                reader.Close();
            }
            else
            {
                Console.WriteLine("techcoil.txt does not exist.");
            } // end if

        }

    }
}