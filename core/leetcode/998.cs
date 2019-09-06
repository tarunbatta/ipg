// Url:https://leetcode.com/problems/maximum-binary-tree-ii

/*
998. Maximum Binary Tree II
Medium

We are given the root&#xA0;node of a maximum tree: a tree where every node has a value greater than any other value in its subtree.

Just as in the previous problem, the given tree&#xA0;was constructed from an list&#xA0;A&#xA0;(root = Construct(A)) recursively with the following&#xA0;Construct(A) routine:


	If A is empty, return null.
	Otherwise, let A[i] be the largest element of A.&#xA0; Create a root node with value A[i].
	The left child of root will be Construct([A[0], A[1], ..., A[i-1]])
	The right child of root&#xA0;will be Construct([A[i+1], A[i+2], ..., A[A.length - 1]])
	Return root.


Note that we were not given A directly, only a root node root = Construct(A).

Suppose B is a copy of A with the value val appended to it.&#xA0; It is guaranteed that B has unique values.

Return Construct(B).

&#xA0;

Example 1:



Input: root = [4,1,3,null,null,2], val = 5
Output: [5,4,null,1,3,null,null,2]
Explanation: A = [1,4,2,3], B = [1,4,2,3,5]



Example 2:


Input: root = [5,2,4,null,1], val = 3
Output: [5,2,4,null,1,null,3]
Explanation: A = [2,1,5,4], B = [2,1,5,4,3]



Example 3:


Input: root = [5,2,3,null,1], val = 4
Output: [5,2,4,null,1,3]
Explanation: A = [2,1,5,3], B = [2,1,5,3,4]


&#xA0;



Note:


	1 &lt;= B.length &lt;= 100
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution998
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public TreeNode InsertIntoMaxTree(TreeNode root, int val) { }
    }
}
