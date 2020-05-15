using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Adobe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Graph

            /*

            // List<GraphEdge<int>> edges = new List<GraphEdge<int>>
            // {
            //     new GraphEdge<int>(0, 1, 6), new GraphEdge<int>(1, 2, 7),
            //     new GraphEdge<int>(2, 0, 5), new GraphEdge<int>(2, 1, 4),
            //     new GraphEdge<int>(3, 2, 10)
            // };

            // GraphWithAdjList<int> graphImpl = new GraphWithAdjList<int>(edges);

            // List<GraphEdge<string>> edges = new List<GraphEdge<string>>
            // {
            //     new GraphEdge<string>("a", "b", 6), new GraphEdge<string>("b", "c", 7),
            //     new GraphEdge<string>("c", "a", 5), new GraphEdge<string>("c", "b", 4),
            //     new GraphEdge<string>("d", "c", 10)
            // };
            //
            // GraphWithAdjList<string> graphImpl = new GraphWithAdjList<string>(edges);
            //
            // GraphWithAdjMatrix<string> graphWithAdjMatrix = new GraphWithAdjMatrix<string>();    
            //
            // var aNode = new GraphNode<string>("a", 0);
            // var bNode = new GraphNode<string>("b", 1);
            // var cNode = new GraphNode<string>("c", 2);
            // var dNode = new GraphNode<string>("d", 3);
            //
            // graphWithAdjMatrix.AddEdge(aNode, bNode, 6);
            // graphWithAdjMatrix.AddEdge(bNode, cNode, 7);
            // graphWithAdjMatrix.AddEdge(cNode, aNode, 5);
            // graphWithAdjMatrix.AddEdge(cNode, bNode, 4);
            // graphWithAdjMatrix.AddEdge(dNode, cNode, 10);

            Vertex<string> aVertex = new Vertex<string>("a");
            Vertex<string> bVertex = new Vertex<string>("b");
            Vertex<string> cVertex = new Vertex<string>("c");
            Vertex<string> dVertex = new Vertex<string>("d");


            GenericGraph<string> genericGraph = new GenericGraph<string>();
            genericGraph.AddPair(aVertex, bVertex);
            genericGraph.AddPair(bVertex, cVertex);
            genericGraph.AddPair(cVertex, aVertex);
            genericGraph.AddPair(cVertex, bVertex);
            genericGraph.AddPair(dVertex, cVertex);
            
            */

            // BST 

            /*
            BST binarySearchTree = null;
            binarySearchTree = BSTHelper.Insert(binarySearchTree, 8);
            BSTHelper.Insert(binarySearchTree, 1);
            BSTHelper.Insert(binarySearchTree, 4);
            BSTHelper.Insert(binarySearchTree, 3);
            BSTHelper.Insert(binarySearchTree, 7);
            BSTHelper.Insert(binarySearchTree, 6);
            BSTHelper.Insert(binarySearchTree, 10);
            BSTHelper.Insert(binarySearchTree, 14);
            BSTHelper.Insert(binarySearchTree, 9);
            BSTHelper.Insert(binarySearchTree, 13);

            int nodeDistance = 2;

            // binarySearchTree = BSTHelper.InsertWithDistance(binarySearchTree, 8, nodeDistance);
            // BSTHelper.InsertWithDistance(binarySearchTree, 1, nodeDistance);
            // BSTHelper.InsertWithDistance(binarySearchTree, 4, nodeDistance);
            // BSTHelper.InsertWithDistance(binarySearchTree, 3, nodeDistance);
            // BSTHelper.InsertWithDistance(binarySearchTree, 7, nodeDistance);
            // BSTHelper.InsertWithDistance(binarySearchTree, 6, nodeDistance);
            // BSTHelper.InsertWithDistance(binarySearchTree, 10, nodeDistance);
            // BSTHelper.InsertWithDistance(binarySearchTree, 14, nodeDistance);
            // BSTHelper.InsertWithDistance(binarySearchTree, 9, nodeDistance);
            // BSTHelper.InsertWithDistance(binarySearchTree, 13, nodeDistance);


            //BSTHelper.Inorder(binarySearchTree);

            //  Console.WriteLine(BSTHelper.CheckForBSTViaList(binarySearchTree));

            // Console.WriteLine(BSTHelper.IsBST(binarySearchTree, Int32.MinValue, Int32.MaxValue));
            //  var node = BSTHelper.SearchNode(binarySearchTree,7);
            //node.NodeValue = 11;

            // Console.WriteLine(BSTHelper.CheckForBSTViaList(binarySearchTree));
            //Console.WriteLine(BSTHelper.IsBST(binarySearchTree, Int32.MinValue, Int32.MaxValue));

            Console.WriteLine($"Minimum value in BST : {BSTHelper.FindMin(binarySearchTree)}");
            Console.WriteLine($"Maximum value in BST : {BSTHelper.FindMax(binarySearchTree)}");
            
            
            */


            // Linked List


            LinkedList linkedList = new LinkedList();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            linkedList.AddLast(6);
            linkedList.AddLast(7);
            linkedList.AddLast(8);
            linkedList.AddLast(9);
            // linkedList.AddLast(3);
            // linkedList.AddLast(2);
            // linkedList.AddLast(1);

            Console.WriteLine($"Is linked list palindrome : {LinkedListHelper.IsPalindrome(linkedList.Head)}");


            linkedList.TraverseAll();

            // Console.WriteLine($"Linked List has a Cycle : {LinkedListHelper.DetectLoopWithHash(linkedList.Head)}");
            // Console.WriteLine($"Linked List has a Cycle : {LinkedListHelper.DetectLoopWithFloydCycle(linkedList.Head)}");

            // Add a Cycle
            // linkedList.Head.Next.Next.Next.Next = linkedList.Head.Next;

            // Detect a Cycle

            // Console.WriteLine($"Linked List has a Cycle : {LinkedListHelper.DetectLoopWithHash(linkedList.Head)}");
            // Console.WriteLine($"Linked List has a Cycle : {LinkedListHelper.DetectLoopWithFloydCycle(linkedList.Head)}");

            // Find middle element
            // Console.WriteLine($"Middle element is : {LinkedListHelper.GetMiddleWithCounter(linkedList.Head)}");
            // Console.WriteLine($"Middle element is : {LinkedListHelper.GetMiddleWithTwoPointer(linkedList.Head)}");
            //Console.WriteLine($"Middle element is : {LinkedListHelper.GetMiddleWithEvenOdd(linkedList.Head)}");

            //Reveres LinkedList
            // LinkedListHelper.ReverseWithInsertAtFront(linkedList.Head);
            //LinkedListHelper.Reverse(linkedList.Head);

            // Nth node from last

            Console.WriteLine(
                $"Element from last :  {LinkedListHelper.NthNodeFromEndDoubleIteration(linkedList.Head, 2).Data}");
            Console.WriteLine(
                $"Element from last :  {LinkedListHelper.NthNodeFromEndSingleIteration(linkedList.Head, 2).Data}");


            /*
             
            // Binary Tree

            BinaryTree binaryTree = new BinaryTree(1);
            binaryTree.RootNode.Left = new BinaryTreeNode(2);
            binaryTree.RootNode.Right = new BinaryTreeNode(3);
            binaryTree.RootNode.Left.Left = new BinaryTreeNode(4);
            binaryTree.RootNode.Left.Right = new BinaryTreeNode(5);
            binaryTree.RootNode.Right.Left = new BinaryTreeNode(6);
            binaryTree.RootNode.Right.Right = new BinaryTreeNode(7);

            BinaryTreeHelper.LevelOrderTraversal(binaryTree.RootNode);

            Console.WriteLine("Enter level order values : ");
            string[] arr = Console.ReadLine().Split(" ");
            BinaryTree binaryTree1 = new BinaryTree();
            BinaryTreeHelper.CreateTree(binaryTree1.RootNode, arr);
            BinaryTreeHelper.LevelOrderTraversal(binaryTree1.RootNode);
                        
             */

            // Array


            //Trapped Water
            //Arrays.TrappedWater();
            //Arrays.MaxContigiuosArray();
        }
    }
}