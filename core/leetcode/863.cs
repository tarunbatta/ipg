// Url:https://leetcode.com/problems/all-nodes-distance-k-in-binary-tree

/*
863. All Nodes Distance K in Binary Tree
Medium

We are given a binary tree (with root node&#xA0;root), a target node, and an integer value K.

Return a list of the values of all&#xA0;nodes that have a distance K from the target node.&#xA0; The answer can be returned in any order.

&#xA0;





Example 1:

Input: root = [3,5,1,6,2,0,8,null,null,7,4], target = 5, K = 2

Output: [7,4,1]

Explanation: 
The nodes that are a distance 2 from the target node (with value 5)
have values 7, 4, and 1.



Note that the inputs &quot;root&quot; and &quot;target&quot; are actually TreeNodes.
The descriptions of the inputs above are just serializations of these objects.


&#xA0;

Note:


	The given tree is non-empty.
	Each node in the tree has unique values&#xA0;0 &lt;= node.val &lt;= 500.
	The target&#xA0;node is a node in the tree.
	0 &lt;= K &lt;= 1000.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution863
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public IList<int> DistanceK(TreeNode root, TreeNode target, int K) { }
    }
}
