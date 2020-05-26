using System;

namespace Adobe
{
    public class Stack
    {
        private int topCounter = -1;
        private int[] arr = new int[100];
        private int minVal = int.MinValue;

        public void Push(int val)
        {
            if (topCounter == -1)
                topCounter = 0;
            else
                topCounter++;

            if (minVal == int.MinValue)
            {
                minVal = val;
                arr[topCounter] = val;
            }
            else if (minVal < val)
            {
                arr[topCounter] = val;
            }
            else
            {
                arr[topCounter] = 2 * val - minVal;
                minVal = val;
            }
        }

        public int GetMin() => minVal;

        public void Pop()
        {
            if (topCounter == -1)
                return;

            if (minVal <= arr[topCounter])
            {
                Console.WriteLine(arr[topCounter]);
                topCounter--;
            }
            else
            {
                Console.WriteLine(minVal);
                minVal = 2 * minVal - arr[topCounter];
                topCounter--;
            }
        }
    }
}