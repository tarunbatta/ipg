// Url:https://leetcode.com/problems/recover-binary-search-tree

/*
99. Recover Binary Search Tree
Hard

Two elements of a binary search tree (BST) are swapped by mistake.

Recover the tree without changing its structure.

Example 1:

Input: [1,3,null,null,2]

&#xA0;  1
&#xA0; /
&#xA0;3
&#xA0; \
&#xA0;  2

Output: [3,1,null,null,2]

&#xA0;  3
&#xA0; /
&#xA0;1
&#xA0; \
&#xA0;  2


Example 2:

Input: [3,1,4,null,null,2]

  3
 / \
1   4
&#xA0;  /
&#xA0; 2

Output: [2,1,4,null,null,3]

  2
 / \
1   4
&#xA0;  /
 &#xA0;3


Follow up:


	A solution using O(n) space is pretty straight forward.
	Could you devise a constant space solution?
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution99
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public void RecoverTree(TreeNode root) { }
    }
}
