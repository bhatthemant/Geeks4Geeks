using System;
using System.Collections.Generic;
using System.Linq;

namespace Graphs
{
    public class Vertex<T>
    {
        public Vertex(T value, params Vertex<T>[] parameters)
            : this(value, (IEnumerable<Vertex<T>>)parameters)
        {
        }

        public Vertex(T value, IEnumerable<Vertex<T>> neighbors = null)
        {
            Value = value;
            Neighbors = neighbors?.ToList() ?? new List<Vertex<T>>();
        }

        public T Value { get; set; } // can be made writable

        public int Weight { get; set; } // Weight of the Edge

        public List<Vertex<T>> Neighbors { get; }

        public int NeighborCount => Neighbors.Count;

        public void AddEdge(Vertex<T> vertex)
        {
            Neighbors.Add(vertex);
        }

        public void AddEdges(params Vertex<T>[] newNeighbors)
        {
            Neighbors.AddRange(newNeighbors);
        }

        public void AddEdges(IEnumerable<Vertex<T>> newNeighbors)
        {
            Neighbors.AddRange(newNeighbors);
        }

        public void RemoveEdge(Vertex<T> vertex)
        {
            Neighbors.Remove(vertex);
        }
    }

    public class GenericGraph<T>
    {
        public GenericGraph(params Vertex<T>[] initialNodes)
            : this((IEnumerable<Vertex<T>>)initialNodes)
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

        public void BreadthFirstTraversal(Vertex<T> startVertex)
        {
            if (!Vertices.Contains(startVertex))
            {
                Console.WriteLine("No such vertex found.");
                return;
            }

            Queue<Vertex<T>> vertexQueue = new Queue<Vertex<T>>();
            List<Vertex<T>> visitedVertices = new List<Vertex<T>>();

            vertexQueue.Enqueue(startVertex);

            while (vertexQueue.Count > 0)
            {
                var currentVertex = vertexQueue.Dequeue();

                if (!visitedVertices.Contains(currentVertex))
                {
                    Console.WriteLine(currentVertex.Value);
                    visitedVertices.Add(currentVertex);

                    foreach (var neighbour in currentVertex.Neighbors)
                    {
                        vertexQueue.Enqueue(neighbour);
                    }
                }
            }
        }

        // https://www.hackerearth.com/practice/algorithms/graphs/breadth-first-search/practice-problems/algorithm/bfs/
        /*You have been given a Tree consisting of N nodes.
         * A tree is a fully-connected graph consisting of N nodes and edges. 
         * The nodes in this tree are indexed from 1 to N. 
         * Consider node indexed 1 to be the root node of this tree.
         * The root node lies at level one in the tree. 
         * You shall be given the tree and a single integer x.
         * You need to find out the number of nodes lying on level x. */
        public void NodeAtLevel(Vertex<T> startVertex, int nodeLevel)
        {
            int currentLevel = 1;

            if (!Vertices.Contains(startVertex))
            {
                Console.WriteLine("No such vertex found.");
                return;
            }

            Queue<Vertex<T>> vertexQueue = new Queue<Vertex<T>>();
            List<Vertex<T>> visitedVertices = new List<Vertex<T>>();
            Dictionary<Vertex<T>, int> vertexLevel = new Dictionary<Vertex<T>, int>();

            vertexQueue.Enqueue(startVertex);
            vertexLevel.Add(startVertex, currentLevel);
            while (vertexQueue.Count > 0)
            {
                var currentVertex = vertexQueue.Dequeue();
                if (!visitedVertices.Contains(currentVertex))
                {
                    // Console.WriteLine(currentVertex.Value);
                    visitedVertices.Add(currentVertex);
                    foreach (var neighbour in currentVertex.Neighbors)
                    {
                        var currentVertexLevel = vertexLevel[currentVertex];
                        vertexLevel[neighbour] = ++currentVertexLevel;
                        vertexQueue.Enqueue(neighbour);
                    }
                }
            }

            Console.WriteLine($"Node at level {nodeLevel} is { vertexLevel.Values.Where(x => x.Equals(nodeLevel)).Count()}");
        }
    }


}