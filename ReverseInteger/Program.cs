using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    /// <summary>
    /// Given a signed 32-bit integer (x), return (x) with its digits reversed. If reversing x causes to value to go outside the signed 32-bit int range, then return 0
    /// Example: 
    ///     Input: X = 123
    ///     Output: 321
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Int32 x = 123;
            Console.WriteLine(Reverse(x));
            Console.ReadKey();
        }

        private static Int32 Reverse(Int32 x)
        {
            
            char[] splitInt = x.ToCharArray();
            Array.Reverse(splitInt);
            string splitIntString = splitInt.ToString();
            Console.WriteLine(splitIntString);
            return Convert.ToInt32(splitIntString);
        }
    }
}
