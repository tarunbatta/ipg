// Url:https://leetcode.com/problems/flip-binary-tree-to-match-preorder-traversal

/*
971. Flip Binary Tree To Match Preorder Traversal
Medium

Given a binary tree with N nodes, each node has a different value from&#xA0;{1, ..., N}.

A node in this binary tree can be flipped&#xA0;by swapping the left child and the right child of that node.

Consider the sequence of&#xA0;N values reported by a preorder traversal starting from the root.&#xA0; Call such a sequence of N values the&#xA0;voyage&#xA0;of the tree.

(Recall that a preorder traversal&#xA0;of a node means we report the current node&apos;s value, then preorder-traverse the left child, then preorder-traverse the right child.)

Our goal is to flip the least number of nodes in the tree so that the voyage of the tree matches the voyage we are given.

If we can do so, then return a&#xA0;list&#xA0;of the values of all nodes flipped.&#xA0; You may return the answer in any order.

If we cannot do so, then return the list [-1].

&#xA0;


Example 1:



Input: root = [1,2], voyage = [2,1]
Output: [-1]



Example 2:



Input: root = [1,2,3], voyage = [1,3,2]
Output: [1]



Example 3:



Input: root = [1,2,3], voyage = [1,2,3]
Output: []


&#xA0;

Note:


	1 &lt;= N &lt;= 100
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution971
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public IList<int> FlipMatchVoyage(TreeNode root, int[] voyage) { }
    }
}
