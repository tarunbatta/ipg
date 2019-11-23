// Url:https://leetcode.com/problems/binary-tree-paths

/*
257. Binary Tree Paths
Easy

Given a binary tree, return all root-to-leaf paths.

Note: A leaf is a node with no children.

Example:

Input:

   1
 /   \
2     3
 \
  5

Output: ["1->2->5", "1->3"]

Explanation: All root-to-leaf paths are: 1->2->5, 1->3
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.problem257
{
    public class Solution
    {
        public void Init()
        {
            Console.WriteLine();
        }

        public IList<string> BinaryTreePaths(TreeNode root)
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