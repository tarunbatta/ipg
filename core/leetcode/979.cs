// Url:https://leetcode.com/problems/distribute-coins-in-binary-tree

/*
979. Distribute Coins in Binary Tree
Medium

Given the root of a binary tree with N nodes, each node&#xA0;in the tree has node.val coins, and there are N coins total.

In one move, we may choose two adjacent nodes and move one coin from one node to another.&#xA0; (The move may be from parent to child, or from child to parent.)

Return the number of moves required to make every node have exactly one coin.

&#xA0;


Example 1:



Input: [3,0,0]
Output: 2
Explanation: From the root of the tree, we move one coin to its left child, and one coin to its right child.



Example 2:



Input: [0,3,0]
Output: 3
Explanation: From the left child of the root, we move two coins to the root [taking two moves].  Then, we move one coin from the root of the tree to the right child.



Example 3:



Input: [1,0,2]
Output: 2



Example 4:



Input: [1,0,0,null,3]
Output: 4


&#xA0;

Note:


	1&lt;= N &lt;= 100
	0 &lt;= node.val &lt;= N
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution979
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public int DistributeCoins(TreeNode root) { }
    }
}
