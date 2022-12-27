namespace CodingChallenges.Arrays
{
    public class ArrayChallenges
    {
        // Given two sorted arrays, merge them as the result of the merge is also ordered
        public static void CallMergeSortedArrays()
        {
            var result = MergeSortedArrays(new int[] { 0, 3, 4, 31 }, new int[] { 4, 6, 30, 31, 32, 33, 35 });

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static int[] MergeSortedArrays(int[] firstArray, int[] secondArray)
        {
            #region Explanation
            // Considering that both of the arrays are already ordered
            // One approach would be to loop through the total Length of both arrays once
            // and compare if the index of the first array is less than the second array
            // If it is, take the first array value, if not, take the second array value

            // For example the arrays below

            // Array A: [2,3,5,31]
            // Array B: [4,6,30]

            // We are gonna loop 7 times to order each number in the new merged array, keeping track of each index of each array in variables

            // So for the first iteration, the state of everything is:
            //------------------------------
            // Array Result: [0,0,0,0,0,0,0]
            // Array Result Index to Set: 0

            // Array A Index to Check: 0
            // Array B Index to Check: 0
            //------------------------------

            // And then we start the iteration comparing:
            // Is Array A at the index 0 less than Array B at the index 0? ArrayA[0] < ArrayB[0]? ---> 2 < 4?

            // Yes it is, so store value from Array A (2) in the Array Result

            // Now the state is:
            //------------------------------
            // Array Result: [2,0,0,0,0,0,0]
            // Array Result Index to Set: 1

            // Array A Index to Check: 1
            // Array B Index to Check: 0
            //------------------------------

            // Now, is Array A at the index 1 less than Array B at the index 0? ArrayA[1] < ArrayB[0]? ---> 3 < 4?

            // Yes it is, so store value from Array A (3) in the Array Result

            // Now the state is:
            //------------------------------
            // Array Result: [2,3,0,0,0,0,0]
            // Array Result Index to Set: 2

            // Array A Index to Check: 2
            // Array B Index to Check: 0
            //------------------------------

            // Now, is Array A at the index 2 less than Array B at the index 0? ArrayA[2] < ArrayB[0]? ---> 5 < 4?

            // No, so store value from Array B (4) in the Array Result

            // Now the state is:
            //------------------------------
            // Array Result: [2,3,4,0,0,0,0]
            // Array Result Index to Set: 3

            // Array A Index to Check: 2
            // Array B Index to Check: 1
            //------------------------------

            // And keep doing this until the array result is filled
            // Adding some checks to avoid exceptions on accessing indexes that does not exists
            #endregion


            var resultArray = new int[firstArray.Length + secondArray.Length];

            var indexToSet = 0;
            var firstArrayIndex = 0;
            var secondArrayIndex = 0;

            for (var i = 0; i < resultArray.Length; i++)
            {
                if (firstArrayIndex > firstArray.Length - 1)
                {
                    resultArray[indexToSet] = secondArray[secondArrayIndex];
                    secondArrayIndex++;
                    indexToSet++;
                    continue;
                }

                if (secondArrayIndex > secondArray.Length - 1)
                {
                    resultArray[indexToSet] = firstArray[firstArrayIndex];
                    firstArrayIndex++;
                    indexToSet++;
                    continue;
                }

                if (firstArray[firstArrayIndex] < secondArray[secondArrayIndex])
                {
                    resultArray[indexToSet] = firstArray[firstArrayIndex];
                    firstArrayIndex++;
                }
                else
                {
                    resultArray[indexToSet] = secondArray[secondArrayIndex];
                    secondArrayIndex++;
                }

                indexToSet++;
            }

            return resultArray;
        }

        // Given a 6x6 2D Array, return the higher sum of hourglasses
        public static void CallHigherSumOfHourGlasses()
        {
            var dimensionalArray = new List<List<int>>()
        {
            new List<int>() { -9, -9, -9,  1, 1, 1 },
            new List<int>() { 0, -9, 0,  4, 3, 2 },
            new List<int>() { -9, - 9, - 9,  1, 2, 3 },
            new List<int>() {  0,  0,  8,  6, 6, 0 },
            new List<int>() { 0,  0,  0, - 2, 0, 0 },
            new List<int>() { 0,  0,  1 , 2 ,4 ,0 }
        };

            Console.WriteLine(HigherSumOfHourGlasses(dimensionalArray));
        }
        public static int HigherSumOfHourGlasses(List<List<int>> arr)
        {
            var rowIndex = 0;
            var columnIndex = 0;
            var iteration = 1;

            var resultSum = 0;

            for (var i = 0; i < 16; i++)
            {
                var sum = arr.ElementAt(rowIndex).ElementAt(columnIndex) +
                      arr.ElementAt(rowIndex).ElementAt(columnIndex + 1) +
                      arr.ElementAt(rowIndex).ElementAt(columnIndex + 2) +

                      arr.ElementAt(rowIndex + 1).ElementAt(columnIndex + 1) +

                      arr.ElementAt(rowIndex + 2).ElementAt(columnIndex) +
                      arr.ElementAt(rowIndex + 2).ElementAt(columnIndex + 1) +
                      arr.ElementAt(rowIndex + 2).ElementAt(columnIndex + 2);

                if (i == 0 || resultSum < sum)
                {
                    resultSum = sum;
                }

                columnIndex++;
                iteration++;

                if (iteration > 4)
                {
                    iteration = 1;
                    rowIndex++;
                    columnIndex = 0;
                }
            }

            return resultSum;
        }

        public static void CallDiagonalDifference()
        {
            var dimensionalArray = new List<List<int>>()
            {
                new List<int>() {   1,   2,   3,   4,  5 },
                new List<int>() {   7,   8,   9,  18, 11 },
                new List<int>() {  13,  14,  200,  16, 17 },
                new List<int>() {  19,  20,  21,  22, 23 },
                new List<int>() {  25,  26,  27,  28, 29 }
            };

            Console.WriteLine(DiagonalDifference(dimensionalArray));
        }
        public static int DiagonalDifference(List<List<int>> arr)
        {
            var leftToRightSum = 0;
            var rightToLeftSum = 0;

            for (var i = 0; i < arr.Count; i++)
            {
                leftToRightSum += arr.ElementAt(i).ElementAt(i);
            }

            var index = 0;
            for (var i = arr.Count; i > 0; i--)
            {
                rightToLeftSum += arr.ElementAt(index).ElementAt(i - 1);
                index++;
            }

            return Math.Abs(leftToRightSum - rightToLeftSum);
        }

        public static void Staircase(int n)
        {
            var result = string.Empty;

            for (var i = 1; i <= n; i++)
            {
                for (var j = n; j > 0; j--)
                {
                    if (j <= i)
                    {
                        result += "#";
                    }
                    else
                    {
                        result += " ";
                    }

                    if (j == 1)
                    {
                        result += "\r\n";
                        break;
                    }
                }
            }

            Console.WriteLine(result);
        }

        public static void CallMiniMaxSum()
        {
            MiniMaxSum(new List<int>() { 1, 2, 3, 4, 5 });
        }
        public static void MiniMaxSum(List<int> arr)
        {
            long? maxSum = null;
            long? minSum = null;

            for (var i = 0; i < arr.Count; i++)
            {
                long controlSum = 0;

                for (var j = 0; j < arr.Count; j++)
                {
                    if (j == i)
                    {
                        continue;
                    }

                    controlSum += arr[j];
                }

                if (maxSum == null)
                {
                    maxSum = controlSum;
                }

                if (minSum == null)
                {
                    minSum = controlSum;
                }

                if (maxSum < controlSum)
                {
                    maxSum = controlSum;
                }

                if (minSum > controlSum)
                {
                    minSum = controlSum;
                }
            }

            Console.WriteLine($"{minSum} {maxSum}");
        }


        public static void CallBirthdayCakeCandles()
        {
            Console.WriteLine(BirthdayCakeCandles(new List<int>() { 44, 53, 31, 27, 77, 60, 66, 77, 26, 36 }));
        }
        public static int BirthdayCakeCandles(List<int> candles)
        {
            var countCandles = 0;
            var maxCandleValue = 0;

            foreach (var candle in candles)
            {
                if (candle >= maxCandleValue)
                {
                    if (candle != maxCandleValue) countCandles = 0;

                    maxCandleValue = candle;
                    countCandles++;
                }
            }

            return countCandles;
        }
    }
}
