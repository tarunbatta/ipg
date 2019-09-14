// Url:https://leetcode.com/problems/reorder-list

/*
143. Reorder List
Medium

Given a singly linked list L: L0&#x2192;L1&#x2192;&#x2026;&#x2192;Ln-1&#x2192;Ln,
reorder it to: L0&#x2192;Ln&#x2192;L1&#x2192;Ln-1&#x2192;L2&#x2192;Ln-2&#x2192;&#x2026;

You may not modify the values in the list's nodes, only nodes itself may be changed.

Example 1:

Given 1-<2-<3-<4, reorder it to 1-<4-<2-<3.

Example 2:

Given 1-<2-<3-<4-<5, reorder it to 1-<5-<2-<4-<3.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution143 {
    public class Solution {
        public void Init () {

        }

        public void ReorderList (ListNode head) {

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