// Url:https://leetcode.com/problems/insufficient-nodes-in-root-to-leaf-paths

/*
1080. Insufficient Nodes in Root to Leaf Paths
Medium

Given the root&#xA0;of a binary tree, consider all root to leaf paths: paths from the root&#xA0;to any leaf.&#xA0; (A leaf is a node with no children.)

A node is insufficient if&#xA0;every such root to leaf path intersecting this node has sum strictly less than&#xA0;limit.

Delete all insufficient nodes simultaneously, and return the root of the resulting&#xA0;binary tree.

&#xA0;

Example 1:


Input: root = [1,2,3,4,-99,-99,7,8,9,-99,-99,12,13,-99,14], limit = 1

Output: [1,2,3,4,null,null,7,8,9,null,14]



Example 2:


Input: root = [5,4,8,11,null,17,4,7,1,null,null,5,3], limit = 22

Output: [5,4,8,11,null,17,4,7,null,null,null,5]

&#xA0;

Example 3:


Input: root = [1,2,-3,-5,null,4,null], limit = -1

Output: [1,null,-3,4]


&#xA0;

Note:


	The given tree will have between 1 and 5000 nodes.
	-10^5&#xA0;&lt;= node.val &lt;= 10^5
	-10^9 &lt;= limit&#xA0;&lt;= 10^9



&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1080
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public TreeNode SufficientSubset(TreeNode root, int limit) { }
    }
}
