// Url:https://leetcode.com/problems/balanced-binary-tree

/*
110. Balanced Binary Tree
Easy

Given a binary tree, determine if it is height-balanced.

For this problem, a height-balanced binary tree is defined as:


a binary tree in which the depth of the two subtrees of every node never differ by more than 1.


Example 1:

Given the following tree [3,9,20,null,null,15,7]:

    3
   / \
  9  20
    /  \
   15   7

Return true.

Example 2:

Given the following tree [1,2,2,3,3,null,null,4,4]:

       1
      / \
     2   2
    / \
   3   3
  / \
 4   4


Return false.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution110
{
    public class Solution
    {
        public void Init() { }

        public bool IsBalanced(TreeNode root)
        {
            return false;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }
}
