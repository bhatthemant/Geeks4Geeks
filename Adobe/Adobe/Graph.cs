using System.Collections.Generic;

namespace Adobe
{
    // Data Structure for AdjacenyList
    public class GraphNode<T>
    {
        public T NodeValue;

        // For Adj Matrix approach this is used as index of item in matrix.
        public int NodeWeight;

        public GraphNode(T nodeValue, int nodeWeight)
        {
            this.NodeValue = nodeValue;
            this.NodeWeight = nodeWeight;
        }
    }

    public class GraphEdge<T>
    {
        public T SourceNode, DestinationNode;
        public int Weight;

        public GraphEdge(T sourceNode, T destinationNode, int nodeWeight)
        {
            this.SourceNode = sourceNode;
            this.DestinationNode = destinationNode;
            this.Weight = nodeWeight;
        }
    }

    public class GraphWithAdjList<T>
    {
        // https://www.techiedelight.com/graph-implementation-java-using-collections/
        // https://codereview.stackexchange.com/questions/131583/generic-graph-implementation-in-c
        private List<LinkedList> adjList = new List<LinkedList>();

        public GraphWithAdjList(List<GraphEdge<T>> edgeList)
        {
            for (int index = 0; index < edgeList.Count; index++)
            {
                adjList.Add(new LinkedList());
            }

            int count = 0;
            foreach (var edge in edgeList)
            {
                adjList[count].Head.Data = new GraphNode<object>(edge.SourceNode, edge.Weight);
                adjList[count].AddLast(edge.DestinationNode);

                count++;

                // For undirected graph we can also edge from dest to src
                //adjList[edge.dest].Add(new GraphNode<int>(edge.src, edge.weight));
            }
        }
    }

    public class GraphWithAdjMatrix<T>
    {
        //https://simpledevcode.wordpress.com/2015/12/22/graphs-and-dijkstras-algorithm-c/
        private List<GraphNode<T>> vertices;
        private int graphSize = 5;
        private int[,] adjMatrix;

        public GraphWithAdjMatrix()
        {
            vertices = new List<GraphNode<T>>();
            // not sure if this limit is good
            adjMatrix = new int[graphSize, graphSize];
        }

        public void AddEdge(GraphNode<T> sourceGraphNode, GraphNode<T> destinationGraphNode, int distance)
        {
            if (!vertices.Contains(sourceGraphNode))
            {
                vertices.Add(sourceGraphNode);
            }

            if (!vertices.Contains(destinationGraphNode))
            {
                vertices.Add(destinationGraphNode);
            }


            // For Adj Matrix approach NodeWeight is used as index of item in matrix.
            if (sourceGraphNode.NodeWeight >= 0 && destinationGraphNode.NodeWeight >= 0 &&
                sourceGraphNode.NodeWeight <= graphSize && sourceGraphNode.NodeWeight <= graphSize)
            {
                adjMatrix[sourceGraphNode.NodeWeight, destinationGraphNode.NodeWeight] = distance;
            }
        }

        public void RemoveEdge(GraphNode<T> sourceGraphNode, GraphNode<T> destinationGraphNode)
        {
            if (sourceGraphNode.NodeWeight > 0 && destinationGraphNode.NodeWeight > 0 &&
                sourceGraphNode.NodeWeight <= graphSize && sourceGraphNode.NodeWeight <= graphSize)
            {
                adjMatrix[sourceGraphNode.NodeWeight, destinationGraphNode.NodeWeight] = 0;
            }
        }
    }
}