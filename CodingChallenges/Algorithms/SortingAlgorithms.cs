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


        public static void CallMergeSort()
        {
            var teste = MergeSort(new int[] { 99, 44, 6, 2, 2, 5, 63, 87, 87, 4, 0 });
            var test2 = MergeSort(new int[] { 6, 5, 3, 1, 8, 7, 2, 4 });
        }
        public static IEnumerable<int> MergeSort(IEnumerable<int> array)
        {
            if (array.Count() == 1) return array;

            var middle = array.Count() / 2;
            var left = array.Take(middle);
            var right = array.Skip(middle);

            // Each time the recursion runs, it will merge the left and right arrays
            return MergeTwoArrays(
                MergeSort(left), // Keeps breaking the left array in half until there is only one value in each array
                MergeSort(right) // Keeps breaking the right array in half until there is only one value in each array
            );
        }

        private static List<int> MergeTwoArrays(IEnumerable<int> leftArray, IEnumerable<int> rightArray)
        {
            var resultArray = new List<int>();

            var leftIndex = 0;
            var rightIndex = 0;

            // left: [0,3,5]  right: [1,56,70]

            while (leftIndex < leftArray.Count() && rightIndex < rightArray.Count())
            {
                // 1a iteração
                // 0 < 1?
                // Sim, então vai o 0 para o array

                // 2a iteração
                // 3 < 1?
                // Não, então vai o 1 para o array

                // 3a iteração
                // 3 < 56?
                // ... e por ai vai...
                if (leftArray.ElementAt(leftIndex) < rightArray.ElementAt(rightIndex))
                {
                    resultArray.Add(leftArray.ElementAt(leftIndex));
                    leftIndex++;
                }
                else
                {
                    resultArray.Add(rightArray.ElementAt(rightIndex));
                    rightIndex++;
                }
            }

            // Adiciona o restante dos "maiores" do array da esquerda primeiro
            // para que fiquem à esquerda dos
            resultArray.AddRange(leftArray.Skip(leftIndex));

            // restantes dos "maiores" do array da direita
            resultArray.AddRange(rightArray.Skip(rightIndex));

            return resultArray;
        }
    }
}
