using java.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianDollEnvelopes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int result = maxEnvelopes(new int[][] {[[5,4], [6,4], [6,7], [2,3] } )
        }

        public static int maxEnvelopes(int[][] envelopes)

        {
            if (envelopes.Length == 0)
                return 0;

            if (envelopes.Length == 1)
                return 1;

            Array.Sort(envelopes, (e1, e2) =>
            {
                var compare = e1[0].CompareTo(e2[0]);
                if (compare != 0)
                    return compare;
                return e1[1].CompareTo(e2[1]);
            });

            int[] dp = new int[envelopes.Length];

            dp[0] = 1;

            for (int i = 1; i < envelopes.Length; i++)
            {
                dp[i] = 1;
                var curr = envelopes[i];

                for (int j = 0; j < i; j++)
                {
                    var prevDP = dp[j];
                    var prev = envelopes[j];

                    if (prev[0] < curr[0] && prev[1] < curr[1])
                    {
                        if (prevDP + 1 > dp[i])
                            dp[i] = prevDP + 1;
                    }
                }
            }
            return dp.Max();
        }
    }
}
