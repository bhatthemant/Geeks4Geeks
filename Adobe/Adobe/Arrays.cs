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
            var numberOfCases = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            while (numberOfCases-- > 0)
            {
                Console.WriteLine("Enter the unit of water");

                var strArray = Console.ReadLine().Split(" ");
                var inputArray = new int[strArray.Length];

                for (var index = 0; index < strArray.Length; index++)
                    if (int.TryParse(strArray[index], out var intValue))
                        inputArray[index] = intValue;

                var leftBoundary = inputArray[0];
                int rightBoundary;
                var trappedWater = 0;

                for (var index = 0; index < inputArray.Length - 1; index++)
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
                    {
                        leftBoundary = inputArray[index];
                    }
                }

                Console.WriteLine($"Amount of trapped water : {trappedWater}");
            }
        }

        public static void DuplicateElements(int[] inputArr)
        {
            for (var index = 0; index < inputArr.Length; index++)
            {
                var i = inputArr[index] % inputArr.Length;
                inputArr[i] += inputArr.Length;
            }

            for (var i = 0; i < inputArr.Length; i++)
                if (inputArr[i] / inputArr.Length > 1)
                    Console.Write(i + " ");
        }

        //PeakElement is Binary Search Problem
        public static void PeakElemet(int[] inputArr)
        {
            var low = 0;
            var high = inputArr.Length - 1;

            while (low < high)
            {
                var mid = low + (high - low) / 2;
                if (inputArr[mid] < inputArr[mid + 1])
                    low = mid + 1;
                else
                    high = mid;
            }

            Console.WriteLine(low);
        }

        public static void PeakElement1(int[] inputArr)
        {
            var low = 0;
            var high = inputArr.Length - 1;
            while (low < high)
            {
                var mid = low + (high - low) / 2;

                if (mid > 0 && mid < inputArr.Length - 1) // If not the edge cases for left and right element
                {
                    if (inputArr[mid] > inputArr[mid + 1] && inputArr[mid] < inputArr[mid - 1])
                        Console.WriteLine(mid);
                    else if (inputArr[mid - 1] > inputArr[mid]
                    ) // Element on left is greater so look on subarray on left
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                else if (mid == 0) // mid is leftmost elements
                {
                    if (inputArr[0] > inputArr[1])
                        Console.WriteLine(0);
                    else
                        Console.WriteLine(1);
                }
                else if (mid == inputArr.Length - 1)
                {
                    if (inputArr[^1] > inputArr[^2]
                    ) // ^ depicts the last element append the index to get desired position of element
                        Console.WriteLine(inputArr.Length - 1);
                    else
                        Console.WriteLine(inputArr.Length - 2);
                }
            }
        }

        public static void MinProduct(int[] inputArr)
        {
            var allNonNegative = inputArr.All(x => x >= 0);

            if (allNonNegative)
                PairWithMinProduct(inputArr);
            else
                Console.WriteLine(inputArr.Min() * inputArr.Max());
        }

        public static void PairWithMinProduct(int[] inputArr)
        {
            var minElement = Math.Min(inputArr[0], inputArr[1]);
            var nextMinElement = Math.Max(inputArr[0], inputArr[1]);

            for (var index = 2; index < inputArr.Length; index++)
                if (inputArr[index] < minElement)
                {
                    nextMinElement = minElement;
                    minElement = inputArr[index];
                }
                else if (inputArr[index] < nextMinElement)
                {
                    nextMinElement = inputArr[index];
                }

            Console.WriteLine(minElement * nextMinElement);
            //Console.WriteLine($"Element Pair {minElement} and {nextMinElement}");
        }

        public static void PairWithMaxProduct(int[] inputArr)
        {
            var minElement = Math.Max(inputArr[0], inputArr[1]);
            var nextMinElement = Math.Max(inputArr[0], inputArr[1]);

            for (var index = 2; index < inputArr.Length; index++)
                if (inputArr[index] > minElement)
                {
                    nextMinElement = minElement;
                    minElement = inputArr[index];
                }
                else if (inputArr[index] > nextMinElement)
                {
                    nextMinElement = inputArr[index];
                }

            Console.WriteLine($"Element Pair {minElement} and {nextMinElement}");
        }

        public static void MaxContigiuosArray()
        {
            Console.WriteLine("Enter array element : ");

            var strInput = Console.ReadLine().Split(" ");
            var inputArr = new int[strInput.Length];

            for (var index = 0; index < strInput.Length; index++) inputArr[index] = int.Parse(strInput[index]);

            var maxValue = 0;
            var maxValueSoFar = 0;

            foreach (var item in inputArr)
            {
                maxValue += item;

                if (maxValue < 0)
                    maxValue = 0;
                else if (maxValueSoFar < maxValue)
                    maxValueSoFar = maxValue;
            }

            Console.WriteLine(maxValueSoFar);
        }

        public static int SearchInSortedRotatedArray(int[] inputArr, int key, int low, int high)
        {
            if (low > high)
                return -1;

            var mid = (low + high) / 2;

            if (inputArr[mid] == key)
                return mid;

            if (inputArr[low] <= inputArr[mid])
            {
                if (inputArr[low] <= key && key <= inputArr[mid])
                    return SearchInSortedRotatedArray(inputArr, key, low, mid - 1);
                return SearchInSortedRotatedArray(inputArr, key, mid + 1, high);
            }

            if (inputArr[mid] <= key && key <= inputArr[high])
                return SearchInSortedRotatedArray(inputArr, key, mid + 1, high);
            return SearchInSortedRotatedArray(inputArr, key, low, mid - 1);
        }

        public static void RotateArray(int[] inputArr, int rotation)
        {
            var mod = rotation % inputArr.Length;
            for (var index = 0; index < inputArr.Length; index++)
            {
                Console.Write(inputArr[(index + mod) %
                                       inputArr.Length] + " ");

                Console.WriteLine();
            }
        }

        public static int[] RotateArrayElements(int[] inputArr, int rotation)
        {
            var newArr = new int[inputArr.Length];
            var mod = rotation % inputArr.Length;
            for (var index = 0; index < inputArr.Length; index++)
                newArr[index] = inputArr[(index + mod) %
                                         inputArr.Length];

            return newArr;
        }

        public static void FindPairWithSumUsingSorting(int[] inputArr, int sum)
        {
            Array.Sort(inputArr);

            var low = 0;
            var high = inputArr.Length - 1;

            while (low < high)
            {
                var currentSum = inputArr[low] + inputArr[high];
                if (currentSum == sum)
                {
                    Console.WriteLine("Pair found : " + low + "," + high);
                    low++;
                    //high--;  Either we can increment low or decrement high to iterate and look for other pairs
                }
                else
                {
                    // If currentsum is greater than sum then the last element in this sorted array needs to be decreased
                    if (currentSum > sum)
                        high--;
                    else
                        low++;
                }
            }
        }

        // hacker Earth Problems 

        public static bool IsEqual(int[] callingOrderArray, int[] idealOrderArray)
        {
            var isEqual = true;
            for (var index = 0; index < callingOrderArray.Length; index++)
                if (callingOrderArray[index] != idealOrderArray[index])
                {
                    isEqual = false;
                    break;
                }

            return isEqual;
        }

        public static void TakeInput()
        {
            var sizeOfArr = int.Parse(Console.ReadLine());
            var callingOrderArray = new int[sizeOfArr];
            var inputString = Console.ReadLine().Split(" ");
            var index = 0;
            foreach (var str in inputString)
            {
                callingOrderArray[index] = int.Parse(str);
                index++;
            }

            var idealOrderArray = new int[sizeOfArr];
            inputString = Console.ReadLine().Split(" ");
            index = 0;
            foreach (var str in inputString)
            {
                idealOrderArray[index] = int.Parse(str);
                index++;
            }
        }

        public static void MonkAndPowerOfTime(int[] callingOrderArray, int[] idealOrderArray)
        {
            var unitOfTime = 0;

            while (!IsEqual(callingOrderArray, idealOrderArray))
            {
                unitOfTime++;
                callingOrderArray = RotateArrayElements(callingOrderArray, 1);
            }

            Console.WriteLine(unitOfTime + callingOrderArray.Length);
        }
    }
}