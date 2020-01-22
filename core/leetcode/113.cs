// Url:https://leetcode.com/problems/path-sum-ii

/*
113. Path Sum II
Medium

Given a binary tree and a sum, find all root-to-leaf paths where each path's sum equals the given sum.

Note: A leaf is a node with no children.

Example:

Given the below binary tree and sum = 22,

      5
     / \
    4   8
   /   / \
  11  13  4
 /  \    / \
7    2  5   1


Return:

[
   [5,4,11,2],
   [5,8,4,5]
]
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.problem113 {
    public class Solution {
        public void Init () {
            Console.WriteLine ();
        }

        // Time: O ()
        // Space: O ()
        public IList<IList<int>> PathSum (TreeNode root, int sum) {
            return null;
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