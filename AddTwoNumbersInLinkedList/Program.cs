using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbersInLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] l1 = new int[] { 2, 4, 3 };
            int[] l2 = new int[] { 5, 6, 4 };

            int[] result = new int[l1.Count()];
            int[] reversedL1 = new int[l1.Count()];

            int length = l1.Length - 1;
            Console.WriteLine($"Length Of List1: {length}");
            for (int i = length; i >= 0; i--)
            {
                //
                // reversedL1 = reversedL1;
            }

            Console.WriteLine($"L1 result: {l1.ToString()}");
            Console.ReadKey();
        }

    }
}
