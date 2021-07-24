namespace Adobe.Algorithms.Sorting
{
    public static class InsertionSort
    {
        public static void Sort(int[] inputArr, int inputLength)
        {
            for (int index = 0; index < inputLength; ++index)
            {
                int key = inputArr[index]; // Store element of current index
                int j = index - 1; // initialize to current -1 ; to do comparison from left element to start of array

                while (j >= 0 && inputArr[j] > key) // until we have iterated all previous element and previous element is greater then current
                {
                    inputArr[j + 1] = inputArr[j]; // replace the current element with previous one.  
                    j--; // dec index;
                }

                inputArr[j + 1] = key;
            }
        }
    }
}