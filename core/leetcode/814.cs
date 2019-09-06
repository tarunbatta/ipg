// Url:https://leetcode.com/problems/binary-tree-pruning

/*
814. Binary Tree Pruning
Medium

We are given the head node root&#xA0;of a binary tree, where additionally every node&apos;s value is either a 0 or a 1.

Return the same tree where every subtree (of the given tree) not containing a 1 has been removed.

(Recall that the subtree of a node X is X, plus every node that is a descendant of X.)

Example 1:
Input: [1,null,0,0,1]
Output: [1,null,0,null,1]
 
Explanation: 
Only the red nodes satisfy the property &quot;every subtree not containing a 1&quot;.
The diagram on the right represents the answer.




Example 2:
Input: [1,0,1,0,0,0,1]
Output: [1,null,1,null,1]





Example 3:
Input: [1,1,0,1,1,0,1,0]
Output: [1,1,0,1,1,null,1]





Note: 


	The binary tree&#xA0;will&#xA0;have&#xA0;at&#xA0;most 100 nodes.
	The value of each node will only be 0 or 1.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution814
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public TreeNode PruneTree(TreeNode root) { }
    }
}
