using System;
using System.Runtime.InteropServices;

namespace Adobe
{
    class Program
    {
        static void Main(string[] args)
        {
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

            /*
                       LinkedList linkedList = new LinkedList();
                       linkedList.AddLast(1);
                       linkedList.AddLast(2);
                       linkedList.AddLast(3);
                       // linkedList.AddLast(4);
                       // linkedList.AddLast(5);
                       // linkedList.AddLast(6);
                       linkedList.AddLast(3);
                       linkedList.AddLast(2);
                       linkedList.AddLast(1);
           
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
                                  // Console.WriteLine($"Middle element is : {LinkedListHelper.GetMiddleWithEvenOdd(linkedList.Head)}");
                      
                                  //Reveres LinkedList
                                  LinkedListHelper.ReverseWithInsertAtFront(linkedList.Head);
                                  LinkedListHelper.Reverse(linkedList.Head);
                                  
                                  */


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
            Arrays.TrappedWater();
        }
    }
}