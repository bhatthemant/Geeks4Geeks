using System;

namespace Adobe.Algorithms.Sorting
{
    public static class MergeSort
    {
        public static void Sort(int[] inputArr, int start, int end)
        {
            if (start < end)
            {
                int mid = start + (end - start) / 2;

                Sort(inputArr, start, mid);
                Sort(inputArr, mid + 1, end);
                Merge(inputArr, start, mid, end);
            }
        }

        private static void Merge(int[] inputArr, int start, int mid, int end)
        {
            int iIndex, jINdex, kIndex;
            int firstArrayLength = mid - start + 1;
            int secondArrayLength = end - mid;

            int[] firstArr = new int[firstArrayLength]; // temp array for first half of splitted array
            int[] secondArr = new int[secondArrayLength]; // temp array for second half of splitted array

            for (int i = 0; i < firstArrayLength; i++) // fill the array
            {
                firstArr[i] = inputArr[start + i];
            }

            for (int i = 0; i < secondArrayLength; i++) // fill the second array
            {
                secondArr[i] = inputArr[mid + 1 + i];
            }

            iIndex = 0;
            jINdex = 0;
            kIndex = start;

            while (iIndex < firstArrayLength && jINdex < secondArrayLength) // merge the splitted arrays back
            {
                if (firstArr[iIndex] < secondArr[jINdex]) // compare for smallest element
                {
                    inputArr[kIndex] = firstArr[iIndex];
                    iIndex++;
                }
                else
                {
                    inputArr[kIndex] = secondArr[jINdex];
                    jINdex++;
                }

                kIndex++;
            }

            while (iIndex < firstArrayLength) // add remaining array element for first array
            {
                inputArr[kIndex] = firstArr[iIndex];
                iIndex++;
                kIndex++;
            }

            while (kIndex < secondArrayLength) // add remaining array element for second array.
            {
                inputArr[kIndex] = secondArr[jINdex];
                jINdex++;
                kIndex++;
            }
        }
    }
}