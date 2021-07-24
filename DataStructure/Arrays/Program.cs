using System;

namespace Arrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LeftRotateArray(new[] {1, 2, 3, 4, 5, 6, 7}, 7, 2);
            LeftRotateArray(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9}, 9, 3);
            JugglingAlgo(new ulong[] {1, 2, 3, 4, 5, 6, 7, 8, 9}, 9, 3);

            Console.WriteLine(GCD(594, 216)); /*(GCD(12, 30));*/
        }

        public static void JugglingAlgo(ulong[] arr, ulong size, ulong increment)
        {
            ulong startingIndex, jump, temp;
            for (ulong index = 0; index < GCD(size, increment); index++)
            {
                startingIndex = index; // hold primary index
                temp = arr[index]; // hold element of first index
                while (true) // Loop all items
                {
                    jump = (startingIndex + increment) % size;

                    if (jump == index)
                        break;

                    arr[startingIndex] = arr[jump]; // replace element at the starting index
                    startingIndex = jump; // increment position so that now we replace next element in set.
                }

                arr[startingIndex] = temp; // replace first element
            }

            foreach (var item in arr)
                Console.WriteLine(item);
        }

        public static void LeftRotateArray(int[] arr, int size, int increment)
        {
            // Time completexity - O(n)

            for (var index = 0; index < size; index++)
            {
                Console.WriteLine("index will be : " + (index + increment) % size);
                Console.WriteLine(arr[(index + increment) % size]);
            }
        }

        public static ulong GCD(ulong a, ulong b)
        {
            while (a != 0 && b != 0)
                if (a > b)
                    a %= b;
                else
                    b %= a;

            return a == 0 ? b : a;
        }
    }
}