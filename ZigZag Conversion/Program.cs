using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZag_Conversion
{
    /// <summary>
    /// The String "PAYPALISHIRING" is written in a zigzag pattern on a given number of rowws like this; 
    /// P   A   H   N
    ///    A P L S I I G
    ///     Y I R
    /// </summary>
    public class Program
    {
        private static int numHorizontalRows = 0;
        private static List<int> firstLineIndexes = new List<int>();
        private static int lengthOfChars = 0;
        private static char[] chars;
        private const string V = "";

        public static void Main(string[] args)
        {

            // Declare Param values
            int numRows = 4;
            string word = "PAYPALISHIRING";

            chars = new char[numRows + 1];

            // First conver the string to a char array 
            chars = Convert(word, numRows);

            //// Second, get the length of the char array and subtract one since we are starting from 0
            lengthOfChars = chars.Length - 1;


            //// Third, get the # of horizontal rows that will exist
            numHorizontalRows = GetNumberOfHorizontalRows(lengthOfChars, numRows);

            //// Fourth, Get the First Line, Second Line, etc Index Values
            firstLineIndexes = GetFirstLineIndexes(chars, numHorizontalRows, lengthOfChars);
            GetRemainingLines();

            PrintList();
            //List<int> secondLineIndexes = GetSecondLineIndexes(firstLineIndexes, lengthOfChars);
            //List<int> thirdLineIndexes = GetThirdLineIndexes(secondLineIndexes, lengthOfChars);

            //// Then, we can get the first line of strings
            //string lineString = null;
            //string firstLine = GetLine(chars, firstLineIndexes);
            //Console.WriteLine($"First String: {firstLine}");
            
            //string secondLine = GetLine(chars, secondLineIndexes);
            //Console.WriteLine($"Second String: {secondLine}");
            //Console.WriteLine(Convert("PAYPALISHIRING", 3));
            Console.ReadKey();
        }

        public static void PrintList()
        {
            Console.WriteLine("First Line Indexes:");
            firstLineIndexes.ForEach(x => Console.WriteLine(x));
        }

        /// <summary>
        /// Helper function to convert the string to a char array
        /// </summary>
        /// <param name="s"></param>
        /// <param name="numRows"></param>
        /// <returns></returns>
        public static Char[] Convert(string s, int numRows)
        {
            // Conver string to char array
            char[] chars = s.ToCharArray();
            return chars;
        }


        /// <summary>
        ///  Helper function to calculate the number of horizontal rows exist
        /// </summary>
        /// <param name="len"></param>
        /// <param name="numRows"></param>
        /// <returns></returns>
        private static int GetNumberOfHorizontalRows(int length, int numRows)
        {
            // Calculate metrics for number of Horizontal (only ones with 3 up and down, none of the middle ones in diagonal) rows and any remainder
            int numHorizontalRows;
            int remainder;
            if (length % numRows == 0)
            {
                numHorizontalRows = length % numRows;
            }
            else
            {
                numHorizontalRows = Math.DivRem(length, numRows, out remainder);
            }

            return numHorizontalRows;
        }

        private static string GetLine(char[] chars, List<int> lineIndexes)
        {
            string line = null;

            // Get the letters from each index of the chars array
            foreach(var index in lineIndexes)
            {
                line += chars[index];
            }
           
            return line;
        }


        /// <summary>
        /// Helper function that splits out the index values for the first line string
        /// </summary>
        /// <param name="chars"></param>
        /// <param name="numHorizontalRows"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static List<int> GetFirstLineIndexes(char[] chars, int numHorizontalRows, int length)
        {

            // Since, the first string will always include the 0 index
            firstLineIndexes.Add(0);

            bool keepGoing = true;
            int multiplyIterator = 1;
            
            // Loop through the list and get the indexes of the first line character
            while (keepGoing)
            {
                if (numHorizontalRows * multiplyIterator < length)
                {
                    int result = numHorizontalRows * multiplyIterator;
                    firstLineIndexes.Add(result);
                    multiplyIterator += 1;
                }
                else
                    keepGoing = false;
            }
            return firstLineIndexes;
        }

        public static void GetRemainingLines()
        {
            for (int i = 0; i < lengthOfChars; i++)
            {
                if (firstLineIndexes.Contains(i))
                {
                    continue;
                }
                
            }
        }

        /// <summary>
        /// Helper function that splits out the index values for the second line string
        /// </summary>
        public static List<int> GetSecondLineIndexes(List<int> firstLineIndexes, int length)
        {
            List<int> response = new List<int>();

            // We know, by default the second element will always be in the second line
            response.Add(1);

            // Get the last element value
            int lastElement = firstLineIndexes[firstLineIndexes.Count() - 1];
            Console.WriteLine($"Second Line Indexes: ");

            // Declare prev and next int nodes
            int prev, next = 0;
            if (firstLineIndexes.Count > 1)
            {
                foreach(var index in firstLineIndexes)
                {
                    prev = index - 1;
                    next = index + 1;

                    if(prev > 0 && next <= length)
                    {
                        response.Add(prev);
                        response.Add(next);
                    }

                    Console.WriteLine($"Previous Node Index: {prev}, First Line Index: {index}, Next Node Index: {next}");
                }
            }
            return response;
        }


        /// <summary>
        /// Helper function that splits out the index values for the third line string
        /// </summary>
        public static List<int> GetThirdLineIndexes(List<int> secondLineIndexes, int length)
        {
            List<int> response = new List<int>();

            // We know, by default the second element will always be in the second line
            response.Add(1);

            // Get the last element value
            int lastElement = secondLineIndexes[secondLineIndexes.Count() - 1];
            Console.WriteLine($"Third Line Indexes: ");

            // Declare prev and next int nodes
            int prev, next = 0;
            if (secondLineIndexes.Count > 1)
            {
                foreach (var index in secondLineIndexes)
                {
                    prev = index - 1;
                    next = index + 1;

                    if (prev > 0 && next <= length)
                    {
                        response.Add(prev);
                        response.Add(next);
                    }

                    Console.WriteLine($"Previous Node Index: {prev}, First Line Index: {index}, Next Node Index: {next}");
                }
            }
            return response;
        }
    }
}
