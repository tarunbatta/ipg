// Url:https://leetcode.com/problems/delete-nodes-and-return-forest

/*
1110. Delete Nodes And Return Forest
Medium

Given the root&#xA0;of a binary tree, each node in the tree has a distinct value.

After deleting&#xA0;all nodes with a value in to_delete, we are left with a forest (a&#xA0;disjoint union of trees).

Return the roots of the trees in the remaining forest.&#xA0; You may return the result in any order.

&#xA0;
Example 1:



Input: root = [1,2,3,4,5,6,7], to_delete = [3,5]
Output: [[1,2,null,4],[6],[7]]


&#xA0;
Constraints:


	The number of nodes in the given tree is at most 1000.
	Each node has a distinct value between 1 and 1000.
	to_delete.length &lt;= 1000
	to_delete contains distinct values between 1 and 1000.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1110
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete) { }
    }
}
