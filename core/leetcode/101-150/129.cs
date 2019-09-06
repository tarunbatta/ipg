// Url:https://leetcode.com/problems/sum-root-to-leaf-numbers

/*
129. Sum Root to Leaf Numbers
Medium

Given a binary tree containing digits from 0-9 only, each root-to-leaf path could represent a number.

An example is the root-to-leaf path 1-&gt;2-&gt;3 which represents the number 123.

Find the total sum of all root-to-leaf numbers.

Note:&#xA0;A leaf is a node with no children.

Example:

Input: [1,2,3]
    1
   / \
  2   3
Output: 25
Explanation:
The root-to-leaf path 1-&gt;2 represents the number 12.
The root-to-leaf path 1-&gt;3 represents the number 13.
Therefore, sum = 12 + 13 = 25.

Example 2:

Input: [4,9,0,5,1]
    4
   / \
  9   0
&#xA0;/ \
5   1
Output: 1026
Explanation:
The root-to-leaf path 4-&gt;9-&gt;5 represents the number 495.
The root-to-leaf path 4-&gt;9-&gt;1 represents the number 491.
The root-to-leaf path 4-&gt;0 represents the number 40.
Therefore, sum = 495 + 491 + 40 = 1026.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution129
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public int SumNumbers(TreeNode root) { }
    }
}
