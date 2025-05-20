using System;
using System.Collections.Generic;
using System.Diagnostics;

class DijkstraShortestPath
{
    static void Main()
    {
        // no of vertices
        int V = 5;

        //adjacency matrix for 5 node graph
        int[,] graph = {
            {0, 10, 0, 0, 10 },
            {10, 0, 0, 0, 0 },
            {0, 10, 0, 20, 10 },
            {10, 0, 20, 0, 60 },
            {10, 0, 10, 40, 0 }
        };


        // starting form node 0
        int source = 0;
        Dijkstra(graph, V, source);
    }
    static void Dijkstra(int[,] graph, int V, int src)
    {
        int[] dist = new int[V];
        bool[] visited = new bool[V];
        int[] parent = new int[V];

        for(int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
            parent[i] = -1;
        }

        dist[src] = 0;
        for (int count = 0; count < V -1; count++)
        {
            int u = MinDistance(dist, visited, V);
            visited[u] = true;

            for (int v = 0; v < V; v++)
            {
                if (!visited[v] && graph[u, v] > 0 && dist[u] + graph[u, v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                    parent[v] = u;
                }

            }
        }
        PrintSolution(dist, parent, src, V);
    }
    static int MinDistance(int[] dist, bool[] visited, int V)
    {
        int min = int.MaxValue, minIndex = -1;

        for(int v = 0; v < V; v++)
        {
            if (!visited[v] && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }
            
        }
        return minIndex;
    }

    static void PrintSolution(int[] dist, int[] parent, int src, int V)
    {
        Console.WriteLine("Node\tDistance\tPath");
        for (int i = 0; i < V; i++)
        {
            Console.Write($"{src} -> {i}\t{dist[i]}\t\t");
            PrintPath(parent, i);
            Console.WriteLine();
        }
    }

    static void PrintPath(int[] parent, int j)
    {
        if (parent[j] == -1)
        {
            Console.Write(j);
            return;
        }

        PrintPath(parent, parent[j]);
        Console.Write(" -> " + j);
    }
    
}