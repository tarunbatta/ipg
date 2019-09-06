// Url:https://leetcode.com/problems/minimum-cost-tree-from-leaf-values

/*
1130. Minimum Cost Tree From Leaf Values
Medium

Given an array arr of positive integers, consider all binary trees such that:


	Each node has either 0 or 2 children;
	The values of arr correspond to the values of each&#xA0;leaf in an in-order traversal of the tree.&#xA0; (Recall that a node is a leaf if and only if it has 0 children.)
	The value&#xA0;of each non-leaf node is equal to the product of the largest leaf value in its left and right subtree respectively.


Among all possible binary trees considered,&#xA0;return the smallest possible sum of the values of each non-leaf node.&#xA0; It is guaranteed this sum fits into a 32-bit integer.

&#xA0;
Example 1:

Input: arr = [6,2,4]
Output: 32
Explanation:
There are two possible trees.  The first has non-leaf node sum 36, and the second has non-leaf node sum 32.

    24            24
   /  \          /  \
  12   4        6    8
 /  \               / \
6    2             2   4


&#xA0;
Constraints:


	2 &lt;= arr.length &lt;= 40
	1 &lt;= arr[i] &lt;= 15
	It is guaranteed that the answer fits into a 32-bit signed integer (ie.&#xA0;it is less than 2^31).
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1130
{
    public class Solution
    {
        public void Init() { }

        public int MctFromLeafValues(int[] arr) { }
    }
}
