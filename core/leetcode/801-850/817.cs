// Url:https://leetcode.com/problems/linked-list-components

/*
817. Linked List Components
Medium

We are given&#xA0;head,&#xA0;the head node of a linked list containing&#xA0;unique integer values.

We are also given the list&#xA0;G, a subset of the values in the linked list.

Return the number of connected components in G, where two values are connected if they appear consecutively in the linked list.

Example 1:

Input: 
head: 0-&gt;1-&gt;2-&gt;3
G = [0, 1, 3]
Output: 2
Explanation: 
0 and 1 are connected, so [0, 1] and [3] are the two connected components.


Example 2:

Input: 
head: 0-&gt;1-&gt;2-&gt;3-&gt;4
G = [0, 3, 1, 4]
Output: 2
Explanation: 
0 and 1 are connected, 3 and 4 are connected, so [0, 1] and [3, 4] are the two connected components.


Note: 


	If&#xA0;N&#xA0;is the&#xA0;length of the linked list given by&#xA0;head,&#xA0;1 &lt;= N &lt;= 10000.
	The value of each node in the linked list will be in the range [0, N - 1].
	1 &lt;= G.length &lt;= 10000.
	G is a subset of all values in the linked list.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution817
{
    /** * Definition for singly-linked list. * public class ListNode { *     public int val; *     public ListNode next; *     public ListNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public int NumComponents(ListNode head, int[] G) { }
    }
}
