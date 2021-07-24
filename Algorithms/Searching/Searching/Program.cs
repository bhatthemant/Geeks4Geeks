using System;

namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = {10, 20, 80, 30, 60, 50,
                     110, 100, 130, 170};
            int[] inputSortedArr = {10, 20, 30, 50, 60, 80,
                     100, 110, 130, 170};
            int element = 110;

            // Linear Search
            Console.WriteLine($"Element found at {LinearSearch.Search(inputArr, element)}");
            Console.WriteLine($"Element found at {LinearSearch.SearchImproved(inputArr, element)}");

            // Binary Search
            Console.WriteLine($"Element found at {BinarySearch.RecursiveSearch(inputSortedArr, element, 0, inputArr.Length - 1)}");
            Console.WriteLine($"Element found at {BinarySearch.IterativeSearch(inputSortedArr, element)}");

            element = 175;

            // Linear Search
            Console.WriteLine($"Element found at {LinearSearch.Search(inputArr, element)}");
            Console.WriteLine($"Element found at {LinearSearch.SearchImproved(inputArr, element)}");

            // Binary Search
            Console.WriteLine($"Element found at {BinarySearch.RecursiveSearch(inputSortedArr, element, 0, inputArr.Length - 1)}");
            Console.WriteLine($"Element found at {BinarySearch.IterativeSearch(inputSortedArr, element)}");
        }
    }
}
