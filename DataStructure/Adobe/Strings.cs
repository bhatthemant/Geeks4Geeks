using System;

namespace Adobe
{
    public static class Strings
    {
        public static void LastIndexOfOne(string inputStr)
        {
            int lastIndex = -1;
            for (int index = 0; index < inputStr.Length; index++)
            {
                if (inputStr[index] == '1')
                {
                    lastIndex = index;
                }
            }

            Console.WriteLine(lastIndex);
        }

        public static void GetmaxOccurenceOfString(string inputStr)
        {
            int[] intCount = new int[256];
            int length = inputStr.Length;

            for (int index = 0; index < length; index++)
            {
                intCount[inputStr[index]]++;
            }

            int max = -1;
            char result = ' ';
            for (int index = 0; index < length; index++)
            {
                if (max < intCount[inputStr[index]])
                {
                    max = intCount[inputStr[index]];
                    result = inputStr[index];
                }
            }

            Console.WriteLine($"{result},{max}");
        }

    }
}
