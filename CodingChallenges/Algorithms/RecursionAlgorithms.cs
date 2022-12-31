namespace CodingChallenges.Algorithms
{
    public static class RecursionAlgorithms
    {
        // Fibonnaci: 0, 1, 1, 2, 3, 5, 8, 13, 21
        // index = 6
        // return = 8
        public static int GetValueOfFibonacciByIndex(int index)
        {
            if (index < 2) return index;

            return GetValueOfFibonacciByIndex(index - 1) + GetValueOfFibonacciByIndex(index - 2);
        }

        // Fibonnaci: 0, 1, 1, 2, 3, 5, 8, 13, 21
        // index = 6
        // return = 8
        public static int GetValueOfFibonacciByIndexIterative(int index)
        {
            if (index < 2) return index;

            var iterations = 0;
            var previousNumber = 0;
            var currentNumber = 1;
            var result = 0;

            while (true)
            {
                if (iterations == (index - 1)) break;

                result = previousNumber + currentNumber;

                previousNumber = currentNumber;
                currentNumber = result;

                iterations++;
            }

            return result;
        }
    }
}
