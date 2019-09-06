// Url:https://leetcode.com/problems/binary-tree-preorder-traversal

/*
144. Binary Tree Preorder Traversal
Medium

Given a binary tree, return the preorder traversal of its nodes&apos; values.

Example:

Input:&#xA0;[1,null,2,3]
   1
    \
     2
    /
   3

Output:&#xA0;[1,2,3]


Follow up: Recursive solution is trivial, could you do it iteratively?
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.Solution144
{
    public class Solution
    {
        public void Init()
        {

        }

        public IList<int> PreorderTraversal(TreeNode root)
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
