// Url:https://leetcode.com/problems/check-completeness-of-a-binary-tree

/*
958. Check Completeness of a Binary Tree
Medium

Given a binary tree, determine if it is a complete binary tree.

Definition of a complete binary tree from Wikipedia:
In a complete binary tree every level, except possibly the last, is completely filled, and all nodes in the last level are as far left as possible. It can have between 1 and 2h nodes inclusive at the last level h.

&#xA0;

Example 1:



Input: [1,2,3,4,5,6]
Output: true
Explanation: Every level before the last is full (ie. levels with node-values {1} and {2, 3}), and all nodes in the last level ({4, 5, 6}) are as far left as possible.



Example 2:



Input: [1,2,3,4,5,null,7]
Output: false
Explanation: The node with value 7 isn&apos;t as far left as possible.


&#xA0;


Note:


	The tree will have between 1 and 100 nodes.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution958
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public bool IsCompleteTree(TreeNode root) { }
    }
}
