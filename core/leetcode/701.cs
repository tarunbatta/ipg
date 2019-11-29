// Url:https://leetcode.com/problems/insert-into-a-binary-search-tree

/*
701. Insert into a Binary Search Tree
Medium

Given the root node of a binary search tree (BST) and a value to be inserted into the tree, insert the value into the BST. Return the root node of the BST after the insertion. It is guaranteed that the new value does not exist in the original BST.

Note that there may exist multiple valid ways for the insertion, as long as the tree remains a BST after insertion. You can return any of them.

For example, 

Given the tree:
        4
       / \
      2   7
     / \
    1   3
And the value to insert: 5


You can return this binary search tree:

         4
       /   \
      2     7
     / \   /
    1   3 5


This tree is also valid:

         5
       /   \
      2     7
     / \   
    1   3
         \
          4
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem701
{
    public class Solution
    {
        public void Init()
        {
            Console.WriteLine();
        }

        // Time: O ()
        // Space: O ()
        public TreeNode InsertIntoBST(TreeNode root, int val)
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