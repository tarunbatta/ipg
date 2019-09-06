// Url:https://leetcode.com/problems/copy-list-with-random-pointer

/*
138. Copy List with Random Pointer
Medium

A linked list is given such that each node contains an additional random pointer which could point to any node in the list or null.

Return a deep copy of the list.

&#xA0;

Example 1:



Input:
{&quot;$id&quot;:&quot;1&quot;,&quot;next&quot;:{&quot;$id&quot;:&quot;2&quot;,&quot;next&quot;:null,&quot;random&quot;:{&quot;$ref&quot;:&quot;2&quot;},&quot;val&quot;:2},&quot;random&quot;:{&quot;$ref&quot;:&quot;2&quot;},&quot;val&quot;:1}

Explanation:
Node 1&apos;s value is 1, both of its next and random pointer points to Node 2.
Node 2&apos;s value is 2, its next pointer points to null and its random pointer points to itself.


&#xA0;

Note:


	You must return the copy of the given head&#xA0;as a reference to the cloned list.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution138
{
    /*// Definition for a Node.public class Node {    public int val;    public Node next;    public Node random;​    public Node(){}    public Node(int _val,Node _next,Node _random) {        val = _val;        next = _next;        random = _random;}*/
    public class Solution
    {
        public void Init() { }

        public Node CopyRandomList(Node head) { }
    }
}
