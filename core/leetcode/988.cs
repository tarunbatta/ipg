// Url:https://leetcode.com/problems/smallest-string-starting-from-leaf

/*
988. Smallest String Starting From Leaf
Medium

Given the root of a binary tree, each node has a value from 0 to 25 representing the letters &apos;a&apos; to &apos;z&apos;: a value of 0 represents &apos;a&apos;, a value of 1 represents &apos;b&apos;, and so on.

Find the lexicographically smallest string that starts at a leaf of this tree and ends at the root.

(As a reminder, any shorter prefix of a string is lexicographically smaller: for example, &quot;ab&quot; is lexicographically smaller than &quot;aba&quot;.&#xA0; A leaf of a node is a node that has no children.)



&#xA0;







Example 1:



Input: [0,1,2,3,4,3,4]
Output: &quot;dba&quot;



Example 2:



Input: [25,1,3,1,3,0,2]
Output: &quot;adz&quot;



Example 3:



Input: [2,2,1,null,1,0,null,0]
Output: &quot;abc&quot;


&#xA0;

Note:


	The number of nodes in the given tree will be between 1 and 8500.
	Each node in the tree will have a value between 0 and 25.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution988
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public string SmallestFromLeaf(TreeNode root) { }
    }
}
