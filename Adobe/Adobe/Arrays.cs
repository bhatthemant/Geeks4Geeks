using System;
using System.Linq;

namespace Adobe
{
    public class Arrays
    {
        public static void TrappedWater()
        {
            /*
             Test cases 
             1. 2 0 2   --- 2
             2. 2 0 2 4 0 5 --- 6
             3. 2 0 2 4 0 1 ---- 3
             4. 0 1 0 2 1 0 1 3 2 1 2 1 --- 6
             5. 3 0 2 0 4 --- 7
             6. 2 0 1 --- 1
             */
            
            Console.WriteLine("Enter number of use cases : ");
            int numberOfCases = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            while (numberOfCases-- > 0)
            {
                Console.WriteLine("Enter the unit of water");

                string[] strArray = Console.ReadLine().Split(" ");
                int[] inputArray = new int[strArray.Length];

                for (var index = 0; index < strArray.Length; index++)
                {
                    if (int.TryParse(strArray[index], out int intValue))
                        inputArray[index] = intValue;
                }

                int leftBoundary = inputArray[0];
                int rightBoundary;
                int trappedWater = 0;

                for (int index = 0; index < inputArray.Length - 1; index++)
                {
                    rightBoundary = inputArray.Skip(index + 1).Take(inputArray.Length - 1).Max();
                    if (leftBoundary > inputArray[index] && rightBoundary > inputArray[index])
                    {
                        var dividiend = leftBoundary <= rightBoundary
                            ? leftBoundary
                            : Math.Min(leftBoundary, rightBoundary);
                        trappedWater += Math.Abs(dividiend - inputArray[index]);
                    }
                    else
                        leftBoundary = inputArray[index];
                }

                Console.WriteLine($"Amount of trapped water : {trappedWater}");
            }
        }
    }
}