namespace TechByTarun.InterviewPreperationGuide.App.Leetcode {
    /// <summary>
    /// Recover Binary Search Tree
    /// https://leetcode.com/problems/recover-binary-search-tree/
    ///
    /// Two elements of a binary search tree (BST) are swapped by mistake.
    /// Recover the tree without changing its structure.
    ///
    /// Note:
    /// A solution using O(n) space is pretty straight forward.Could you devise a constant space solution?
    /// </summary>
    public class Question99 {
        private static TreeNode first;
        private static TreeNode second;
        private static TreeNode previous;

        public static void Init (string[] args) {
            TreeNode node = new TreeNode (40);
            node.left = new TreeNode (20);
            node.right = new TreeNode (60);
            node.left.left = new TreeNode (70);
            node.left.right = new TreeNode (30);
            node.right.left = new TreeNode (50);
            node.right.right = new TreeNode (10);

            RecoverTree (node);
        }

        public static void RecoverTree (TreeNode node) {
            Program.PrintTreeNodeInOrder (node);
            Program.PrintLine ();

            if (node == null) {
                return;
            }

            RecoverBstInorder (node);

            if (first != null && second != null) {
                int val = second.val;
                second.val = first.val;
                first.val = val;
            }

            Program.PrintTreeNodeInOrder (node);
            Program.PrintLine ();
        }

        public static void RecoverBstInorder (TreeNode node) {
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
}