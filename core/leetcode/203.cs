// Url:https://leetcode.com/problems/remove-linked-list-elements

/*
203. Remove Linked List Elements
Easy

Remove all elements from a linked list of integers that have value val.

Example:

Input:  1->2->6->3->4->5->6, val = 6
Output: 1->2->3->4->5
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution203 {
    public class Solution {
        public void Init () {
            Console.WriteLine ();
        }

        public ListNode RemoveElements (ListNode head, int val) {

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