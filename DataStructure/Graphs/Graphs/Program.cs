namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericGraph<int> genericGraph = new GenericGraph<int>();

            var vertex10 = new Vertex<int>(value: 10);
            var vertex1 = new Vertex<int>(value: 1);
            var vertex2 = new Vertex<int>(value: 2);
            var vertex3 = new Vertex<int>(value: 3);
            var vertex4 = new Vertex<int>(value: 4);
            var vertex5 = new Vertex<int>(value: 5);
            var vertex6 = new Vertex<int>(value: 6);
            var vertex7 = new Vertex<int>(value: 7);
            var vertex8 = new Vertex<int>(value: 8); 
            var vertex9 = new Vertex<int>(value: 9); 
            var vertex11 = new Vertex<int>(value: 11); 
            var vertex12 = new Vertex<int>(value: 12);
            var vertex13 = new Vertex<int>(value: 13);
            var vertex14 = new Vertex<int>(value: 14);
            var vertex15 = new Vertex<int>(value: 15);
            var vertex16 = new Vertex<int>(value: 16);
            var vertex17 = new Vertex<int>(value: 17);
            var vertex18 = new Vertex<int>(value: 18);
            var vertex19 = new Vertex<int>(value: 19);
            var vertex20 = new Vertex<int>(value: 20);

            genericGraph.AddPair(vertex11,vertex1);
            genericGraph.AddPair(vertex1, vertex2);
            genericGraph.AddPair(vertex13, vertex3);
            genericGraph.AddPair(vertex15, vertex4);
            genericGraph.AddPair(vertex17, vertex5);
            genericGraph.AddPair(vertex11, vertex6);
            genericGraph.AddPair(vertex2, vertex7);
            genericGraph.AddPair(vertex1, vertex8);
            genericGraph.AddPair(vertex15, vertex9); 
            genericGraph.AddPair(vertex4, vertex10);
            genericGraph.AddPair(vertex15, vertex12);
            genericGraph.AddPair(vertex5, vertex13);
            genericGraph.AddPair(vertex2, vertex14);
            genericGraph.AddPair(vertex17, vertex15);
            genericGraph.AddPair(vertex15, vertex16);
            genericGraph.AddPair(vertex11, vertex17);
            genericGraph.AddPair(vertex15, vertex18);
            genericGraph.AddPair(vertex9, vertex19);
            genericGraph.AddPair(vertex16, vertex20);

            //genericGraph.BreadthFirstTraversal(vertex1);
            genericGraph.NodeAtLevel(vertex1, 2);
        }
    }
}
