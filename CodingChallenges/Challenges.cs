namespace CodingChallenges
{
    public static class Challenges
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var returnIndices = new List<int>();
            var hashTable = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (hashTable.ContainsKey(nums[i]))
                {
                    returnIndices.Add(hashTable[nums[i]]);
                    returnIndices.Add(i);
                }

                if (!hashTable.ContainsKey(diff))
                {
                    hashTable.Add(diff, i);
                }
            }

            return returnIndices.ToArray();
        }
    }
}
