namespace CodingChallenges.Arrays
{
    public class HashTableChallenges
    {
        // Given an array, return the first recurring number
        public static void CallReturnFirstRecurringNumber()
        {
            Console.WriteLine(HashTableChallenges.ReturnFirstRecurringNumber(new int[] { 2, 5, 5, 1, 2, 3, 5, 1, 2, 4 }));
            Console.WriteLine(HashTableChallenges.ReturnFirstRecurringNumber(new int[] { 2, 1, 3, 2, 3, 5, 1, 2, 4 }));
            Console.WriteLine(HashTableChallenges.ReturnFirstRecurringNumber(new int[] { 2, 3, 4, 5 }));
        }
        public static string ReturnFirstRecurringNumber(int[] array)
        {
            #region Explanation
            // Considering that both of the arrays are already ordered
            // One approach would be to loop through the itens and use a HashTable to keep track
            // adding the number to the hash table only if does not exists yet
            // If it does exists, it means that this number is the first recurring
            #endregion

            var result = "null";

            var hashTable = new Dictionary<int, int>();

            // O(n)
            for (var indexOfArray = 0; indexOfArray < array.Length; indexOfArray++)
            {
                var value = array[indexOfArray];

                if (hashTable.ContainsKey(value))
                {
                    result = value.ToString();
                    break;
                }

                hashTable.Add(value, indexOfArray);
            }

            return result;
        }
    }
}
