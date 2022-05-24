using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// Example: 
    ///     Input: nums = [2,7,11,15], target = 9
    ///     Output: [0,1]
    ///     Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numsList = new int[] { 2, 7, 11, 15 };
            int target = 9;

            // Execute the function 
            var response = GetTwoSum(numsList, target);
            Console.WriteLine($"[{response[0]},{response[1]}] ");
            Console.Read();
        }

        public static int[] GetTwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new Exception("Nums Array cannot be null");
            }
            if (target == 0)
            {
                return nums;
            }

            Dictionary<int, int> pairs = new Dictionary<int, int>();   
            
            // Loop through all nums and add the num and its index to the dictionary
            for (int i = 0; i < nums.Length; i++)
            {
                pairs.Add(nums[i], i);
            }

            // Loop through all of the pairs and get the complement (difference between the number and the target
            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                int a;
                if (pairs.TryGetValue(complement, out a))
                {

                    return new int[] { i, a };
                }
            }

            // Otherwise, return null when no solution exists
            return null;

        }
    }
}
