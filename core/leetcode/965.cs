// Url:https://leetcode.com/problems/univalued-binary-tree

/*
965. Univalued Binary Tree
Easy

A binary tree is univalued if every node in the tree has the same value.

Return true if and only if the given tree is univalued.

 

Example 1:

Input: [1,1,1,1,1,null,1]
Output: true



Example 2:

Input: [2,2,2,5,2]
Output: false



 

Note:


	The number of nodes in the given tree will be in the range [1, 100].
	Each node's value will be an integer in the range [0, 99].
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution965 {
    public class Solution {
        public void Init () {
            Console.WriteLine ();
        }

        public bool IsUnivalTree (TreeNode root) {
            return false;
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