using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbersInLinkedList
{
    /// <summary>
    /// You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverese order, and each of their nodes
    /// contains a single digit. Add the two numbers nad return the sum as  alinked list
    /// </summary>

    /// Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {

        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // Result Head
            ListNode start = null;
            ListNode head = null;

            var remainder = 0;
            // Keep on adding the values until there are no nodes left
            while (l1 != null || l2 != null || remainder > 0)
            {
                // Insert a value of 0 for any that are non existent
                var n1 = l1 != null ? l1.val : 0;
                var n2 = l2 != null ? l2.val : 0;

                // Now add the node values together
                var sumOfNodes = n1 + n2 + remainder;

                // Set remainder to 0 again
                remainder = 0;

                // Check if the sum >= 10, as the remainder cannot be more than 1 (max sum == 9 + 9 + 1 == 19)
                if (sumOfNodes >= 10)
                {
                    remainder = 1;
                }

                // Dont exculde the last node
                var prev = head;

                // Create a new node
                head = new ListNode(sumOfNodes % 10);

                // Connect the last node to the current head
                if (prev != null)
                {
                    prev.next = head;
                }
                // If there was no previous node, then this node will be the start
                else
                    start = head;

                l1 = l1?.next;
                l2 = l2?.next;
            }
            return start;
        }
    }
}
