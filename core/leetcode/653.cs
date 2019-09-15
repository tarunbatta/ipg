// Url:https://leetcode.com/problems/two-sum-iv-input-is-a-bst

/*
653. Two Sum IV - Input is a BST
Easy

Given a Binary Search Tree and a target number, return true if there exist two elements in the BST such that their sum is equal to the given target.

Example 1:

Input: 
    5
   / \
  3   6
 / \   \
2   4   7

Target = 9

Output: True


 

Example 2:

Input: 
    5
   / \
  3   6
 / \   \
2   4   7

Target = 28

Output: False


 
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem653 {
    public class Solution {
        public void Init () {
            Console.WriteLine ();
        }

        public bool FindTarget (TreeNode root, int k) {
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