// Url:https://leetcode.com/problems/print-binary-tree

/*
655. Print Binary Tree
Medium

Print a binary tree in an m*n 2D string array following these rules: 


The row number m should be equal to the height of the given binary tree.
The column number n should always be an odd number.
The root node&apos;s value (in string format) should be put in the exactly middle of the first row it can be put. The column and the row where the root node belongs will separate the rest space into two parts (left-bottom part and right-bottom part). You should print the left subtree in the left-bottom part and print the right subtree in the right-bottom part. The left-bottom part and the right-bottom part should have the same size. Even if one subtree is none while the other is not, you don&apos;t need to print anything for the none subtree but still need to leave the space as large as that for the other subtree. However, if two subtrees are none, then you don&apos;t need to leave space for both of them. 
Each unused space should contain an empty string &quot;&quot;.
Print the subtrees following the same rules.


Example 1:
Input:
     1
    /
   2
Output:
[[&quot;&quot;, &quot;1&quot;, &quot;&quot;],
 [&quot;2&quot;, &quot;&quot;, &quot;&quot;]]




Example 2:
Input:
     1
    / \
   2   3
    \
     4
Output:
[[&quot;&quot;, &quot;&quot;, &quot;&quot;, &quot;1&quot;, &quot;&quot;, &quot;&quot;, &quot;&quot;],
 [&quot;&quot;, &quot;2&quot;, &quot;&quot;, &quot;&quot;, &quot;&quot;, &quot;3&quot;, &quot;&quot;],
 [&quot;&quot;, &quot;&quot;, &quot;4&quot;, &quot;&quot;, &quot;&quot;, &quot;&quot;, &quot;&quot;]]



Example 3:
Input:
      1
     / \
    2   5
   / 
  3 
 / 
4 
Output:

[[&quot;&quot;,  &quot;&quot;,  &quot;&quot;, &quot;&quot;,  &quot;&quot;, &quot;&quot;, &quot;&quot;, &quot;1&quot;, &quot;&quot;,  &quot;&quot;,  &quot;&quot;,  &quot;&quot;,  &quot;&quot;, &quot;&quot;, &quot;&quot;]
 [&quot;&quot;,  &quot;&quot;,  &quot;&quot;, &quot;2&quot;, &quot;&quot;, &quot;&quot;, &quot;&quot;, &quot;&quot;,  &quot;&quot;,  &quot;&quot;,  &quot;&quot;,  &quot;5&quot;, &quot;&quot;, &quot;&quot;, &quot;&quot;]
 [&quot;&quot;,  &quot;3&quot;, &quot;&quot;, &quot;&quot;,  &quot;&quot;, &quot;&quot;, &quot;&quot;, &quot;&quot;,  &quot;&quot;,  &quot;&quot;,  &quot;&quot;,  &quot;&quot;,  &quot;&quot;, &quot;&quot;, &quot;&quot;]
 [&quot;4&quot;, &quot;&quot;,  &quot;&quot;, &quot;&quot;,  &quot;&quot;, &quot;&quot;, &quot;&quot;, &quot;&quot;,  &quot;&quot;,  &quot;&quot;,  &quot;&quot;,  &quot;&quot;,  &quot;&quot;, &quot;&quot;, &quot;&quot;]]



Note:
The height of binary tree is in the range of [1, 10].
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution655
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class Solution
    {
        public void Init() { }

        public IList<IList<string>> PrintTree(TreeNode root) { }
    }
}
