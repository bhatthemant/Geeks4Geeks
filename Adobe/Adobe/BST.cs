using System;
using System.Collections.Generic;

namespace Adobe
{
    public class BST
    {
        public int NodeValue;
        public BST Left, Right;

        public BST()
        {
            NodeValue = int.MinValue;
            Left = Right = null;
        }

        public BST(int nodeValue)
        {
            NodeValue = nodeValue;
            Left = Right = null;
        }
    }

    public class BSTHelper
    {
        public static BST Insert(BST rootNode, int nodeValue)
        {
            if (rootNode == null)
            {
                return new BST(nodeValue);
            }

            if (nodeValue > rootNode.NodeValue)
            {
                rootNode.Right = Insert(rootNode.Right, nodeValue);
            }
            else
            {
                rootNode.Left = Insert(rootNode.Left, nodeValue);
            }

            return rootNode;
        }

        public static void Inorder(BST rootNode)
        {
            if (rootNode == null)
                return;

            Inorder(rootNode.Left);
            Console.WriteLine(rootNode.NodeValue);
            Inorder(rootNode.Right);
        }

        public static void Inorder(BST rootNode, ref List<int> intList)
        {
            if (rootNode == null)
                return;

            Inorder(rootNode.Left, ref intList);
            Console.WriteLine(rootNode.NodeValue);
            intList.Add(rootNode.NodeValue);
            Inorder(rootNode.Right, ref intList);
        }

        public static BST SearchNode(BST rootNode, int nodeValue)
        {
            if (rootNode == null || rootNode.NodeValue == nodeValue)
                return rootNode;
            if (rootNode.NodeValue > nodeValue)
                return SearchNode(rootNode.Left, nodeValue);
            return SearchNode(rootNode.Right, nodeValue);
        }

        public static bool CheckForBSTViaList(BST rootNode)
        {
            if (rootNode == null)
                return true;
            List<int> intList = new List<int>();
            Inorder(rootNode, ref intList);
            for (int index = 1; index < intList.Count; index++)
            {
                if (intList[index] < intList[index - 1])
                    return false;
            }

            return true;
        }

        // Incomplete
        public static bool CheckForBST(BST rootNode)
        {
            // if (rootNode == null)
            //     return true;

            if (rootNode.Left != null && rootNode.NodeValue < rootNode.Left.NodeValue)
                return false;
            else
                CheckForBST(rootNode.Left);
            if (rootNode.Right != null && rootNode.NodeValue > rootNode.Right.NodeValue)
                return false;
            else
                CheckForBST(rootNode.Right);

            return true;
        }
    }
}