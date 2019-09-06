// Url:https://leetcode.com/problems/find-duplicate-subtrees

/*
652. Find Duplicate Subtrees
Medium

Given a binary tree, return all duplicate subtrees. For each kind of duplicate subtrees, you only need to return the root node of any one of them.

Two trees are duplicate if they have the same structure with same node values.

Example 1: 

        1
       / \
      2   3
     /   / \
    4   2   4
       /
      4


The following are two duplicate subtrees:

      2
     /
    4


and

    4

Therefore, you need to return above trees&apos; root in the form of a list.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution652
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) { }
    }
}
