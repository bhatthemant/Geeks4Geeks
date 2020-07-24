using System;
using Adobe.Algorithms.Sorting;

namespace Adobe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Graph

            // Create Nodes

            // GraphNode<string> mallibu = new GraphNode<string>("Mallibu", 0);
            // GraphNode<string> santaBarbara = new GraphNode<string>("SantaBarbara", 1);
            // GraphNode<string> losAngeles = new GraphNode<string>("LosAngeles", 2);
            // GraphNode<string> barstow = new GraphNode<string>("Barstow", 3);
            // GraphNode<string> sanDiego = new GraphNode<string>("SanDiego", 4);
            // GraphNode<string> riverSide = new GraphNode<string>("RiverSide", 5);
            // GraphNode<string> palmSprings = new GraphNode<string>("PalmSprings", 6);
            // GraphNode<string> elCajon = new GraphNode<string>("ElCajon", 7);

            // Create Edges

            // GraphEdge<string> msb = new GraphEdge<string>(mallibu, santaBarbara, 45);
            // GraphEdge<string> mla = new GraphEdge<string>(mallibu, losAngeles, 20);
            // GraphEdge<string> lsb = new GraphEdge<string>(losAngeles, santaBarbara, 30);
            // GraphEdge<string> ssb = new GraphEdge<string>(santaBarbara, barstow, 45);
            // GraphEdge<string> lar = new GraphEdge<string>(losAngeles, riverSide, 25);
            // GraphEdge<string> lsd = new GraphEdge<string>(losAngeles, sanDiego, 100);
            // GraphEdge<string> bar = new GraphEdge<string>(barstow, riverSide, 75);
            // GraphEdge<string> sdr = new GraphEdge<string>(sanDiego, riverSide, 90);
            // GraphEdge<string> sed = new GraphEdge<string>(sanDiego, elCajon, 15);
            // GraphEdge<string> rps = new GraphEdge<string>(riverSide, palmSprings, 75);
            //
            // List<GraphEdge<string>> edgeList = new List<GraphEdge<string>>()
            //     {msb, mla, lsb, ssb, lar, lsd, bar, sdr, sed, rps};
            //
            // GraphWithAdjList<string> graphAdjList = new GraphWithAdjList<string>(edgeList);
            //
            // Console.WriteLine(
            //     $"Distance between mallibu and losAngeles : {graphAdjList.GetEdgeDistance(mallibu, losAngeles)}");
            // Console.WriteLine(
            //     $"Distance between sanDiego and losAngeles : {graphAdjList.GetEdgeDistance(losAngeles, sanDiego)}");
            //
            // Console.WriteLine(
            //     $"Distance between mallibu and palmSprings : {graphAdjList.GetEdgeDistance(mallibu, palmSprings)}");
            //
            //
            // GraphWithAdjMatrix<string> graphAjdMatrix = new GraphWithAdjMatrix<string>(8);
            // graphAjdMatrix.AddEdge(mallibu, santaBarbara, 45);
            // graphAjdMatrix.AddEdge(mallibu, losAngeles, 20);
            // graphAjdMatrix.AddEdge(losAngeles, santaBarbara, 30);
            // graphAjdMatrix.AddEdge(santaBarbara, barstow, 45);
            // graphAjdMatrix.AddEdge(losAngeles, riverSide, 25);
            // graphAjdMatrix.AddEdge(losAngeles, sanDiego, 100);
            // graphAjdMatrix.AddEdge(barstow, riverSide, 75);
            // graphAjdMatrix.AddEdge(sanDiego, riverSide, 90);
            // graphAjdMatrix.AddEdge(sanDiego, elCajon, 15);
            // graphAjdMatrix.AddEdge(riverSide, palmSprings, 75);
            //
            // Console.WriteLine(
            //     $"Distance between mallibu and losAngeles : {graphAjdMatrix.GetEdgeDistance(mallibu, losAngeles)}");
            // Console.WriteLine(
            //     $"Distance between sanDiego and losAngeles : {graphAjdMatrix.GetEdgeDistance(losAngeles, sanDiego)}");
            // Console.WriteLine(
            //     $"Distance between mallibu and palmSprings : {graphAjdMatrix.GetEdgeDistance(mallibu, palmSprings)}");


            // /*

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

            // Vertex<string> aVertex = new Vertex<string>("a");
            // Vertex<string> bVertex = new Vertex<string>("b");
            // Vertex<string> cVertex = new Vertex<string>("c");
            // Vertex<string> dVertex = new Vertex<string>("d");
            //
            //
            // GenericGraph<string> genericGraph = new GenericGraph<string>();
            // genericGraph.AddPair(aVertex, bVertex);
            // genericGraph.AddPair(bVertex, cVertex);
            // genericGraph.AddPair(cVertex, aVertex);
            // genericGraph.AddPair(cVertex, bVertex);
            // genericGraph.AddPair(dVertex, cVertex);

            // */

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


            /*

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

           // Console.WriteLine($"Is linked list palindrome : {LinkedListHelper.IsPalindrome(linkedList.Head)}");

           linkedList.TraverseAll();

           // Console.WriteLine($"Linked List has a Cycle : {LinkedListHelper.DetectLoopWithHash(linkedList.Head)}");
           // Console.WriteLine(
           //     $"Linked List has a Cycle : {LinkedListHelper.DetectLoopWithFloydCycle(linkedList.Head)}");

           // Add a Cycle
           // linkedList.Head.Next.Next.Next.Next = linkedList.Head.Next;

           // Detect a Cycle

           // Console.WriteLine($"Linked List has a Cycle : {LinkedListHelper.DetectLoopWithHash(linkedList.Head)}");
           // Console.WriteLine(
           //     $"Linked List has a Cycle : {LinkedListHelper.DetectLoopWithFloydCycle(linkedList.Head)}");

           // Remove a cycle

           //  LinkedListHelper.RemoveCycle(linkedList.Head);

           // Console.WriteLine($"Linked List has a Cycle : {LinkedListHelper.DetectLoopWithHash(linkedList.Head)}");
           // Console.WriteLine(
           //     $"Linked List has a Cycle : {LinkedListHelper.DetectLoopWithFloydCycle(linkedList.Head)}");

           // Find middle element
           // Console.WriteLine($"Middle element is : {LinkedListHelper.GetMiddleWithCounter(linkedList.Head)}");
           // Console.WriteLine($"Middle element is : {LinkedListHelper.GetMiddleWithTwoPointer(linkedList.Head)}");
           //Console.WriteLine($"Middle element is : {LinkedListHelper.GetMiddleWithEvenOdd(linkedList.Head)}");

           //Reveres LinkedList
           // LinkedListHelper.ReverseWithInsertAtFront(linkedList.Head);
           //LinkedListHelper.Reverse(linkedList.Head);

           // Nth node from last

           // Console.WriteLine(
           //     $"Element from last :  {LinkedListHelper.NthNodeFromEndDoubleIteration(linkedList.Head, 2).Data}");
           // Console.WriteLine(
           //     $"Element from last :  {LinkedListHelper.NthNodeFromEndSingleIteration(linkedList.Head, 2).Data}");

           // Delete node with out header
           // LinkedListHelper.DeleteNodeWithoutHead(linkedList.Head.Next.Next.Next);
           // linkedList.TraverseAll();

           // Rotate LinedList
           linkedList.Head = LinkedListHelper.RotateLinkedList(linkedList.Head, 3);
           linkedList.TraverseAll();

            */

            /*
            // Binary Tree

            // BinaryTree binaryTree = new BinaryTree(1);
            // binaryTree.RootNode.Left = new BinaryTreeNode(2);
            // binaryTree.RootNode.Right = new BinaryTreeNode(3);
            // binaryTree.RootNode.Left.Left = new BinaryTreeNode(4);
            // binaryTree.RootNode.Left.Right = new BinaryTreeNode(5);
            // binaryTree.RootNode.Right.Left = new BinaryTreeNode(6);
            // binaryTree.RootNode.Right.Right = new BinaryTreeNode(7);
            //
            // BinaryTreeHelper.LevelOrderTraversal(binaryTree.RootNode);

            Console.WriteLine("Enter level order values : ");
            string[] arr = Console.ReadLine().Split(" ");
            BinaryTree binaryTree1 = new BinaryTree();
            BinaryTreeHelper.CreateTree(binaryTree1.RootNode, arr);
            // BinaryTreeHelper.LevelOrderTraversal(binaryTree1.RootNode);
            // BinaryTree tree2 = new BinaryTree();
            // BinaryTreeHelper.TreeCreate(tree2.RootNode, arr);
            //BinaryTreeHelper.PrintNodeWithOutSibling(tree2.RootNode);

            BinaryTree binaryTree2 = new BinaryTree();
            Console.WriteLine(
                $"Height of the tree : {BinaryTreeHelper.GetHeight(binaryTree1.RootNode)}"); // For a case where tree is already constructed we can recursively call GetHeight fio Left and right subtree and return of MAX of both the results.

            BinaryTreeHelper.MirrorTree(binaryTree1.RootNode);
*/

            // Array


            //Trapped Water
            //Arrays.TrappedWater();
            // Arrays.MaxContigiuosArray(new int[] {1,2,3,-2,5});
            //Arrays.MaxContigiuosArray(new int[] {0,0,0});
            //Arrays.MaxContigiuosArray(new int[] {-7,-8,-3,-4});
            // Arrays.MissingNumbers(new int[] {1,2,3,5});
            // Arrays.MissingNumbers(new int[] {1,2,3,4,5,6,7,8,10});
            // Arrays.MissingNumbers(new int[] {1,2,4,6,3,7,8});
           // Arrays.ReArrangeAlternatively(new int[] {1, 2,3, 4, 5, 6});
            Arrays.ReArrangeAlternatively(new int[] {1, 2, 3, 4, 5, 6, 7});
            // Arrays.MissingNumberWithSum(new int[] {1,2,3,5});
            // Arrays.MissingNumberWithSum(new int[] {1,2,3,4,5,6,7,8,10});
            // Arrays.MissingNumberWithSum(new int[] {1,2,4,6,3,7,8});
            //Arrays.MergeTwoSortedArrays(new int[] {1, 5, 9, 10, 15, 20}, new int[] {2, 3, 8, 13});
            //Arrays.PositiveSubArraySum(new int[]{1,4,20,3,10}, 33);
            //Arrays.PositiveSubArraySum(new int[]{1,4}, 0);
            // Arrays.CountTriplets(new int[]{1,5,3,2});
            // Arrays.CountTriplets(new int[]{3,2,7});
            // Arrays.RotateArray(new int[] {1, 3, 5, 4, 2}, 2);
            //Arrays.FindPairWithSumUsingSorting(new int[] {0, 1, 2, 3, 4, 5}, 5);
            // Search in sorted rotated array
            // Console.WriteLine(
            //     $"Array element 3 found at {Arrays.SearchInSortedRotatedArray(new int[] {1, 2, 7, 3, 4}, 3, 0, 5)}");

            //Arrays.MonkAndPowerOfTime(new int[] {3, 2, 1}, new int[] {1, 3, 2});
            //Arrays.DuplicateElements(new int[] {5, 3, 1, 3, 5, 5});
            // Arrays.PairWithMinProduct(new int[] {11, 8, 5, 7, 5, 100});
            // Arrays.PairWithMaxProduct(new int[] {11, 8, 5, 7, 5, 100});
            // Arrays.PairWithMinProduct(new int[] {198, 76, 544, 123, 154, 675});
            // Arrays.PairWithMaxProduct(new int[] {198, 76, 544, 123, 154, 675});
            // Arrays.PairWithMinProduct(new int[] {1, 4, 3, 6, 7, 0});
            // Arrays.PairWithMaxProduct(new int[] {1, 4, 3, 6, 7, 0});
            // Arrays.PairWithMinProduct(new int[] {-1, -3, -4, 2, 0, -5});
            // Arrays.PairWithMaxProduct(new int[] {-1, -3, -4, 2, 0, -5});
            // Arrays.MinProduct(new[] {0, 1, 2, 3, 4});
            //Arrays.MinProduct(new[] {-1, 2, -2, -8});
            // Arrays.MinProduct(new[] {1, 2, 3, 4});
            /*
            // Stack
            
            // Find min element with O(1)
            Stack objStack = new Stack();
            objStack.Push(2);
            objStack.Push(-1);
            Console.WriteLine($"Min element : {objStack.GetMin()}");
            objStack.Push(-3);
            Console.WriteLine($"Min element : {objStack.GetMin()}");
            objStack.Pop();
            Console.WriteLine($"Min element : {objStack.GetMin()}");
            objStack.Pop();
            Console.WriteLine($"Min element : {objStack.GetMin()}");
            
            */

            // Queue


            // Algorithms

            // Sorting

            // Merge Sort - Divide and conquer and then merge sub arrays
            int[] inputArr = new int[] {12, 11, 13, 5, 6, 7};
            MergeSort.Sort(inputArr, 0, inputArr.Length - 1);
            
            Console.WriteLine("Merge sort :");
            foreach (var element in inputArr)
            {
                Console.Write($"{element} ");
            }

            // Insertion Sort - compare with previous element till zeroth index
            inputArr = new int[] {12, 11, 13, 5, 6, 7};
            InsertionSort.Sort(inputArr, inputArr.Length );
            Console.WriteLine("\nInsertion sort :");
            foreach (var element in inputArr)
            {
                Console.Write($"{element} ");
            }
        }
    }
}