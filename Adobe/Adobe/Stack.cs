using System;

namespace Adobe
{
    public class Stack<T>
    {
        private readonly T[] arr = new T[100];
        private int minVal = int.MinValue;
        private int topCounter = -1;

        public void Push(T val)
        {
            if (IsFull)
                throw new Exception("OverFlow");

            if (topCounter == -1)
                topCounter = 0;
            else
                topCounter++;

            arr[topCounter] = val;
        }

        public bool IsEmpty => topCounter == -1;

        public bool IsFull => topCounter == 99;

        public T Pop()
        {
            if (IsEmpty)
                throw new Exception("UnderFlow");

            T val = arr[topCounter];
            topCounter--;
            return val;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new Exception("UnderFlow");

            return arr[topCounter - 1];
        }

        // public void Push(int val)
        // {
        //     if (topCounter == -1)
        //         topCounter = 0;
        //     else
        //         topCounter++;
        //
        //     if (minVal == int.MinValue)
        //     {
        //         minVal = val;
        //         arr[topCounter] = val;
        //     }
        //     else if (minVal < val)
        //     {
        //         arr[topCounter] = val;
        //     }
        //     else
        //     {
        //         arr[topCounter] = 2 * val - minVal;
        //         minVal = val;
        //     }
        // }
        //
        // public int GetMin()
        // {
        //     return minVal;
        // }
        //
        // public void Pop()
        // {
        //     if (topCounter == -1)
        //         return;
        //
        //     if (minVal <= arr[topCounter])
        //     {
        //         Console.WriteLine(arr[topCounter]);
        //         topCounter--;
        //     }
        //     else
        //     {
        //         Console.WriteLine(minVal);
        //         minVal = 2 * minVal - arr[topCounter];
        //         topCounter--;
        //     }
        // }
    }

    public class StackMin
    {
        private int minElement;
        Stack<int> actualStack = new Stack<int>();
        Stack<int> auxiliaryStack = new Stack<int>();

        public void Push(int val)
        {
            actualStack.Push(val);
            if (auxiliaryStack.IsEmpty)
            {
                auxiliaryStack.Push(val);
            }
            else
            {
                if (actualStack.Peek() <= auxiliaryStack.Peek())
                {
                    auxiliaryStack.Push(val);
                }
            }
        }

        public int Pop()
        {
            if (actualStack.IsEmpty)
                return -1;
            else
            {
                if (auxiliaryStack.Peek() == actualStack.Peek())
                    auxiliaryStack.Pop();
                else
                {
                    return actualStack.Pop();
                }
            }

            return -1;
        }

        public int GetMin()
        {
            if (auxiliaryStack.IsEmpty)
                return -1;
            else
            {
                return auxiliaryStack.Peek();
            }
        }
    }
    
    
}