using Routing_Optimization.TopologyElements;
using System;
using System.Diagnostics;
using System.IO;

namespace Routing_Optimization.Algorithms
{
    class Algorithm
    {
        protected Topology topology;
        protected Topology topologyBellman;
        protected Topology topologyDijkstra;

        public const int cst = 9999999;
        int verticesCount;

        private int sourceRouter;
        private int destinationRouter;

        private String warshallDistance = "";
        private String warshallPathString = "";
        int[,] routerBeforeWarshall;
        private bool[,] warsahllPath;
        private int[] warshallPaths;
        private int[] warshallPathsGenerate;
        private int pathCounter = 0;
        private TimeSpan warshallTime;
        private TimeSpan warshallTimeData;

        private String belmanDistance =  "";
        private String belmanPathString = "";
        int[] routerBeforeBellman;
        private bool[,] belmanPath;
        private int[] belmanPaths;
        private TimeSpan belmanTime;
        private TimeSpan belmanTimeData;

        private String dijkstraDistance = "";
        private String dijkstraPathString = "";
        public int[,] graphDijkstra;
        int[] routerBeforeDijkstra;
        private bool[,] dijkstraPath;
        private int[] dijkstraPaths;
        private TimeSpan dijkstraTime;
        private TimeSpan dijkstraTimeData;


        private String BFSDistance = "";
        private String BFSPathString = "";
        int[] routerBeforeBFS;
        private bool[,] BFSPath;
        private int[] BFSPaths;
        private BFSNode[] nodeTable;
        private TimeSpan BFSTime;
        private TimeSpan BFSTimeData;



        public Algorithm(Topology topology, int source, int destination)
        {
            sourceRouter = source-1;
            destinationRouter = destination-1;

            topologyBellman = (Topology)topology.clone();

            warshallPaths = new int[topology.getRouterNumber()];
            belmanPaths = new int[topology.getRouterNumber()];
            dijkstraPaths = new int[topology.getRouterNumber()];

            this.topology = topology;
            verticesCount = topology.getRouterNumber();
            

            warsahllPath = new bool[topology.getRouterNumber(), topology.getRouterNumber()];
            belmanPath = new bool[topology.getRouterNumber(), topology.getRouterNumber()];
            dijkstraPath = new bool[topology.getRouterNumber(), topology.getRouterNumber()];

            for (int i = 0; i < verticesCount; i++)
                for (int j = 0; j < verticesCount; j++)
                {
                    warsahllPath[i, j] = false;
                    belmanPath[i, j] = false;
                    dijkstraPath[i, j] = false;
                }

        }

        public Topology getTopology()
        {
            return topology;
        }

        public int[,] graph;


        public String getGraph()
        {
            String graphPrinter = "";

            for (int i = 0; i < topology.getRouterNumber(); i++)
            {
                for (int j = 0; j < topology.getRouterNumber(); j++)
                {
                    graphPrinter += graph[i, j].ToString();
                    graphPrinter += "         ";
                }
                graphPrinter += "\n\n\n";
            }

            return graphPrinter;
        }






        /// Warshall

        private void makeGraphWarshall()
        {
            graph = new int[topology.getRouterNumber(), topology.getRouterNumber()];

            for (int i = 0; i < topology.getRouterNumber(); i++)
                for (int j = 0; j < topology.getRouterNumber(); j++)
                {
                    if (i == j) graph[i, j] = 0;
                    else graph[i, j] = cst; /// no connection between routers
                }

            foreach (Link link in topology.getLinkList())
            {
                int metric;
                if (link.getBandwidth() >= 9999) metric = 1;
                else metric = 1000 - (link.getBandwidth() / 10);

                graph[link.firsRouterID() - 1, link.secondRouterID() - 1] = metric;
                graph[link.secondRouterID() - 1, link.firsRouterID() - 1] = metric;
            }

        }

        private void Print(int[,] distance, int verticesCount)
        {

            warshallDistance = "Shortest distances between every pair of vertices:\n";

            for (int i = 0; i < verticesCount; ++i)
            {
                for (int j = 0; j < verticesCount; ++j)
                {
                    if (distance[i, j] == cst)
                        warshallDistance += "cst       ";
                    else
                        warshallDistance += distance[i, j].ToString();
                    warshallDistance += "      ";
                }

                warshallDistance += "\n";
            }
            
        }

        public void FloydWarshall()
        {

            Stopwatch stopWatchWarshall = new Stopwatch();

            stopWatchWarshall.Start();

            makeGraphWarshall();

            /// Initialize components
            int[,] distance = new int[verticesCount, verticesCount];
            routerBeforeWarshall = new int[verticesCount, verticesCount];

            for (int i = 0; i < verticesCount; i++)
                for (int j = 0; j < verticesCount; j++)
                    if(i!=j)routerBeforeWarshall[i,j] = j;
                     else routerBeforeWarshall[i, j] = 0;

            int temp = sourceRouter;

            for (int i = 0; i < verticesCount; ++i)
                for (int j = 0; j < verticesCount; ++j)
                    distance[i, j] = graph[i, j];

            stopWatchWarshall.Stop();
            warshallTimeData = stopWatchWarshall.Elapsed;
            stopWatchWarshall.Reset();

            stopWatchWarshall.Start();

            /// Algorithm
            for (int k = 0; k < verticesCount; ++k)
            {
                for (int i = 0; i < verticesCount; ++i)
                {
                    for (int j = 0; j < verticesCount; ++j)
                    {
                        if (distance[i, k] + distance[k, j] < distance[i, j])
                        {
                            distance[i, j] = distance[i, k] + distance[k, j];
                            routerBeforeWarshall[i, j] = routerBeforeWarshall[i, k];

                        }
                    }
                }
            }
            //routerBeforeWarshall[destinationRouter] = temp;

            stopWatchWarshall.Stop();

            /// save result
            warshallTime = stopWatchWarshall.Elapsed;
            for (int i = 0; i < verticesCount; ++i)
                warshallPaths[i] = distance[sourceRouter, i];

            /// print result
            Print(distance, verticesCount);
        }

        public int[] getWarshallPaths()
        {
            return warshallPaths;
        }

        public TimeSpan getWarshallTime()
        {
            return warshallTime;
        }

        public TimeSpan getWarshallTimeData()
        {
            return warshallTimeData;
        }

        public void colorLinksWarshall()
        {

            warshallPathString = "";

            //Dziala dla wszystkich

            //for (int i = 0; i < verticesCount; i++)
            //{
            //    for (int j = 0; j < verticesCount; j++)
            //    {
            //        if (i != j)
            //        {
            //            int u = i;
            //            int v = j;

            //            warshallPath += u+1;
            //            warshallPath += " ";
            //            warshallPath += v+1;
            //            warshallPath += " ";
            //            warshallPath += u+1;

            //            do
            //            {
            //                u = routerBeforeWarshall[u, v];
            //                warshallPath += " -> " + (u+1);
            //            } while (u != v);
            //            // System.out.println(path);
            //            warshallPath += "\n";
            //        }
            //    }
            //}

            topology.resetLinkColor();

            int u = sourceRouter;
            int v = destinationRouter;

            //warshallPathString += u + 1;
            //warshallPathString += " ";
            //warshallPathString += v + 1;
            //warshallPathString += " ";
            warshallPathString += u + 1;

            int routerBefore;

            warshallPathsGenerate = new int[verticesCount];
            pathCounter = 0;
            warshallPathsGenerate[pathCounter++] = sourceRouter + 1;

            do
            {
                routerBefore = u;
                u = routerBeforeWarshall[u, v];
                warshallPathsGenerate[pathCounter++] = (u + 1);
                warshallPathString += " -> " + (u + 1);
                topology.colorLink(routerBefore + 1, u + 1);
            } while (u != v);
            // System.out.println(path);
            // warshallPathString += "\n";


        }

        public String showWarshallPath()
        {
            return warshallPathString;
        }

        /// WARSHALL end










        ///  BELMANA FORDA

        public struct Edge
        {
            public int Source;
            public int Destination;
            public int Weight;
        }

        public struct Graph
        {
            public int VerticesCount;
            public int EdgesCount;
            public Edge[] edge;
        }

        private Graph graphBelman;

        public static Graph CreateGraph(int verticesCount, int edgesCount)
        {
            Graph graphBelman = new Graph();
            graphBelman.VerticesCount = verticesCount;
            graphBelman.EdgesCount = edgesCount;
            graphBelman.edge = new Edge[graphBelman.EdgesCount];

            return graphBelman;
        }

        private void PrintBelman(int[] distance, int count)
        {
            belmanDistance = "Vertex   Distance from source";

            for (int i = 0; i < count; ++i) { 
                belmanDistance += (i+1).ToString();
                belmanDistance += " ";
                belmanDistance += distance[i].ToString();
                belmanDistance += "\n";
            }
            
        }

        public void BellmanFord()
        {

            Stopwatch stopWatchBellman = new Stopwatch();

            stopWatchBellman.Start();
            /// Initialize components
            belmanDistance = "";
            makeBelmanStruct();
            int verticesCount = graphBelman.VerticesCount;
            int edgesCount = graphBelman.EdgesCount;
            int[] distance = new int[verticesCount];
            routerBeforeBellman = new int[verticesCount];

            for (int i = 0; i < verticesCount; i++)
                distance[i] = int.MaxValue;

            distance[sourceRouter] = 0;
            routerBeforeBellman[sourceRouter] = sourceRouter;

            stopWatchBellman.Stop();
            belmanTimeData = stopWatchBellman.Elapsed;
            stopWatchBellman.Reset();

            stopWatchBellman.Start();
            /// Algotithm
            for (int i = 1; i <= verticesCount - 1; ++i)
            {
                for (int j = 0; j < edgesCount; ++j)
                {
                    int u = graphBelman.edge[j].Source;
                    int v = graphBelman.edge[j].Destination;
                    int weight = graphBelman.edge[j].Weight;

                    if (distance[u] != int.MaxValue && distance[u] + weight < distance[v])
                    {
                        distance[v] = distance[u] + weight;
                        routerBeforeBellman[v] = u;
                    }
                }
            }

            for (int i = 0; i < edgesCount; ++i)
            {
                int u = graphBelman.edge[i].Source;
                int v = graphBelman.edge[i].Destination;
                int weight = graphBelman.edge[i].Weight;

                if (distance[u] != int.MaxValue && distance[u] + weight < distance[v])
                    belmanDistance += "Graph contains negative weight cycle.";
            }
            stopWatchBellman.Stop();

            /// save results
            belmanTime = stopWatchBellman.Elapsed;
            for (int i = 0; i < verticesCount; ++i)
                belmanPaths[i] = distance[i];

            /// print results
            PrintBelman(distance, verticesCount);
            colorLinksBellman();
        }

        private void makeBelmanStruct()
        {
            int verticesCount = topology.getRouterNumber();
            int edgesCount = topology.getLinkList().Count*2;
            graphBelman = CreateGraph(verticesCount, edgesCount);

            int element = 0;

            Random randDelay = new Random();


            FileStream fileStream = File.Open("opoznienia.csv", FileMode.Create, FileAccess.Write);       /////// TO NA PALE USUN TO POZNIEJ
            StreamWriter fileWriter = new StreamWriter(fileStream, System.Text.Encoding.UTF8);


            fileWriter.Write("ID1;ID2;BandWidth[Mbps];Delay[0.01ms]\n");
            //fileWriter.Write(Encoding.ASCII.GetBytes(columnTitles), 0, 0);

            foreach (Link linek in topology.getLinkList())
            {
               
                int metric = typeMetricForIGRP(linek.getBandwidth(), linek.getDelay() );   /// DELAY 100 = 1ms  || 1 = 0,01 ms

                String toTezWywale = "";
                toTezWywale = linek.firsRouterID().ToString() + ";" + linek.secondRouterID().ToString() + ";" + linek.getBandwidth().ToString() + ";" + linek.getDelay().ToString() +"\n";

                fileWriter.Write(toTezWywale);


                graphBelman.edge[element].Source = linek.firsRouterID() - 1;
                graphBelman.edge[element].Destination = linek.secondRouterID() - 1;
                graphBelman.edge[element].Weight = metric;
                element++;

                graphBelman.edge[element].Source = linek.secondRouterID() - 1;
                graphBelman.edge[element].Destination = linek.firsRouterID() - 1;
                graphBelman.edge[element].Weight = metric;
                element++;
            }


            fileWriter.Flush();
            fileWriter.Close();

        }

        private int typeMetricForIGRP(int bandwidth, int delay)
        {
            int metric;
            int k1 = 1, k3 = 1, k2 = 0, k4 = 0, k5 = 0;
            int load = 0;
            //int delay = 100;

            metric = (10000/bandwidth) + ((k2*bandwidth * 1000) / (256 - load)) + (k3 * delay);

            return metric;
        }

        public int[] getBellmanPaths()
        {
            return belmanPaths;
        }

        public TimeSpan getBellmanTime()
        {
            return belmanTime;
        }
        public TimeSpan getBellmanTimeData()
        {
            return belmanTimeData;
        }

        public void colorLinksBellman()
        {
            topology.resetLinkColor();

            int destination = destinationRouter;
            int stepAhead = routerBeforeBellman[destination];
            topologyBellman.colorLink(destination + 1, stepAhead + 1);

           
            String toEndString = (destination + 1).ToString();

         

            while (stepAhead != sourceRouter)
            {
                destination = stepAhead;

                belmanPathString = " -> " + toEndString;
                toEndString = (destination+1).ToString() + belmanPathString;
            
                stepAhead = routerBeforeBellman[destination];
                topologyBellman.colorLink(destination + 1, stepAhead + 1);
            }

            belmanPathString = (sourceRouter + 1).ToString() + " -> " + toEndString;

        }

        public Topology getBellmanTopology()
        {
            return topologyBellman;
        }

        public String showBellmanPath()
        {
            return belmanPathString;
        }

        ///  BELMANA FORDA end 






        /// DIKSTRYJEK
        /// 


        private void makeGraphDijkstra()
        {
            graphDijkstra = new int[topology.getRouterNumber(), topology.getRouterNumber()];

            for (int i = 0; i < topology.getRouterNumber(); i++)
                for (int j = 0; j < topology.getRouterNumber(); j++)
                {
                    if (i == j) graphDijkstra[i, j] = 0;
                    else graphDijkstra[i, j] = cst; /// no connection between routers
                }

            foreach (Link link in topology.getLinkList())
            {
                int multiplier = 1;
                int metric = 100;
                if ((link.getBandwidth()) >= (100)) metric = multiplier;
                else metric = (100*multiplier) / (link.getBandwidth());

                graphDijkstra[link.firsRouterID() - 1, link.secondRouterID() - 1] = metric;
                graphDijkstra[link.secondRouterID() - 1, link.firsRouterID() - 1] = metric;
            }

        }



        private int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        private void Print(int[] distance, int verticesCount)
        {
            dijkstraDistance = "Vertex    Distance from source";

            for (int i = 0; i < verticesCount; ++i)
            {
                dijkstraDistance += (i + 1).ToString();
                dijkstraDistance += " ";
                dijkstraDistance += distance[i].ToString();
                dijkstraDistance += "\n";
            }
        }

        public void DijkstraAlgo( int source, int verticesCount)
        {
            Stopwatch stopWatchDijkstra = new Stopwatch();

            stopWatchDijkstra.Start();
            /// Initialize components
            makeGraphDijkstra();
            int[] distance = new int[verticesCount];
            routerBeforeDijkstra = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];

            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;

            stopWatchDijkstra.Stop();
            dijkstraTimeData = stopWatchDijkstra.Elapsed;
            stopWatchDijkstra.Reset();


            stopWatchDijkstra.Start();
            /// Algorithm
            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
                shortestPathTreeSet[u] = true;

                for (int v = 0; v < verticesCount; ++v)
                    if (!shortestPathTreeSet[v] && Convert.ToBoolean(graphDijkstra[u, v]) && distance[u] != int.MaxValue && distance[u] + graphDijkstra[u, v] < distance[v])
                    {
                        distance[v] = distance[u] + graphDijkstra[u, v];
                        routerBeforeDijkstra[v] = u;
                    }
            }

            stopWatchDijkstra.Stop();

            /// save results
            dijkstraTime = stopWatchDijkstra.Elapsed;
            for (int i = 0; i < verticesCount; ++i)
                dijkstraPaths[i] = distance[i];

            /// print results
            colorLinksDijkstra();
            Print(distance, verticesCount);
        }

        public void dijkstraAlgorithm()
        {
            DijkstraAlgo(sourceRouter, topology.getRouterNumber());
        }

        public int[] getDijktraPaths()
        {
            return dijkstraPaths;
        }

        public TimeSpan getDijkstraTime()
        {
            return dijkstraTime;
        }
        public TimeSpan getDijkstraTimeData()
        {
            return dijkstraTimeData;
        }

        public void colorLinksDijkstra()
        {
            topology.resetLinkColor();

            int destination = destinationRouter;
            int stepAhead = routerBeforeDijkstra[destination];
            topology.colorLink(destination + 1, stepAhead + 1);


            String toEndString = (destination+1).ToString();

            while (stepAhead != sourceRouter)
            {
                destination = stepAhead;

                dijkstraPathString = " -> " + toEndString;
                toEndString = (destination + 1).ToString() + dijkstraPathString;

                stepAhead = routerBeforeBellman[destination];
                topology.colorLink(destination + 1, stepAhead + 1);
            }

            dijkstraPathString = (sourceRouter + 1).ToString() + " -> " + toEndString;

        }

        public String showDijkstraPath()
        {
            return dijkstraPathString;
        }

        ///  DICKSTRYJEK end






        /// BFS start

        public struct BFSNode
        {
           public int number;
           public bool visited;
           public int parent;
           public int level;
        };

        public void BFSAlgorithm()
        {
            Stopwatch stopWatchBFS = new Stopwatch();

            stopWatchBFS.Start();

            /// Initialize components
            BFSPaths = new int[verticesCount];
            bool[,] graphBFS = new bool[verticesCount, verticesCount];
            int deepOfSearch = 15;
            int[,] levels = new int[deepOfSearch, verticesCount];
            int[] levelNumbersCounter = new int[deepOfSearch];

            for (int i = 0; i < verticesCount; i++)
                for (int j = 0; j < verticesCount; j++)
                {
                    graphBFS[i, j] = false;
                    if (topology.checkLinkBetween(i + 1, j + 1)) graphBFS[i, j] = true;
                    else if (topology.checkLinkBetween(j + 1, i + 1)) graphBFS[i, j] = true;
                    if (i < deepOfSearch)
                    {
                        levels[i, j] = -1;
                        levelNumbersCounter[i] = 0;
                    }
                }


            nodeTable = new BFSNode[verticesCount];
          

            for (int i = 0; i < verticesCount; i++)
            {
                nodeTable[i].number = i;
                nodeTable[i].visited = false;
                nodeTable[i].parent = -1;
                nodeTable[i].level = 0;

            }


            stopWatchBFS.Stop();

            BFSTimeData = stopWatchBFS.Elapsed;
            stopWatchBFS.Reset();

            stopWatchBFS.Start();

            int startPoint = sourceRouter;
            nodeTable[startPoint].visited = true;

            levels[0, 1] = sourceRouter;
            levelNumbersCounter[0] = 1;

            for (int level = 1; level < deepOfSearch; level++)
            {
                while (levelNumbersCounter[level - 1] != 0)
                {
                    startPoint = nodeTable[levels[level - 1, levelNumbersCounter[level - 1]--]].number;

                    for (int i = 0; i < verticesCount; i++)
                    {
                        if (graphBFS[startPoint, i] && nodeTable[i].visited == false)
                        {
                            levels[level, ++levelNumbersCounter[level]] = i;
                            nodeTable[i].visited = true;
                            nodeTable[i].parent = startPoint;
                            nodeTable[i].level = level;
                        }

                    }
                }
            }

            stopWatchBFS.Stop();
            BFSTime = stopWatchBFS.Elapsed;

            /// saving results
            for (int i = 0; i < verticesCount; i++)
                BFSPaths[i] = nodeTable[i].level;


        }

        public int[] getBFSPaths()
        {
            return BFSPaths;
        }


        public TimeSpan getBFSTime()
        {
            return BFSTime;
        }
        public TimeSpan getBFSTimeData()
        {
            return BFSTimeData;
        }



        public void colorLinksBFS()
        {
            topology.resetLinkColor();

            int stepAhead = destinationRouter;

            String addLastToEnd = (stepAhead+1).ToString();

            while (stepAhead != sourceRouter)
            {
                BFSPathString = " -> " + addLastToEnd;
                if (nodeTable[stepAhead].parent != destinationRouter)
                    topology.colorLink(stepAhead+1, nodeTable[stepAhead].parent+1);
                stepAhead = nodeTable[stepAhead].parent;

                addLastToEnd = (stepAhead+1).ToString() + BFSPathString;
            }

            BFSPathString = addLastToEnd;

        }

        public String showBFSPath()
        {
            return BFSPathString;
        }

        /// BFS end




        public void dataToCSV(FileStream fileStream, StreamWriter fileWriter)
        {

            fileWriter.Write("Destination router: ");
            fileWriter.Write((destinationRouter+1).ToString());
            fileWriter.WriteLine();
            fileWriter.WriteLine();
            fileWriter.Write("Path for F-W: ");
            fileWriter.Write(warshallPathString);
            fileWriter.WriteLine();
            fileWriter.Write("Path cost F-W: ");
            fileWriter.Write(System.Convert.ToDouble(warshallPaths[destinationRouter]));
            fileWriter.WriteLine();
            fileWriter.Write("Time of F-W [ms]: ");
            fileWriter.Write((System.Convert.ToDouble(getWarshallTime().Ticks) / 1000).ToString());
            fileWriter.WriteLine();

            //fileWriter.Write(warshallPaths[0].ToString());
            //if(pathCounter>0)
            //    for (int i = 1; i < pathCounter; i++)
            //    {
            //        fileWriter.Write(" -> ");
            //        fileWriter.Write(warshallPaths[i].ToString());
            //    }

            fileWriter.WriteLine();
            fileWriter.Write("Path for Bellman-Ford: ");
            fileWriter.Write(belmanPathString);
            fileWriter.WriteLine();
            fileWriter.Write("Path cost Bellman-Ford: ");
            fileWriter.Write(belmanPaths[destinationRouter]);
            fileWriter.WriteLine();
            fileWriter.Write("Time of Bellman-Ford [ms]: ");
            fileWriter.Write((System.Convert.ToDouble(getBellmanTime().Ticks) / 1000).ToString());
            fileWriter.WriteLine();
            fileWriter.WriteLine();
            fileWriter.Write("Path for dijksta: ");
            fileWriter.Write(dijkstraPathString);
            fileWriter.WriteLine();
            fileWriter.Write("Path cost dijksta: ");
            fileWriter.Write(dijkstraPaths[destinationRouter]);
            fileWriter.WriteLine();
            fileWriter.Write("Time of dijkstra [ms]: ");
            fileWriter.Write((System.Convert.ToDouble(getDijkstraTime().Ticks) / 1000).ToString());
            fileWriter.WriteLine();
            fileWriter.WriteLine();
            fileWriter.Write("Path for BFS: ");
            fileWriter.Write(BFSPathString);
            fileWriter.WriteLine();
            fileWriter.Write("Path cost BFS: ");
            fileWriter.Write(BFSPaths[destinationRouter]);
            fileWriter.WriteLine();
            fileWriter.Write("Time of BFS [ms]: ");
            fileWriter.Write((System.Convert.ToDouble(getBFSTime().Ticks) / 1000).ToString());
            fileWriter.WriteLine();
            fileWriter.WriteLine();

            int differenceRoutes = 0;
            if (belmanPathString.Contains(dijkstraPathString)) ;
            else if (belmanPathString.Contains(warshallPathString)) ;
            else if (belmanPathString.Contains(BFSPathString)) ;
            else differenceRoutes++;

            if (dijkstraPathString.Contains(warshallPathString)) ;
            else if (dijkstraPathString.Contains(BFSPathString)) ;
            else differenceRoutes++;

            if (warshallPathString.Contains(BFSPathString)) ;
            else differenceRoutes++;

            
            fileWriter.WriteLine();
            fileWriter.Write("Number of different paths: ");
            fileWriter.Write(differenceRoutes);

            fileWriter.WriteLine();
            fileWriter.WriteLine();
            fileWriter.WriteLine("-------------------------------------------------------");


        }







        public String resultToCSV()
        {
            
            int differenceRoutes = 0;

            if (belmanPathString.Contains(dijkstraPathString)) ;
            else if (belmanPathString.Contains(warshallPathString)) ;
            else if (belmanPathString.Contains(BFSPathString)) ;
            else differenceRoutes++;

            if (dijkstraPathString.Contains(warshallPathString)) ;
            else if (dijkstraPathString.Contains(BFSPathString)) ;
            else differenceRoutes++;

            if (warshallPathString.Contains(BFSPathString)) ;
            else differenceRoutes++;

            String results;

            results = (sourceRouter + 1).ToString() + ";"; ///1
            results += (destinationRouter + 1).ToString();
            results += ";"; ///2
            results += warshallPathString;
            results += ";"; ///3
            results += System.Convert.ToDouble(warshallPaths[destinationRouter]);
            results += ";"; ///4
            results += (System.Convert.ToDouble(getWarshallTime().Ticks) / 1000).ToString();
            results += ";"; ///5
            results += belmanPathString;
            results += ";"; ///6
            results += belmanPaths[destinationRouter];
            results += ";"; ///7
            results += (System.Convert.ToDouble(getBellmanTime().Ticks) / 1000).ToString();
            results += ";"; ///8
            results += dijkstraPathString;
            results += ";"; ///9
            results += dijkstraPaths[destinationRouter];
            results += ";"; ///10
            results += (System.Convert.ToDouble(getDijkstraTime().Ticks) / 1000).ToString();
            results += ";"; ///11
            results += BFSPathString;
            results += ";"; ///12
            results += BFSPaths[destinationRouter];
            results += ";"; ///13
            results += (System.Convert.ToDouble(getBFSTime().Ticks) / 1000).ToString();
            results += ";"; ///14
            results += differenceRoutes.ToString();
            results += ";"; ///15
            results += "\n";///endl
        
            return results;

        }





    }
}
