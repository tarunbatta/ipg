// Url:https://leetcode.com/problems/find-largest-value-in-each-tree-row

/*
515. Find Largest Value in Each Tree Row
Medium

You need to find the largest value in each row of a binary tree.

Example:
Input: 

          1
         / \
        3   2
       / \   \  
      5   3   9 

Output: [1, 3, 9]
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.problem515 {
    public class Solution {
        public void Init () {
            Console.WriteLine ();
        }

        public IList<int> LargestValues (TreeNode root) {
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