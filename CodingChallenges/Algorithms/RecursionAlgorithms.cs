namespace CodingChallenges.Algorithms
{
    public static class RecursionAlgorithms
    {
        public static int Iterations { get; private set; }

        // Fibonnaci: 0, 1, 1, 2, 3, 5, 8, 13, 21
        // index = 6
        // return = 8
        public static int GetValueOfFibonacciByIndex(int index)
        {
            Iterations++;

            if (index < 2) return index;

            var a = GetValueOfFibonacciByIndex(index - 1);
            var b = GetValueOfFibonacciByIndex(index - 2);

            return a + b;
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

            Iterations = iterations;
            return result;
        }

        public static int FibonacciMemoizedMaster(int index)
        {
            var cache = new Dictionary<int, int>();

            var result = FibonacciMemoized(index, cache);

            return result;
        }

        public static int FibonacciMemoized(int index, Dictionary<int, int> cache)
        {
            Iterations++;

            if (cache.ContainsKey(index)) return cache[index];

            if (index < 2) return index;

            var a = FibonacciMemoized(index - 1, cache);
            var b = FibonacciMemoized(index - 2, cache);

            var result = a + b;

            cache.Add(index, result);

            return result;
        }
    }
}
