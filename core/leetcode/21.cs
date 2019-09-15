// Url:https://leetcode.com/problems/merge-two-sorted-lists

/*
21. Merge Two Sorted Lists
Easy

Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.

Example:
Input: 1->2->4, 1->3->4
Output: 1->1->2->3->4->4
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution21 {
    public class Solution {
        public void Init () {
            Console.WriteLine ();
        }

        public ListNode MergeTwoLists (ListNode l1, ListNode l2) {
            return null;
        }
    }

    public class ListNode {
        public int val;
        public ListNode next;

        public ListNode (int x) {
            val = x;
        }
    }
}