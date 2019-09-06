// Url:https://leetcode.com/problems/leaf-similar-trees

/*
872. Leaf-Similar Trees
Easy

Consider all the leaves of a binary tree.&#xA0; From&#xA0;left to right order, the values of those&#xA0;leaves form a leaf value sequence.



For example, in the given tree above, the leaf value sequence is (6, 7, 4, 9, 8).

Two binary trees are considered leaf-similar&#xA0;if their leaf value sequence is the same.

Return true if and only if the two given trees with head nodes root1 and root2 are leaf-similar.

&#xA0;

Note:


	Both of the given trees will have between 1 and 100 nodes.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution872
{
    public class Solution
    {
        public void Init() { }

        public bool LeafSimilar(TreeNode root1, TreeNode root2) {
            return false;
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
