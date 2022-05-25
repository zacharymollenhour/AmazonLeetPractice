using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_K_SortedLists
{
    /// <summary>
    /// You are given an array o fk linked-lists (lists), each linked-list is sorted in ascending order
    /// Merge all the linked-=lists into one sorted linked-list and return it
    /// Example:
    ///     Input: list = [[1,4,5],[1,3,4],[2,6]]
    ///     Output: [1,1,2,3,4,4,5,6]
    /// </summary>
    /// 


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(2);
            ListNode[] listNodes = new ListNode[] { l1, l2 };




        }
    }
}
