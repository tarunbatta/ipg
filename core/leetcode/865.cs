// Url:https://leetcode.com/problems/smallest-subtree-with-all-the-deepest-nodes

/*
865. Smallest Subtree with all the Deepest Nodes
Medium

Given a binary tree rooted at root, the depth of each node is the shortest distance to the root.

A node is deepest if it has the largest depth possible among&#xA0;any node in the entire tree.

The subtree of a node is that node, plus the set of all descendants of that node.

Return the node with the largest depth such that it contains all the deepest nodes in its subtree.

&#xA0;

Example 1:

Input: [3,5,1,6,2,0,8,null,null,7,4]
Output: [2,7,4]
Explanation:



We return the node with value 2, colored in yellow in the diagram.
The nodes colored in blue are the deepest nodes of the tree.
The input &quot;[3, 5, 1, 6, 2, 0, 8, null, null, 7, 4]&quot; is a serialization of the given tree.
The output &quot;[2, 7, 4]&quot; is a serialization of the subtree rooted at the node with value 2.
Both the input and output have TreeNode type.


&#xA0;

Note:


	The number of nodes in the tree will be between 1 and 500.
	The values of each node are unique.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution865
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public TreeNode SubtreeWithAllDeepest(TreeNode root) { }
    }
}
