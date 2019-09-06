// Url:https://leetcode.com/problems/validate-binary-search-tree

/*
98. Validate Binary Search Tree
Medium

Given a binary tree, determine if it is a valid binary search tree (BST).

Assume a BST is defined as follows:


	The left subtree of a node contains only nodes with keys less than the node&apos;s key.
	The right subtree of a node contains only nodes with keys greater than the node&apos;s key.
	Both the left and right subtrees must also be binary search trees.


&#xA0;

Example 1:

    2
   / \
  1   3

Input:&#xA0;[2,1,3]
Output: true


Example 2:

    5
   / \
  1   4
&#xA0;    / \
&#xA0;   3   6

Input: [5,1,4,null,null,3,6]
Output: false
Explanation: The root node&apos;s value is 5 but its right child&apos;s value is 4.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution98
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public bool IsValidBST(TreeNode root) { }
    }
}
