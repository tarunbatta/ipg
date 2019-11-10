// Url:https://leetcode.com/problems/binary-tree-maximum-path-sum

/*
124. Binary Tree Maximum Path Sum
Hard

Given a non-empty binary tree, find the maximum path sum.

For this problem, a path is defined as any sequence of nodes from some starting node to any node in the tree along the parent-child connections. The path must contain at least one node and does not need to go through the root.

Example 1:

Input: [1,2,3]

       1
      / \
     2   3

Output: 6


Example 2:

Input: [-10,9,20,null,null,15,7]

   -10
   / \
  9  20
    /  \
   15   7

Output: 42
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem124 {
    public class Solution {
        public void Init () {
            TreeNode node = new TreeNode (10);
            node.left = new TreeNode (2);
            node.right = new TreeNode (10);
            node.left.left = new TreeNode (20);
            node.left.right = new TreeNode (1);
            node.right.right = new TreeNode (-25);
            node.right.right.left = new TreeNode (3);
            node.right.right.right = new TreeNode (4);

            Console.WriteLine (MaxPathSum (node));
        }

        private int result = int.MinValue;

        public int MaxPathSum (TreeNode root) {
            if (root != null) {
                MaxPathSumUtility (root);
            }

            return result;
        }

        private int MaxPathSumUtility (TreeNode root) {
            if (root == null) {
                return 0;
            }

            int left = Math.Max (MaxPathSumUtility (root.left), 0);
            int right = Math.Max (MaxPathSumUtility (root.right), 0);

            result = Math.Max (result, root.val + left + right);

            return root.val + Math.Max (left, right);
        }
    }

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode (int x) {
            val = x;
        }
    }
}