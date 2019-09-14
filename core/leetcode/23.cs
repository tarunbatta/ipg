// Url:https://leetcode.com/problems/merge-k-sorted-lists

/*
23. Merge k Sorted Lists
Hard

Merge k sorted linked lists and return it as one sorted list. Analyze and describe its complexity.

Example:

Input:
[
  1-<4-<5,
  1-<3-<4,
  2-<6
]
Output: 1-<1-<2-<3-<4-<4-<5-<6
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution23 {
    public class Solution {
        public void Init () {

        }

        public ListNode MergeKLists (ListNode[] lists) {
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