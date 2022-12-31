namespace CodingChallenges.Algorithms
{
    public static class SortingAlgorithms
    {
        public static void CallBubbleSort()
        {
            var teste = BubbleSortAsc(new int[] { 99, 44, 6, 2, 2, 5, 63, 87, 87, 4, 0 });
            var teste2 = BubbleSortDesc(new int[] { 99, 44, 6, 2, 2, 5, 63, 87, 87, 4, 0 });
        }
        public static int[] BubbleSortAsc(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    // Asc
                    if (array[i] < array[j])
                    {
                        var iValue = array[i];
                        var jValue = array[j];

                        // swap
                        array[i] = jValue;
                        array[j] = iValue;
                    }
                }
            }

            return array;
        }

        public static int[] BubbleSortDesc(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    // Desc
                    if (array[i] > array[j])
                    {
                        var iValue = array[i];
                        var jValue = array[j];

                        // swap
                        array[i] = jValue;
                        array[j] = iValue;
                    }
                }
            }

            return array;
        }
    }
}
