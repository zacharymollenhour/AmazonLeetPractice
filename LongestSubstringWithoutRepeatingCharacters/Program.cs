using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWithoutRepeatingCharacters
{
    /// <summary>
    /// Given a string s, find the length of the longest substring without repeating characters.
    /// Example: 
    ///     Input: s = "abcabcbb"
    ///     Output: 3
    ///     Explanation: The answer is "abc", with the length of 3.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            string testString = "pwwkew";

            var result = LengthOfLongestSubstring(testString);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int LengthOfLongestSubstring(string s)
        {
            // Return 0 when the string is empty
            if (s == null)
            {
                return 0;
            }

            // Create a dictionary to store each letter of the alphabet and a default of false for the boolean if it the value was already read
            Dictionary<char, bool> alphaHits = new Dictionary<char, bool>();
            char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            // Loop through alpha array and add each letter and a default false value
            for (int i = 0; i < alpha.Length; i++)
            {
                alphaHits.Add(alpha[i], false);
            }

            List<int> longestLengths = new List<int>();
            int longestLength = 0;
            int lastlongestLength = 0;
            foreach(char c in s)
            {
                bool value;
                if (alphaHits.TryGetValue(c, out value) && !value)
                {
                    longestLength++;
                    alphaHits[c] = true;
                }
                else if(lastlongestLength == 0)
                {

                    lastlongestLength = longestLength;
                    longestLength = 0;

                }
                else
                {
                    if (lastlongestLength > longestLength)
                    {
                        longestLength = 0;
                    }
                    else
                    {
                        lastlongestLength = longestLength;
                        longestLength = 0;
                    }
                }
            }


            return lastlongestLength > longestLength ? lastlongestLength : longestLength;
        }
    }
}
