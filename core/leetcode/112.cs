// Url:https://leetcode.com/problems/path-sum

/*
112. Path Sum
Easy

Given a binary tree and a sum, determine if the tree has a root-to-leaf path such that adding up all the values along the path equals the given sum.

Note: A leaf is a node with no children.

Example:

Given the below binary tree and sum = 22,

      5
     / \
    4   8
   /   / \
  11  13  4
 /  \      \
7    2      1


return true, as there exist a root-to-leaf path 5->4->11->2 which sum is 22.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem112
{
    public class Solution
    {
        public void Init()
        {
            Console.WriteLine();
        }

        public bool HasPathSum(TreeNode root, int sum)
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