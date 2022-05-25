using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumberOfGroupsGettingFreshDonuts
{
    /// <summary>
    /// There is a donuts shop that bakes donuts in batches of (batchSize). They have a rule where they must server all of the donuts of a batch before serving any of the next batch
    /// You are given an int (batchSize) and an int array (groups) where (groups[i]) denotes that there is a group of groups[i] customers that will visit the shop. Each customer will get exactly one donut
    /// When a group visits the shop, all customers of the group must be served before serving any of the following groups. 
    /// A group will be happy if they all get fresh donuts. That is, the first customer of the group does not recieve a donut that was left over from the previous group
    /// You can freely rearrange the ordering of the groups
    /// Return the max possibly number of happy groups after rearranging the groups
    /// Example:
    ///     Input: batchSize = 3, groups = [1,2,3,4,5,6]
    ///     Output: 4
    ///     Explanation: You can arrange the groups as [6,2,4,5,1,3]. Then the 1st, 2nd, 4th, and 6th groups will be happy
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            int batchSize = 3;
            int[] groups = new int[] { 1, 2, 3, 4, 5, 6 };


        }
    }
}
