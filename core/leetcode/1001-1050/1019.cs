// Url:https://leetcode.com/problems/next-greater-node-in-linked-list

/*
1019. Next Greater Node In Linked List
Medium

We are given a linked list with&#xA0;head&#xA0;as the first node.&#xA0; Let&apos;s number the&#xA0;nodes in the list: node_1, node_2, node_3, ... etc.

Each node may have a next larger value: for node_i,&#xA0;next_larger(node_i)&#xA0;is the node_j.val such that j &gt; i, node_j.val &gt; node_i.val, and j is the smallest possible choice.&#xA0; If such a j&#xA0;does not exist, the next larger value is 0.

Return an array of integers&#xA0;answer, where answer[i] = next_larger(node_{i+1}).

Note that in the example inputs&#xA0;(not outputs) below, arrays such as [2,1,5]&#xA0;represent the serialization of a linked list with a head node value of 2, second node value of 1, and third node value of 5.

&#xA0;


Example 1:

Input: [2,1,5]
Output: [5,5,0]



Example 2:

Input: [2,7,4,3,5]
Output: [7,0,5,5,0]



Example 3:

Input: [1,7,5,1,9,2,5,1]
Output: [7,9,9,9,0,5,0,0]


&#xA0;

Note:


	1 &lt;= node.val&#xA0;&lt;= 10^9&#xA0;for each node in the linked list.
	The given list has length in the range [0, 10000].
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1019
{
    /** * Definition for singly-linked list. * public class ListNode { *     public int val; *     public ListNode next; *     public ListNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public int[] NextLargerNodes(ListNode head) { }
    }
}
