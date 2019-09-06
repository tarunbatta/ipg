// Url:https://leetcode.com/problems/all-possible-full-binary-trees

/*
894. All Possible Full Binary Trees
Medium

A full binary tree&#xA0;is a binary tree where each node has exactly 0 or 2&#xA0;children.

Return a list of all possible full binary trees with N nodes.&#xA0; Each element of the answer is the root node of one possible tree.

Each node of each&#xA0;tree in the answer must have node.val = 0.

You may return the final list of trees in any order.

&#xA0;

Example 1:

Input: 7
Output: [[0,0,0,null,null,0,0,null,null,0,0],[0,0,0,null,null,0,0,0,0],[0,0,0,0,0,0,0],[0,0,0,0,0,null,null,null,null,0,0],[0,0,0,0,0,null,null,0,0]]
Explanation:



&#xA0;

Note:


	1 &lt;= N &lt;= 20
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.Solution894
{
    public class Solution
    {
        public void Init() { }

        public IList<TreeNode> AllPossibleFBT(int N)
        {
            return null;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }
}
