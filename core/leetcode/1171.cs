// Url:https://leetcode.com/problems/remove-zero-sum-consecutive-nodes-from-linked-list

/*
1171. Remove Zero Sum Consecutive Nodes from Linked List
Medium

Given the head of a linked list, we repeatedly delete consecutive sequences of nodes that sum to 0 until there are no such sequences.

After doing so, return the head of the final linked list.&#xA0; You may return any such answer.

&#xA0;
(Note that in the examples below, all sequences are serializations of ListNode objects.)

Example 1:

Input: head = [1,2,-3,3,1]
Output: [3,1]
Note: The answer [1,2,1] would also be accepted.


Example 2:

Input: head = [1,2,3,-3,4]
Output: [1,2,4]


Example 3:

Input: head = [1,2,3,-3,-2]
Output: [1]


&#xA0;
Constraints:


	The given linked list will contain between 1 and 1000 nodes.
	Each node in the linked list has -1000 &lt;= node.val &lt;= 1000.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1171 {
    public class Solution {
        public void Init () {

        }

        public ListNode RemoveZeroSumSublists (ListNode head) {
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