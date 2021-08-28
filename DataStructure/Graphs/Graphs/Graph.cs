using System.Collections.Generic;
using System.Linq;

namespace Graphs
{ 
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