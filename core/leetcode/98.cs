using System.ComponentModel.Design.Serialization;
// Url:https://leetcode.com/problems/validate-binary-search-tree

/*
98. Validate Binary Search Tree
Medium

Given a binary tree, determine if it is a valid binary search tree (BST).

Assume a BST is defined as follows:
	The left subtree of a node contains only nodes with keys less than the node's key.
	The right subtree of a node contains only nodes with keys greater than the node's key.
	Both the left and right subtrees must also be binary search trees.


 

Example 1:

    2
   / \
  1   3

Input: [2,1,3]
Output: true


Example 2:

    5
   / \
  1   4
     / \
    3   6

Input: [5,1,4,null,null,3,6]
Output: false
Explanation: The root node's value is 5 but its right child's value is 4.
*/

using System;
using System.Collections;

namespace InterviewPreperationGuide.Core.LeetCode.problem98
{
    public class Solution
    {
        public void Init()
        {
            TreeNode node = new TreeNode(2);
            node.left = new TreeNode(1);
            node.right = new TreeNode(3);

            TreeNode node1 = new TreeNode(5);
            node1.left = new TreeNode(1);
            node1.right = new TreeNode(4);
            node1.right.left = new TreeNode(3);
            node1.right.right = new TreeNode(6);

            Console.WriteLine(IsValidBST_a(null));
            Console.WriteLine(IsValidBST_a(node));
            Console.WriteLine(IsValidBST_a(node1));

            Console.WriteLine(IsValidBST_b(null));
            Console.WriteLine(IsValidBST_b(node));
            Console.WriteLine(IsValidBST_b(node1));
        }

        // Time: O (n)
        // Space: O (n)
        public bool IsValidBST_a(TreeNode root)
        {
            return IsValidBSTHelper(root, long.MinValue, long.MaxValue);
        }

        private bool IsValidBSTHelper(TreeNode node, long min, long max)
        {
            if (node == null)
            {
                return true;
            }

            if (node.val <= min || node.val >= max)
            {
                return false;
            }

            return IsValidBSTHelper(node.left, min, node.val) && IsValidBSTHelper(node.right, node.val, max);
        }

        // Time: O (n)
        // Space: O (n)
        public bool IsValidBST_b(TreeNode root)
        {
            Stack stack = new Stack();
            long inorder = long.MinValue;

            while (stack.Count != 0 || root != null)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                root = (TreeNode)stack.Pop();

                if (root.val <= inorder)
                {
                    return false;
                }

                inorder = root.val;
                root = root.right;
            }

            return true;
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