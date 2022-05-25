using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindromicSubstring
{
    /// <summary>
    /// Given a string s, return the longest palindromic substring in s
    /// Example:
    ///     Input: s = "badab"
    ///     Output: "bab"
    ///     Explanation: "aba" is also a valid answer
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            string s = "babad";
            Console.WriteLine($"For string 'babad' : result: {LongestPalindrome(s)}");

            s = "cbbd";
            Console.WriteLine($"For string 'cbbd' : result: {LongestPalindrome(s)}");
            Console.ReadKey();
        }

        /// <summary>
        /// Function that will split out the string into a current, left, odd and max node int variable
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string LongestPalindrome(string s)
        {
            if (s.Length <= 1) return s;

            int left = 0, odd, even, curr, max = 0;

            //Loop through each value in the string
            for (int i = 0; i < s.Length; i++)
            {
                // First, we can check for a palindrom of the odd length
                // We will pass in the s value and the current iteration twice
                // Example: 121
                odd = GetPalindrome(s, i, i);

                // Second, wew can check for a palindrom off the even length
                // We will pass in the s value, the current iterator and the next iteration
                // Example 1221
                even = GetPalindrome(s, i, i + 1);

                // Now we want to compare the two results
                curr = (odd > even ? odd : even);

                // If the new current value is greater than the last max, update max
                if (curr > max)
                {
                    // Set the new max value
                    max = curr;

                    //calculate new left value
                    left = i - (max - 1) / 2;

                }
            }

            return s.Substring(left, max);
        }

        private static int GetPalindrome(string s, int left, int right)
        {
            // While the left value is equal to the first run or later,
            // the right values still exist,
            // and the left nad right values in string are equal
            // We continue traversing, as this is a palindome
            while(left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return right - left - 1;
        }
    }
}
