// Url: https://leetcode.com/problems/reverse-linked-list-ii/

/*
92. Reverse Linked List II
Medium

Reverse a linked list from position m to n. Do it in one-pass.

Note: 1 ≤ m ≤ n ≤ length of list.

Example:

Input: 1->2->3->4->5->NULL, m = 2, n = 4
Output: 1->4->3->2->5->NULL
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem92 {
    public class Solution {
        public void Init () {
            ListNode l = new ListNode (1);
            l.next = new ListNode (2);
            l.next.next = new ListNode (3);
            l.next.next.next = new ListNode (4);
            l.next.next.next.next = new ListNode (5);

            Console.WriteLine (ReverseBetween (null, 2, 4));
            Console.WriteLine (ReverseBetween (null, 3, 3));
            Console.WriteLine (ReverseBetween (null, 4, 3));
            Console.WriteLine (ReverseBetween (l, 2, 4));
            Console.WriteLine (ReverseBetween (l, 3, 3));
        }

        public ListNode ReverseBetween (ListNode head, int m, int n) {
            if (head == null || m >= n) {
                return head;
            }

            ListNode result = new ListNode (0);
            result.next = head;
            ListNode node = result;
            for (int i = 0; i < m - 1; i++) {
                node = node.next;
            }

            ListNode first = node.next;
            ListNode next = first.next;

            for (int i = 0; i < n - m; i++) {
                first.next = next.next;
                next.next = node.next;
                node.next = next;
                next = first.next;
            }

            return result.next;
        }
    }

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode (int x) { val = x; }
    }
}