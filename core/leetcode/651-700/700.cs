// Url:https://leetcode.com/problems/search-in-a-binary-search-tree

/*
700. Search in a Binary Search Tree
Easy

Given the root node of a binary search tree (BST) and a value. You need to find the node in the BST that the node&apos;s value equals the given value. Return the subtree rooted with that node. If such node doesn&apos;t exist, you should return NULL.

For example,&#xA0;

Given the tree:
        4
       / \
      2   7
     / \
    1   3

And the value to search: 2


You should return this subtree:

      2     
     / \   
    1   3


In the example above, if we want to search the value 5, since there is no node with value 5, we should return NULL.

Note that an empty tree is represented by NULL, therefore you would see the expected output (serialized tree format) as&#xA0;[], not null.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution700
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public TreeNode SearchBST(TreeNode root, int val) { }
    }
}
