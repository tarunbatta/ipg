// Url:https://leetcode.com/problems/linked-list-cycle

/*
141. Linked List Cycle
Easy

Given a linked list, determine if it has a cycle in it.

To represent a cycle in the given linked list, we use an integer pos which represents the position (0-indexed)&#xA0;in the linked list where tail connects to. If pos is -1, then there is no cycle in the linked list.

&#xA0;


Example 1:

Input: head = [3,2,0,-4], pos = 1
Output: true
Explanation: There is a cycle in the linked list, where tail connects to the second node.






Example 2:

Input: head = [1,2], pos = 0
Output: true
Explanation: There is a cycle in the linked list, where tail connects to the first node.






Example 3:

Input: head = [1], pos = -1
Output: false
Explanation: There is no cycle in the linked list.





&#xA0;

Follow up:

Can you solve it using O(1) (i.e. constant) memory?
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution141
{
    /** * Definition for singly-linked list. * public class ListNode { *     public int val; *     public ListNode next; *     public ListNode(int x) { *         val = x; *         next = null; *     } * } */
    public class Solution
    {
        public void Init() { }

        public bool HasCycle(ListNode head) { }
    }
}
