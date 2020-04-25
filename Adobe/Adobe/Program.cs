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

          //  Console.WriteLine(BSTHelper.CheckForBSTViaList(binarySearchTree));
            
          Console.WriteLine(BSTHelper.IsBST(binarySearchTree, Int32.MinValue, Int32.MaxValue));
            var node = BSTHelper.SearchNode(binarySearchTree,7);
            node.NodeValue = 11;
            
           // Console.WriteLine(BSTHelper.CheckForBSTViaList(binarySearchTree));
            Console.WriteLine(BSTHelper.IsBST(binarySearchTree, Int32.MinValue, Int32.MaxValue));
        }
    }
}