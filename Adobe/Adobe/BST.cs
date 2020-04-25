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

        // using min and max values
        public static bool IsBST(BST rootNode, int min, int max)
        {
            // For root we max int.min and int.max and compare with root value which is always true
            // After that we move to root.left child with passing the rootvalue as max value now, to check if any node has any value greater than root node
            // for its child now you have updated value for min and max from parent.
            
            // Iteration flow
            // 8, int.min, int.max
            // 1,int.min, 8 | 10, 8, int.max
            // null | 4, 1, 8 | 9, 10, int.max | 14, 10, int.max
            // null | 3,1,4 | 7, 4, 8 | null | 13 , 10, 14 | null
            // null | null | 6, 4, 7 | null | null | null
            // null | null | null | null | null | null
            
            if (rootNode == null)
                return true;

            if (rootNode.NodeValue < min || rootNode.NodeValue > max)
            {
                Console.WriteLine($"Node value is : {rootNode.NodeValue} min value is : {min}  max value is : {max}");
                return false;
            }

            return IsBST(rootNode.Left, min, rootNode.NodeValue) && IsBST(rootNode.Right, rootNode.NodeValue, max);
        }
    }
}