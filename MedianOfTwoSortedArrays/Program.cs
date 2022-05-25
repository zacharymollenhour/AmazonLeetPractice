using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianOfTwoSortedArrays
{
    /// <summary>
    /// Given twwo sorted arrays (nums1 and nums2) of size (m and n) respectively
    /// Return the median of the two sorted arrays
    /// The overall runtime complexity should be O(log (m+n))
    /// Example:
    ///     Input: nums1 = [1,3] , nums2 = [2]
    ///     Output: 2.00000
    ///     Explanation: Merged array = [1,2,3] and median is 2
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 3 };
            int[] nums2 = new int[] { 2 };

            Console.WriteLine(FindMedianSortedArrays(nums1, nums2));

        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // Declare new list to store results in
            List<int> newList = new List<int>();

            // Append both int arrays to the new list
            newList.AddRange(nums1);
            newList.AddRange(nums2);

            newList.Sort();

            // If there are an odd number of items in the list
            // we can just return the middle element
            if (newList.Count() % 2 != 0)
            {
                return (double)newList[newList.Count() / 2];
            }

            // If there are an event amount of items in the list
            // We must first get the item to the left of the middle
            // Then get the item to its right. Take the sum of those elements
            // And then divide the sum / 2 to get the median
            else 
                return (double)(newList[newList.Count() /2 - 1] + newList[newList.Count() / 2]) / 2;
            
        }

    }
}
