namespace Searching
{
    public static class BinarySearch
    {
        // Time complexity - O(log n)
        // Space Complexity - O(log n)
        public static int RecursiveSearch(int[] inputArr, int element, int low, int high)
        {
            if (low <= high)
            {

                int mid = low + (high - low) / 2;
                if (inputArr[mid] == element)
                    return mid;
                if (inputArr[mid] > element)
                    return RecursiveSearch(inputArr, element, low, mid - 1);
                if (inputArr[mid] < element)
                    return RecursiveSearch(inputArr, element, mid + 1, high);
            }

            return -1;
        }

        // Time complexity - O{log n)
        // Space Complexity - O(1)
        public static int IterativeSearch(int[] inputArr, int element)
        {
            int low = 0;
            int high = inputArr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (inputArr[mid] == element)
                    return mid;
                if (inputArr[mid] > element)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return -1;
        }

    }
}
