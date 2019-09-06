// Url:https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal

/*
103. Binary Tree Zigzag Level Order Traversal
Medium

Given a binary tree, return the zigzag level order traversal of its nodes&apos; values. (ie, from left to right, then right to left for the next level and alternate between).


For example:
Given binary tree [3,9,20,null,null,15,7],
    3
   / \
  9  20
    /  \
   15   7



return its zigzag level order traversal as:
[
  [3],
  [20,9],
  [15,7]
]
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.Solution103
{
    public class Solution
    {
        public void Init() { }

        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
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
