// Url:https://leetcode.com/problems/maximum-level-sum-of-a-binary-tree

/*
1161. Maximum Level Sum of a Binary Tree
Medium

Given the root of a binary tree, the level of its root is 1,&#xA0;the level of its children is 2,&#xA0;and so on.

Return the smallest level X such that the sum of all the values of nodes at level X is maximal.

&#xA0;

Example 1:



Input: [1,7,0,7,-8,null,null]
Output: 2
Explanation: 
Level 1 sum = 1.
Level 2 sum = 7 + 0 = 7.
Level 3 sum = 7 + -8 = -1.
So we return the level with the maximum sum which is level 2.


&#xA0;

Note:


	The number of nodes in the given tree is between 1 and 10^4.
	-10^5 &lt;= node.val &lt;= 10^5
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1161
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public int MaxLevelSum(TreeNode root) { }
    }
