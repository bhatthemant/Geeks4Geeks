using System.Collections.Generic;

namespace Adobe
{
    public class ShortestPathAlgo
    {
        // Dijkstra

        public void DijkstraShortestPath(GenericGraph<string> graph, Vertex<string> sourceNode)
        {
            var nodeDistancDict = new Dictionary<Vertex<string>, int>();
            var vertexQueue = new Queue<Vertex<string>>();

            nodeDistancDict[sourceNode] = 0;

            foreach (var graphNode in graph.Vertices)
            {
                if (graphNode != sourceNode) nodeDistancDict[graphNode] = int.MaxValue;

                vertexQueue.Enqueue(graphNode);
            }

            while (vertexQueue.Count > 0)
            {
                // foreach (var VARIABLE in COLLECTION)
                // {
                // }
            }
        }
    }
}