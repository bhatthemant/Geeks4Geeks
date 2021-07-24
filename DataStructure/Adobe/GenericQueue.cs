using System;
using System.Xml;

namespace Adobe
{
    public class GenericQueue<T>
    {
        private T[] internalArray = new T[100];
        private int lowCounter = 0;
        private int topCounter = -1;

        public void Enqueue(T val)
        {
            if (topCounter == 99)
            {
                throw new Exception("Over Flow.");
            }

            if (topCounter == -1)
            {
                topCounter = 0;
            }
            else
            {
                topCounter++;
            }

            internalArray[topCounter] = val;
        }

        public T Dequeue()
        {
            if (topCounter == -1 || lowCounter > topCounter)
                throw new Exception("Under flow.");

            T returnValue = internalArray[lowCounter];
            lowCounter++;

            return returnValue;
        }

        public bool IsEmpty => topCounter == -1;
    }

    public class StackUsingQueue
    {
        private GenericQueue<int> internalPushQueue = new GenericQueue<int>();
        private GenericQueue<int> internalPopQueue = new GenericQueue<int>();

        public void Push(int val) => internalPushQueue.Enqueue(val);

        // public int Pop()
        // {
        //     // while (internalPushQueue.)
        //     // {
        //     //     
        //     // }
        // }
    }
}