using System;

namespace TechByTarun.InterviewPreperationGuide.App.Leetcode
{
    /// <summary>
    /// Binary Tree Maximum Path Sum
    /// https://leetcode.com/problems/binary-tree-maximum-path-sum/
    ///
    /// Given a binary tree, find the maximum path sum.
    ///
    /// For this problem, a path is defined as any sequence of nodes from some starting node to any node in the tree along the parent-child connections.
    /// The path must contain at least one node and does not need to go through the root.
    ///
    /// For example:
    /// Given the below binary tree,
    ///
    ///      1
    ///     / \
    ///    2   3
    ///
    /// Return 6.
    /// </summary>
    public class Question124
    {
        public static void Init(string[] args)
        {
            TreeNode node = new TreeNode(10);
            node.left = new TreeNode(2);
            node.right = new TreeNode(10);
            node.left.left = new TreeNode(20);
            node.left.right = new TreeNode(1);
            node.right.right = new TreeNode(-25);
            node.right.right.left = new TreeNode(3);
            node.right.right.right = new TreeNode(4);

            Console.WriteLine(MaxPathSum(node));
        }

        private static int result = int.MinValue;

        public static int MaxPathSum(TreeNode root)
        {
            if (root != null)
            {
                MaxPathSumUtility(root);
            }

            return result;
        }

        public static int MaxPathSumUtility(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int left = MaxPathSumUtility(root.left);
            int right = MaxPathSumUtility(root.right);

            var pathSum = Math.Max(Math.Max(left, right) + root.val, root.val);
            result = Math.Max(result, Math.Max(pathSum, left + right + root.val));

            return pathSum;
        }
    }
}