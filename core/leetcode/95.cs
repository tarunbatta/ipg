// Url:https://leetcode.com/problems/unique-binary-search-trees-ii

/*
95. Unique Binary Search Trees II
Medium

Given an integer n, generate all structurally unique BST&apos;s (binary search trees) that store values 1 ...&#xA0;n.

Example:

Input: 3
Output:
[
&#xA0; [1,null,3,2],
&#xA0; [3,2,null,1],
&#xA0; [3,1,null,null,2],
&#xA0; [2,1,3],
&#xA0; [1,null,2,null,3]
]
Explanation:
The above output corresponds to the 5 unique BST&apos;s shown below:

   1         3     3      2      1
    \       /     /      / \      \
     3     2     1      1   3      2
    /     /       \                 \
   2     1         2                 3
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution95
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public IList<TreeNode> GenerateTrees(int n) { }
    }
}
