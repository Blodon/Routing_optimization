using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Routing_Optimization.Algorithms
{
    class FloydWarshallAlgo
    {
        public const int cst = 9999;

        public FloydWarshallAlgo(Topology topology)
        {
        }

        private static String Print(int[,] distance, int verticesCount)
        {
            String kekun;
            kekun ="Shortest distances between every pair of vertices:";

            for (int i = 0; i < verticesCount; ++i)
            {
                for (int j = 0; j < verticesCount; ++j)
                {
                    if (distance[i, j] == cst)
                        kekun = "cst";
                    else
                        kekun = distance[i, j].ToString();
                }

                kekun =  "\n";
            }

            return kekun;
        }

        new public static String FloydWarshall(int[,] graph, int verticesCount)
        {
            int[,] distance = new int[verticesCount, verticesCount];

            for (int i = 0; i < verticesCount; ++i)
                for (int j = 0; j < verticesCount; ++j)
                    distance[i, j] = graph[i, j];

            for (int k = 0; k < verticesCount; ++k)
            {
                for (int i = 0; i < verticesCount; ++i)
                {
                    for (int j = 0; j < verticesCount; ++j)
                    {
                        if (distance[i, k] + distance[k, j] < distance[i, j])
                            distance[i, j] = distance[i, k] + distance[k, j];
                    }
                }
            }

            return Print(distance, verticesCount);
        }
        //static void Main(string[] args)
        //{
        //    int[,] graph = {
        //                 { 0,   6,  cst, 11 },
        //                 { cst, 0,   4, cst },
        //                 { cst, cst, 0,   2 },
        //                 { cst, cst, cst, 0 }
        //                   };

        //    FloydWarshall(graph, 4);
        //}
    }
}
