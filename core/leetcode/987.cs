// Url:https://leetcode.com/problems/vertical-order-traversal-of-a-binary-tree

/*
987. Vertical Order Traversal of a Binary Tree
Medium

Given a binary tree, return the vertical order traversal of its nodes&#xA0;values.

For each node at position (X, Y), its left and right children respectively&#xA0;will be at positions (X-1, Y-1) and (X+1, Y-1).

Running a vertical line from X = -infinity to X = +infinity, whenever the vertical line touches some nodes, we report the values of the nodes in order from top to bottom (decreasing Y coordinates).

If two nodes have the same position, then the value of the node that is reported first is the value that is smaller.

Return an list&#xA0;of non-empty reports in order of X coordinate.&#xA0; Every report will have a list of values of nodes.

&#xA0;

Example 1:




Input: [3,9,20,null,null,15,7]
Output: [[9],[3,15],[20],[7]]
Explanation: 
Without loss of generality, we can assume the root node is at position (0, 0):
Then, the node with value 9 occurs at position (-1, -1);
The nodes with values 3 and 15 occur at positions (0, 0) and (0, -2);
The node with value 20 occurs at position (1, -1);
The node with value 7 occurs at position (2, -2).



Example 2:



Input: [1,2,3,4,5,6,7]
Output: [[4],[2],[1,5,6],[3],[7]]
Explanation: 
The node with value 5 and the node with value 6 have the same position according to the given scheme.
However, in the report &quot;[1,5,6]&quot;, the node value of 5 comes first since 5 is smaller than 6.


&#xA0;


Note:


	The tree will have between 1&#xA0;and 1000 nodes.
	Each node&apos;s value will be between 0 and 1000.




&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution987
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public IList<IList<int>> VerticalTraversal(TreeNode root) { }
    }
}
