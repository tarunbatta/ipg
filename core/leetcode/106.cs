// Url:https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal

/*
106. Construct Binary Tree from Inorder and Postorder Traversal
Medium

Given inorder and postorder traversal of a tree, construct the binary tree.

Note:
You may assume that duplicates do not exist in the tree.

For example, given

inorder = [9,3,15,20,7]
postorder = [9,15,7,20,3]

Return the following binary tree:

    3
   / \
  9  20
    /  \
   15   7
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem106
{
    public class Solution
    {
        public void Init()
        {
            Console.WriteLine();
        }

        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            return null;
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