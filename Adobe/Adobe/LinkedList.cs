using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Xml;

namespace Adobe
{
    public class Node
    {
        public object Data;
        public Node Next;
    }

    public class LinkedList
    {
        public Node Head;

        public LinkedList()
        {
            // Head = new Node();
        }

        public void AddFirst(object data)
        {
            Head = new Node {Data = data, Next = null};
        }

        public void InsertAtFront(object data)
        {
            if (Head == null)
            {
                AddFirst(data);
                return;
            }

            var node = new Node {Data = data, Next = Head};
            Head = node;
        }

        public void TraverseAll()
        {
            Node currenNode = Head;
            while (currenNode != null)
            {
                Console.WriteLine(currenNode.Data);
                currenNode = currenNode.Next;
            }
        }

        public void AddLast(object data)
        {
            if (Head == null)
            {
                AddFirst(data);
                return;
            }

            Node currenNode = Head;
            Node prevNode = null;
            while (currenNode != null)
            {
                prevNode = currenNode;
                currenNode = currenNode.Next;
            }

            if (prevNode != null) prevNode.Next = currenNode = new Node {Data = data, Next = null};
        }
    }

    public static class LinkedListHelper
    {
        // Uses Hash to store the nodes visited
        public static Node DetectLoopWithHash(Node headNode)
        {
            if (headNode == null)
                return null;

            HashSet<Node> visitedNodes = new HashSet<Node>();
            while (headNode.Next != null)
            {
                if (visitedNodes.Contains(headNode))
                    return headNode;

                visitedNodes.Add(headNode);
                headNode = headNode.Next;
            }

            return null;
        }

        public static Node DetectLoopWithFloydCycle(Node headNode)
        {
            if (headNode == null)
                return null;

            Node fastNode = headNode;
            Node slowNode = headNode;

            while (fastNode != null && slowNode != null && fastNode.Next != null)
            {
                fastNode = fastNode.Next.Next;
                slowNode = slowNode.Next;

                if (fastNode == slowNode)
                {
                    return slowNode;
                }
            }

            return null;
        }

        public static void RemoveCycle(Node headNode)
        {
            Node cycleNode = DetectLoopWithHash(headNode);
            if (cycleNode != null)
                cycleNode.Next = null;
        }

        public static int GetMiddleWithCounter(Node headNode)
        {
            if (headNode == null)
                return int.MinValue;

            Node tempNode = headNode;
            int counter = 0;

            while (tempNode != null)
            {
                counter++;
                tempNode = tempNode.Next;
            }

            int mid = 0;
            while (mid < counter / 2)
            {
                mid++;
                headNode = headNode.Next;
            }

            return (int) headNode.Data;
        }

        public static int GetMiddleWithTwoPointer(Node headNode)
        {
            if (headNode == null)
                return int.MinValue;

            Node fastNode = headNode;
            Node slowNode = headNode;

            while (fastNode != null && fastNode.Next != null)
            {
                fastNode = fastNode.Next.Next;
                slowNode = slowNode.Next;
            }

            return (int) slowNode.Data;
        }

        public static int GetMiddleWithEvenOdd(Node headNode)
        {
            if (headNode == null)
                return int.MinValue;

            Node tempNode = headNode;
            int counter = 0;

            while (headNode != null)
            {
                if (counter % 2 > 0)
                {
                    tempNode = tempNode.Next;
                }

                counter++;
                headNode = headNode.Next;
            }

            return (int) tempNode.Data;
        }

        public static void ReverseWithInsertAtFront(Node headNode)
        {
            if (headNode == null)
                return;

            LinkedList reversedList = new LinkedList();
            while (headNode != null)
            {
                reversedList.InsertAtFront(headNode.Data);
                headNode = headNode.Next;
            }

            Node reversedHead = reversedList.Head;
            while (reversedHead != null)
            {
                Console.WriteLine(reversedHead.Data);
                reversedHead = reversedHead.Next;
            }
        }

        public static void Reverse(Node headNode)
        {
            if (headNode == null)
                return;

            Node tempNode = null;
            Node prevNode = null;

            while (headNode != null)
            {
                tempNode = headNode.Next; // Store the next of element
                headNode.Next = prevNode; // Set the current node next to previous node visited
                prevNode = headNode; // Store current node as previous node
                headNode = tempNode; // Set head not head.next which was stored as temp node at step 1
            }

            while (prevNode != null)
            {
                Console.WriteLine(prevNode.Data);
                prevNode = prevNode.Next;
            }
        }

        public static bool IsPalindrome(Node headNode)
        {
            Queue<Node> nodeQueue = new Queue<Node>();
            Stack<Node> nodeStack = new Stack<Node>();
            while (headNode != null)
            {
                nodeQueue.Enqueue(headNode);
                nodeStack.Push(headNode);
                headNode = headNode.Next;
            }

            while (nodeQueue.Count > 0)
            {
                if ((int) nodeQueue.Dequeue().Data != (int) nodeStack.Pop().Data)
                    return false;
            }

            return true;
        }

        public static Node NthNodeFromEndDoubleIteration(Node headNode, int indexFromLast)
        {
            int nodeCount = 0;
            Node tempNode = headNode;
            Node secondNode = headNode;

            while (tempNode != null)
            {
                tempNode = tempNode.Next;
                nodeCount++;
            }

            if (nodeCount < indexFromLast)
                return null;

            for (int index = 0; index < nodeCount - indexFromLast; index++)
            {
                secondNode = secondNode.Next;
            }

            return secondNode;
        }

        public static Node NthNodeFromEndSingleIteration(Node headNode, int indexFromLast)
        {
            Node tempNode = headNode, secondNode = headNode;
            for (int index = 1; index <= indexFromLast - 1; index++)
            {
                tempNode = tempNode.Next;
                if (tempNode == null)
                    return null;
            }

            while (tempNode.Next != null)
            {
                tempNode = tempNode.Next;
                secondNode = secondNode.Next;
            }

            return secondNode;
        }
    }
}