// Url:https://leetcode.com/problems/diameter-of-binary-tree

/*
543. Diameter of Binary Tree
Easy

Given a binary tree, you need to compute the length of the diameter of the tree. The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.



Example:
Given a binary tree 
          1
         / \
        2   3
       / \     
      4   5    



Return 3, which is the length of the path [4,2,1,3] or [5,2,1,3].


Note:
The length of path between two nodes is represented by the number of edges between them.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution543
{
    public class Solution
    {
        public void Init() { }

        public int DiameterOfBinaryTree(TreeNode root)
        {
            return 0;
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
