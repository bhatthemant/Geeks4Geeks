namespace Searching
{
    public static class LinearSearch
    {// Time complexity - O{n}
        public static int Search(int[] inputArr, int element)
        {
            for (int index = 0; index < inputArr.Length; index++)
            {
                if (element == inputArr[index])
                    return index;
            }

            return -1;
        }

        // Time complexity 
        // Worse O{1} - if element is present at last position
        // Worse O{N/2} - If element is not present in array.
        public static int SearchImproved(int[] inputArr, int element)
        {
            // Define limits (start and end)
            int left = 0;
            int right = inputArr.Length - 1;

            // Iterate over array elements - check for start and end in a single iteration
            for (left = 0; left <= right;)
            {
                if (inputArr[left] == element)
                    return left;  // element matched exit
                if (inputArr[right] == element)
                    return right; // element matched exit

                // increment to next index
                left++;
                // decrement to previous index
                right--;
            }

            // No element matched
            return -1;
        }
    }
}
