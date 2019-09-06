// Url:https://leetcode.com/problems/verify-preorder-serialization-of-a-binary-tree

/*
331. Verify Preorder Serialization of a Binary Tree
Medium

One way to serialize a binary tree is to use pre-order traversal. When we encounter a non-null node, we record the node&apos;s value. If it is a null node, we record using a sentinel value such as #.

     _9_
    /   \
   3     2
  / \   / \
 4   1  #  6
/ \ / \   / \
# # # #   # #


For example, the above binary tree can be serialized to the string &quot;9,3,4,#,#,1,#,#,2,#,6,#,#&quot;, where # represents a null node.

Given a string of comma separated values, verify whether it is a correct preorder traversal serialization of a binary tree. Find an algorithm without reconstructing the tree.

Each comma separated value in the string must be either an integer or a character &apos;#&apos; representing null pointer.

You may assume that the input format is always valid, for example it could never contain two consecutive commas such as &quot;1,,3&quot;.

Example 1:

Input: &quot;9,3,4,#,#,1,#,#,2,#,6,#,#&quot;
Output: true

Example 2:

Input: &quot;1,#&quot;
Output: false


Example 3:

Input: &quot;9,#,#,1&quot;
Output: false
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution331
{
    public class Solution
    {
        public void Init() { }

        public bool IsValidSerialization(string preorder) { }
    }
}
