// Url:https://leetcode.com/problems/cousins-in-binary-tree

/*
993. Cousins in Binary Tree
Easy

In a binary tree, the root node is at depth 0, and children of each depth k node are at depth k+1.

Two nodes of a binary tree are cousins if they have the same depth, but have different parents.

We are given the root of a binary tree with unique values, and the values x and y of two different nodes in the tree.

Return true if and only if the nodes corresponding to the values x and y are cousins.

 

Example 1:


Input: root = [1,2,3,4], x = 4, y = 3
Output: false



Example 2:


Input: root = [1,2,3,null,4,null,5], x = 5, y = 4
Output: true



Example 3:



Input: root = [1,2,3,null,4], x = 2, y = 3
Output: false

 



Note:


	The number of nodes in the tree will be between 2 and 100.
	Each node has a unique integer value from 1 to 100.




 
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem993 {
    public class Solution {
        public void Init () {
            Console.WriteLine ();
        }

        // Time: O ()
        // Space: O ()
        public bool IsCousins (TreeNode root, int x, int y) {
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