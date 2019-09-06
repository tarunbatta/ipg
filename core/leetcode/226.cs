// Url:https://leetcode.com/problems/invert-binary-tree

/*
226. Invert Binary Tree
Easy

Invert a binary tree.

Example:

Input:

     4
   /   \
  2     7
 / \   / \
1   3 6   9

Output:

     4
   /   \
  7     2
 / \   / \
9   6 3   1

Trivia:
This problem was inspired by this original tweet by Max Howell:

Google: 90% of our engineers use the software you wrote (Homebrew), but you can&#x2019;t invert a binary tree on a whiteboard so f*** off.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution226
{
    public class Solution
    {
        public void Init()
        {

        }

        public TreeNode InvertTree(TreeNode root)
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
