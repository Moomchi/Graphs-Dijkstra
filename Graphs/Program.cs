﻿namespace Graphs
{
    class Program
    {
        public static void Main()
        {
            // Ребрата на графа и съответните теглови коефициенти
            int[,] graph = new int[,]
            {
                { 0, 4, 2, 1, 0, 0, 0, 0, 0, 0, 0 },
                { 4, 0, 7, 0, 0, 0, 0, 0, 2, 0, 0 },
                { 2, 7, 0, 0, 0, 0, 0, 0, 8, 0, 0 },
                { 1, 0, 0, 0, 3, 0, 0, 12, 0, 0, 0 },
                { 0, 0, 0, 3, 0, 3, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 3, 0, 2, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 2, 0, 3, 0, 0, 8 },
                { 0, 0, 0, 12, 0, 0, 3, 0, 3, 0, 4 },
                { 0, 2, 8, 0, 0, 0, 0, 3, 0, 17, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0, 17, 0, 5 },
                { 0, 0, 0, 0, 0, 0, 8, 4, 0, 5, 0 },
            };

            var graphs = new DijkstraGraph();

            graphs.NodesCount = graph.GetLength(0);
            graphs.Dijkstra(graph, 0);
        }
    }
}