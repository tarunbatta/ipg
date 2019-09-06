// Url:https://leetcode.com/problems/trim-a-binary-search-tree

/*
669. Trim a Binary Search Tree
Easy

Given a binary search tree and the lowest and highest boundaries as L and R, trim the tree so that all its elements lies in [L, R] (R &gt;= L). You might need to change the root of the tree, so the result should return the new root of the trimmed binary search tree.


Example 1:
Input: 
    1
   / \
  0   2

  L = 1
  R = 2

Output: 
    1
      \
       2



Example 2:
Input: 
    3
   / \
  0   4
   \
    2
   /
  1

  L = 1
  R = 3

Output: 
      3
     / 
   2   
  /
 1
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution669
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public TreeNode TrimBST(TreeNode root, int L, int R) { }
    }
}
