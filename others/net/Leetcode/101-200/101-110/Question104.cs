using System;

namespace InterviewPreperationGuide.App.Leetcode {
    /// <summary>
    /// Maximum Depth of Binary Tree
    /// https://leetcode.com/problems/maximum-depth-of-binary-tree/
    ///
    /// Given a binary tree, find its maximum depth.
    /// The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
    /// </summary>
    public class Question104 {
        public static void Init (string[] args) {
            TreeNode node = new TreeNode (2);
            node.left = new TreeNode (3);
            node.right = new TreeNode (4);
            node.left.left = new TreeNode (4);
            node.left.right = new TreeNode (5);

            Console.WriteLine (MaxDepth (node));
        }

        public static int MaxDepth (TreeNode root) {
            if (root == null) {
                return 0;
            }

            int left = MaxDepth (root.left);
            int right = MaxDepth (root.right);

            return (left > right) ? (left + 1) : (right + 1);
        }
    }
}