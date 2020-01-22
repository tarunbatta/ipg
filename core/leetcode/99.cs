// Url:https://leetcode.com/problems/recover-binary-search-tree

/*
99. Recover Binary Search Tree
Hard

Two elements of a binary search tree (BST) are swapped by mistake.

Recover the tree without changing its structure.

Example 1:

Input: [1,3,null,null,2]

   1
  /
 3
  \
   2

Output: [3,1,null,null,2]

   3
  /
 1
  \
   2


Example 2:

Input: [3,1,4,null,null,2]

  3
 / \
1   4
   /
  2

Output: [2,1,4,null,null,3]

  2
 / \
1   4
   /
  3


Follow up:


	A solution using O(n) space is pretty straight forward.
	Could you devise a constant space solution?
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem99 {
    public class Solution {
        private static TreeNode first;
        private static TreeNode second;
        private static TreeNode previous;

        public void Init () {
            TreeNode node = new TreeNode (40);
            node.left = new TreeNode (20);
            node.right = new TreeNode (60);
            node.left.left = new TreeNode (70);
            node.left.right = new TreeNode (30);
            node.right.left = new TreeNode (50);
            node.right.right = new TreeNode (10);

            RecoverTree (node);
        }

        public void RecoverTree (TreeNode root) {
            if (root == null) {
                return;
            }

            RecoverBstInorder (root);

            if (first != null && second != null) {
                int val = second.val;
                second.val = first.val;
                first.val = val;
            }
        }

        private void RecoverBstInorder (TreeNode node) {
            if (node == null) {
                return;
            }

            RecoverBstInorder (node.left);

            if (previous == null) {
                previous = node;
            } else {
                if (node.val < previous.val) {
                    if (first == null) {
                        first = previous;
                    }

                    second = node;
                }

                previous = node;
            }

            RecoverBstInorder (node.right);
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