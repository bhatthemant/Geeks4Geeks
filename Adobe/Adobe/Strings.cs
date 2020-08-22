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

    }
}
