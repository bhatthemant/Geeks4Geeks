using System;
using System.Collections.Generic;
using System.Linq;

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

        public static void TreeCreate(BinaryTreeNode rootNode, string[] arr)
        {
            Queue<BinaryTreeNode> nodeQueue = new Queue<BinaryTreeNode>();

            rootNode.Data = (arr[0]);
            nodeQueue.Enqueue(rootNode);
            bool isLeftVisited = false;
            for (int index = 1; index < arr.Length; index++)
            {
                //var tempNode = new BinaryTreeNode(arr[index]);
                var tempNode = arr[index] != "N" ? new BinaryTreeNode(arr[index]) : null;

                if (!isLeftVisited && nodeQueue.Peek() != null && nodeQueue.Peek().Left == null)
                {
                    nodeQueue.Peek().Left = tempNode;
                    isLeftVisited = true;
                }
                else
                {
                    if (nodeQueue.Peek() != null)
                        nodeQueue.Peek().Right = tempNode;
                    isLeftVisited = false;
                    nodeQueue.Dequeue();
                }

                if (tempNode != null)
                    nodeQueue.Enqueue(tempNode);
            }
        }

        public static void CreateTree(BinaryTreeNode rootNode, string[] arr)
        {
            Queue<BinaryTreeNode> nodeQueue = new Queue<BinaryTreeNode>();
            rootNode.Data = arr[0];
            BinaryTreeNode currentNode = rootNode;

            for (int i = 0; i < arr.Length; i++)
            {
                bool isValidIndex = true;
                if (currentNode != null)
                {
                    isValidIndex = 2 * i + 1 < arr.Length && arr[2 * i + 1] != "N";
                    currentNode.Left = isValidIndex
                        ? new BinaryTreeNode(arr[2 * i + 1])
                        : null;
                    if (currentNode.Left != null)
                        nodeQueue.Enqueue(currentNode.Left);

                    isValidIndex = 2 * i + 2 < arr.Length && arr[2 * i + 2] != "N";
                    currentNode.Right = isValidIndex
                        ? new BinaryTreeNode(arr[2 * i + 2])
                        : null;
                    if (currentNode.Right != null)
                        nodeQueue.Enqueue(currentNode.Right);
                }

                if (nodeQueue.Count > 0)
                    currentNode = nodeQueue.Dequeue();
            }
        }

        public static void PrintNodeWithOutSibling(BinaryTreeNode rootNode)
        {
            if (rootNode == null)
                return;

            Queue<BinaryTreeNode> nodeQueue = new Queue<BinaryTreeNode>();
            nodeQueue.Enqueue(rootNode);

            while (nodeQueue.Any())
            {
                var currentNode = nodeQueue.Dequeue();
                Queue<BinaryTreeNode> siblingQueue = new Queue<BinaryTreeNode>();
                int nodeCounter = 0;
                if (currentNode.Left != null)
                {
                    nodeCounter++;
                    siblingQueue.Enqueue(currentNode.Left);
                    nodeQueue.Enqueue(currentNode.Left);
                }

                if (currentNode.Right != null)
                {
                    nodeCounter++;
                    siblingQueue.Enqueue(currentNode.Right);
                    nodeQueue.Enqueue(currentNode.Right);
                }

                if (nodeCounter == 1)
                {
                    Console.WriteLine(siblingQueue.Dequeue().Data);
                }

                siblingQueue.Clear();
            }
        }
    }
}