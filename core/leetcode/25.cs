// Url:https://leetcode.com/problems/reverse-nodes-in-k-group

/*
25. Reverse Nodes in k-Group
Hard

Given a linked list, reverse the nodes of a linked list k at a time and return its modified list.

k is a positive integer and is less than or equal to the length of the linked list. If the number of nodes is not a multiple of k then left-out nodes in the end should remain as it is.




Example:

Given this linked list: 1->2->3->4->5

For k = 2, you should return: 2->1->4->3->5

For k = 3, you should return: 3->2->1->4->5

Note:


	Only constant extra memory is allowed.
	You may not alter the values in the list's nodes, only nodes itself may be changed.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem25
{
    public class Solution
    {
        public void Init()
        {
            Console.WriteLine();
        }

        // Time: O ()
        // Space: O ()
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            return null;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }
}