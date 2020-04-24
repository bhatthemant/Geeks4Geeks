using System;

namespace Adobe
{
    class Program
    {
        static void Main(string[] args)
        {
            // BST 
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

            BSTHelper.Inorder(binarySearchTree);

            
            var node = BSTHelper.SearchNode(binarySearchTree,9);
            node.NodeValue = 15;
            
            Console.WriteLine(BSTHelper.CheckForBSTViaList(binarySearchTree));
           // Console.WriteLine(BSTHelper.CheckForBST(binarySearchTree));
        }
    }
}