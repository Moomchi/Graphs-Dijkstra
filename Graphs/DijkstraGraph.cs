namespace Graphs
{
    public class DijkstraGraph
    {
        public int NodesCount { get; set; }

        public void Dijkstra(int[,] graph, int src)
        {
            // Най-кратко разстояние от src до върховете
            int[] dist = new int[NodesCount];

            // True, ако i върха е включен в масива с най-кратки пътища (обработен)
            bool[] nodeSet = new bool[NodesCount];

            // Инициализиране на всички разстояния с макс. стойност
            // и всички стойности за обработеност с false
            for (int i = 0; i < NodesCount; i++)
            {
                dist[i] = int.MaxValue;
                nodeSet[i] = false;
            }

            // Разстоянието от началото до себе си винаги е 0
            dist[src] = 0;

            // Намиране на най-краткия път за всеки връх
            for (int count = 0; count < NodesCount - 1; count++)
            {
                // Взимане на връх с най-кратък път от тези, които все още не са обработени 
                int u = MinDistance(dist, nodeSet);

                // Маркиране на взетия връх като обработен
                nodeSet[u] = true;

                // Update на dist стойността на съсведните върхове на взетия по-горе
                for (int v = 0; v < NodesCount; v++)
                {
                    // Update dist[v] само ако все още не е обработена в nodeSet,
                    // има ребро между връх u и v
                    // и общата теглова стойност на пътя от началото до v, минавайки през u, е по-малка от текущата в dist[v]
                    if (!nodeSet[v]
                        && graph[u, v] != 0
                        && dist[u] != int.MaxValue
                        && dist[u] + graph[u, v] < dist[v])
                    {
                        dist[v] = dist[u] + graph[u, v];
                    }
                }
            }

            // Принтиране на получената дистанция
            PrintSolution(dist);
        }

        private int MinDistance(int[] dist, bool[] sptSet)
        {
            int min = int.MaxValue, min_index = -1;

            for (int v = 0; v < NodesCount; v++)
            {
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }
            }

            return min_index;
        }

        private void PrintSolution(int[] dist)
        {
            Console.Write("Vertex \t\t Distance "+ "from Source\n");
            for (int i = 0; i < NodesCount; i++)
            {
                Console.Write(i + " \t\t " + dist[i] + "\n");
            }
        }
    }
}