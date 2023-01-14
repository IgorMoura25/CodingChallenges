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

        // Given an integer x, return true if x is a palindrome, and false otherwise.
        // An integer is a palindrome when it reads the same forward and backward. For example, 121 is a palindrome while 123 is not.
        public static bool IsPalindrome(int x)
        {
            // Negatives are not palindrome
            if (x < 0)
            {
                return false;
            }

            // One digits are palindromes
            if (x < 10 && x >= 0)
            {
                return true;
            }

            var reverseInteger = string.Empty;
            var remaining = x;

            reverseInteger += remaining % 10; // Gets the last digit of the number using modulus

            while (true)
            {
                remaining = remaining / 10; // Divide number to get all digits except the last one. Ex: 1234 / 10 > 123

                // If the result is one digit, we're done iterating
                if (remaining < 10)
                {
                    reverseInteger += remaining;
                    break;
                }

                // If the result is still more than 1 digit, we get the last digit using modulus. Ex: 123 mod 10 > 3
                reverseInteger += (remaining % 10);
            }

            if (Convert.ToInt64(reverseInteger) == x)
            {
                return true;
            }

            return false;
        }

        public static int RomanToInt(string s)
        {
            var result = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var letter = s[i];
                var isLastLetter = i + 1 == s.Length;
                char? nextLetter = isLastLetter ? (char?)null : s[i + 1];

                if (letter == 'V')
                {
                    result += 5;
                }

                if (letter == 'M')
                {
                    result += 1000;
                }

                if (letter == 'L')
                {
                    result += 50;
                }

                if (letter == 'D')
                {
                    result += 500;
                }

                if (letter == 'I')
                {
                    if (nextLetter == 'V')
                    {
                        result += 4;
                        i++;
                        continue;
                    }

                    if (nextLetter == 'X')
                    {
                        result += 9;
                        i++;
                        continue;
                    }

                    result += 1;
                }

                if (letter == 'X')
                {
                    if (nextLetter == 'L')
                    {
                        result += 40;
                        i++;
                        continue;
                    }

                    if (nextLetter == 'C')
                    {
                        result += 90;
                        i++;
                        continue;
                    }

                    result += 10;
                }

                if (letter == 'C')
                {
                    if (nextLetter == 'D')
                    {
                        result += 400;
                        i++;
                        continue;
                    }

                    if (nextLetter == 'M')
                    {
                        result += 900;
                        i++;
                        continue;
                    }

                    result += 100;
                }
            }

            return result;
        }
    }
}
