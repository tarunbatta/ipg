// Url:https://leetcode.com/problems/same-tree

/*
100. Same Tree
Easy

Given two binary trees, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical and the nodes have the same value.

Example 1:

Input:     1         1
          / \       / \
         2   3     2   3

        [1,2,3],   [1,2,3]

Output: true


Example 2:

Input:     1         1
          /           \
         2             2

        [1,2],     [1,null,2]

Output: false


Example 3:

Input:     1         1
          / \       / \
         2   1     1   2

        [1,2,1],   [1,1,2]

Output: false
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution100
{
    public class Solution
    {
        public void Init() { 
            
        }

        public bool IsSameTree(TreeNode p, TreeNode q)
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
