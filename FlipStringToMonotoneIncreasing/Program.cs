using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipStringToMonotoneIncreasing
{
    /// <summary>
    /// A binary string is monotone increasing if it consists of some number of 0's (possibly none) followed by some number of 1's (also possibly none)
    /// You are given a binary string (s). You can flip s[i] changing it from 0 to 1 or from 1 to 0
    /// Return the min number of flips to make s monotone increasing
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            int s = 00110;
            bool numFlips = NumberOfFlipsToBeMonotoneIncreasing(s);
            Console.WriteLine(numFlips);
            Console.ReadKey();
        }

        private static bool NumberOfFlipsToBeMonotoneIncreasing(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = revertedNumber * 10 + x % 10;
                x /= 10;
            }

            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
