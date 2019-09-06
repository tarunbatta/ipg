// Url:https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers

/*
1022. Sum of Root To Leaf Binary Numbers
Easy

Given a binary tree, each node has value 0&#xA0;or 1.&#xA0; Each root-to-leaf path represents a binary number starting with the most significant bit.&#xA0; For example, if the path is 0 -&gt; 1 -&gt; 1 -&gt; 0 -&gt; 1, then this could represent 01101 in binary, which is 13.

For all leaves in the tree, consider the numbers represented by the path&#xA0;from the root to that leaf.

Return the sum of these numbers.

&#xA0;

Example 1:



Input: [1,0,1,0,1,0,1]
Output: 22
Explanation: (100) + (101) + (110) + (111) = 4 + 5 + 6 + 7 = 22


&#xA0;

Note:


	The number of nodes in the tree is between 1 and 1000.
	node.val is 0 or 1.
	The answer will not exceed 2^31 - 1.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1022
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public int SumRootToLeaf(TreeNode root) { }
    }
}
