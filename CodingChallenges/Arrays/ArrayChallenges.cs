namespace CodingChallenges.Arrays
{
    public class ArrayChallenges
    {
        // Given two sorted arrays, merge them as the result of the merge is also ordered
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
    }
}
