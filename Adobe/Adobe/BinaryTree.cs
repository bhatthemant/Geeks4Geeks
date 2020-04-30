using System;
using System.Collections.Generic;

namespace Adobe
{
    public class BinaryTreeNode
    {
        public object Data;
        public BinaryTreeNode Left, Right;

        public BinaryTreeNode(object nodeData)
        {
            Data = nodeData;
            Left = Right = null;
        }
    }

    public class BinaryTree
    {
        public BinaryTreeNode RootNode;

        public BinaryTree(object nodeData)
        {
            RootNode = new BinaryTreeNode(nodeData);
        }

        public BinaryTree()
        {
            RootNode = new BinaryTreeNode(int.MinValue);
        }
    }

    public static class BinaryTreeHelper
    {
        public static void LevelOrderTraversal(BinaryTreeNode rootNode)
        {
            if (rootNode == null)
                return;

            Queue<BinaryTreeNode> nodeQueue = new Queue<BinaryTreeNode>();
            nodeQueue.Enqueue(rootNode);

            while (nodeQueue.Count > 0)
            {
                var currentNode = nodeQueue.Dequeue();
                Console.WriteLine(currentNode.Data);
                if (currentNode.Left != null)
                    nodeQueue.Enqueue(currentNode.Left);
                if (currentNode.Right != null)
                    nodeQueue.Enqueue(currentNode.Right);
            }
        }

        public static void CreateTree(BinaryTreeNode rootNode, string[] arr)
        {
            int nodeCounter = 0;
            Queue<BinaryTreeNode> nodeQueue = new Queue<BinaryTreeNode>();
            BinaryTreeNode currentNode = rootNode;

            for (int i = 0; i < arr.Length; i++)
            {
                currentNode.Data = arr[i];

                currentNode.Left = 2 * i + 1 < arr.Length
                    ? new BinaryTreeNode(arr[2 * i + 1])
                    : null;
                nodeCounter++;
                nodeQueue.Enqueue(currentNode.Left);
                currentNode.Right = 2 * i + 2 < arr.Length
                    ? new BinaryTreeNode(arr[2 * i + 2])
                    : null;
                nodeCounter++;
                nodeQueue.Enqueue(currentNode.Right);

                if (nodeCounter == 2)
                {
                    nodeCounter = 0;
                    currentNode = nodeQueue.Dequeue();
                }
            }
        }
    }
}