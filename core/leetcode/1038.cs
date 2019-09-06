// Url:https://leetcode.com/problems/binary-search-tree-to-greater-sum-tree

/*
1038. Binary Search Tree to Greater Sum Tree
Medium

Given the root of a binary search tree with distinct values, modify it so that every node&#xA0;has a new value equal to the sum of the values of the original tree that are greater than or equal to node.val.

As a reminder, a&#xA0;binary search tree is a tree that satisfies these constraints:


	The left subtree of a node contains only nodes with keys&#xA0;less than&#xA0;the node&apos;s key.
	The right subtree of a node contains only nodes with keys&#xA0;greater than&#xA0;the node&apos;s key.
	Both the left and right subtrees must also be binary search trees.


&#xA0;

Example 1:



Input: [4,1,6,0,2,5,7,null,null,null,3,null,null,null,8]
Output: [30,36,21,36,35,26,15,null,null,null,33,null,null,null,8]



&#xA0;


Note:


	The number of nodes in the tree is between 1 and 100.
	Each node will have value between 0 and 100.
	The given tree is a binary search tree.




&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1038
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public TreeNode BstToGst(TreeNode root) { }
    }
}
