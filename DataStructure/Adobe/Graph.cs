using System.Collections.Generic;
using System.Linq;

namespace Adobe
{
    // Data Structure for AdjacenyList
    public class GraphNode<T>
    {
        // Index for storing the Node data index in Adjacency Matrix
        public int Index;

        // Generic NodeValue for storing the Node data (int or string)
        public T NodeValue;

        // Node weight for Adj List , will be zero for self node, and value for other nodes
        public int NodeWeight;

        public GraphNode(T nodeValue, int index)
        {
            NodeValue = nodeValue;
            Index = index;
        }
    }

    public class GraphEdge<T>
    {
        public GraphNode<T> SourceNode, DestinationNode;
        public int Weight;

        public GraphEdge(GraphNode<T> sourceNode, GraphNode<T> destinationNode, int nodeWeight)
        {
            SourceNode = sourceNode;
            DestinationNode = destinationNode;
            Weight = nodeWeight;
        }
    }

    public class GraphWithAdjList<T>
    {
        // https://www.techiedelight.com/graph-implementation-java-using-collections/
        // https://codereview.stackexchange.com/questions/131583/generic-graph-implementation-in-c
        public List<List<GraphNode<T>>> adjList = new List<List<GraphNode<T>>>();
        private readonly List<GraphNode<T>> vertices;

        public GraphWithAdjList(List<GraphEdge<T>> edgeList)
        {
            vertices = new List<GraphNode<T>>();

            for (var index = 0; index < edgeList.Count; index++) adjList.Add(new List<GraphNode<T>>());

            foreach (var edge in edgeList)
            {
                if (!vertices.Contains(edge.SourceNode))
                    vertices.Add(edge.SourceNode);
                if (!vertices.Contains(edge.DestinationNode))
                    vertices.Add(edge.DestinationNode);

                adjList[edge.SourceNode.Index].Add(edge.DestinationNode);
                // For undirected graph we can also edge from dest to src
                adjList[edge.DestinationNode.Index].Add(edge.SourceNode);
            }
        }

        public bool IsAdjacentNodes(GraphNode<T> sourceGraphNode, GraphNode<T> destinationGraphNode)
        {
            return adjList[sourceGraphNode.Index].Contains(destinationGraphNode);
        }

        public int GetEdgeDistance(GraphNode<T> sourceGraphNode, GraphNode<T> destinationGraphNode)
        {
            if (!IsAdjacentNodes(sourceGraphNode, destinationGraphNode))
                return -1;

            return adjList[sourceGraphNode.Index].Where(x => x.Index.Equals(destinationGraphNode.Index))
                .FirstOrDefault().NodeWeight;
        }
    }

    public class GraphWithAdjMatrix<T>
    {
        private readonly int[,] adjMatrix;

        private readonly int graphSize = 5;

        //https://simpledevcode.wordpress.com/2015/12/22/graphs-and-dijkstras-algorithm-c/
        private readonly List<GraphNode<T>> vertices;

        public GraphWithAdjMatrix(int graphSize)
        {
            vertices = new List<GraphNode<T>>();
            this.graphSize = graphSize;
            // not sure if this limit is good
            adjMatrix = new int[this.graphSize, this.graphSize];
        }

        public void AddEdge(GraphNode<T> sourceGraphNode, GraphNode<T> destinationGraphNode, int distance)
        {
            if (!vertices.Contains(sourceGraphNode)) vertices.Add(sourceGraphNode);

            if (!vertices.Contains(destinationGraphNode)) vertices.Add(destinationGraphNode);


            // For Adj Matrix approach NodeWeight is used as index of item in matrix.
            if (sourceGraphNode.Index >= 0 && destinationGraphNode.Index >= 0 &&
                sourceGraphNode.Index <= graphSize && sourceGraphNode.Index <= graphSize)
                adjMatrix[sourceGraphNode.Index, destinationGraphNode.Index] = distance;
        }

        public void RemoveEdge(GraphNode<T> sourceGraphNode, GraphNode<T> destinationGraphNode)
        {
            if (sourceGraphNode.Index > 0 && destinationGraphNode.Index > 0 &&
                sourceGraphNode.Index <= graphSize && sourceGraphNode.Index <= graphSize)
                adjMatrix[sourceGraphNode.Index, destinationGraphNode.Index] = 0;
        }

        public bool IsAdjacentNodes(GraphNode<T> sourceGraphNode, GraphNode<T> destinationGraphNode)
        {
            return adjMatrix[sourceGraphNode.Index, destinationGraphNode.Index] > 0;
        }

        public int GetEdgeDistance(GraphNode<T> sourceGraphNode, GraphNode<T> destinationGraphNode)
        {
            return adjMatrix[sourceGraphNode.Index, destinationGraphNode.Index];
        }
    }

    public class Vertex<T>
    {
        public Vertex(T value, params Vertex<T>[] parameters)
            : this(value, (IEnumerable<Vertex<T>>) parameters)
        {
        }

        public Vertex(T value, IEnumerable<Vertex<T>> neighbors = null)
        {
            Value = value;
            Neighbors = neighbors?.ToList() ?? new List<Vertex<T>>();
        }

        public T Value { get; set; } // can be made writable

        public List<Vertex<T>> Neighbors { get; }

        public int NeighborCount => Neighbors.Count;

        public void AddEdge(Vertex<T> vertex)
        {
            Neighbors.Add(vertex);
        }

        //
        // public void AddEdges(params Vertex<T>[] newNeighbors)
        // {
        //     Neighbors.AddRange(newNeighbors);
        // }
        //
        // public void AddEdges(IEnumerable<Vertex<T>> newNeighbors)
        // {
        //     Neighbors.AddRange(newNeighbors);
        // }
        //
        // public void RemoveEdge(Vertex<T> vertex)
        // {
        //     Neighbors.Remove(vertex);
        // }
    }

    public class GenericGraph<T>
    {
        public GenericGraph(params Vertex<T>[] initialNodes)
            : this((IEnumerable<Vertex<T>>) initialNodes)
        {
        }

        public GenericGraph(IEnumerable<Vertex<T>> initialNodes = null)
        {
            Vertices = initialNodes?.ToList() ?? new List<Vertex<T>>();
        }

        public List<Vertex<T>> Vertices { get; }

        public int Size => Vertices.Count;

        public void AddPair(Vertex<T> first, Vertex<T> second)
        {
            AddToList(first);
            AddToList(second);
            AddNeighbors(first, second);
        }

        private void AddToList(Vertex<T> vertex)
        {
            if (!Vertices.Contains(vertex)) Vertices.Add(vertex);
        }

        private void AddNeighbors(Vertex<T> first, Vertex<T> second)
        {
            AddNeighbor(first, second);

            // Uncomment when undirected graph to be created
            // AddNeighbor(second, first);
        }

        private void AddNeighbor(Vertex<T> first, Vertex<T> second)
        {
            if (!first.Neighbors.Contains(second)) first.AddEdge(second);
        }
    }
}