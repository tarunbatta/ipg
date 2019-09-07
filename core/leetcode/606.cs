// Url:https://leetcode.com/problems/construct-string-from-binary-tree

/*
606. Construct String from Binary Tree
Easy

You need to construct a string consists of parenthesis and integers from a binary tree with the preorder traversing way.

The null node needs to be represented by empty parenthesis pair &quot;()&quot;. And you need to omit all the empty parenthesis pairs that don&apos;t affect the one-to-one mapping relationship between the string and the original binary tree.

Example 1:
Input: Binary tree: [1,2,3,4]
       1
     /   \
    2     3
   /    
  4     

Output: &quot;1(2(4))(3)&quot;
Explanation: Originallay it needs to be &quot;1(2(4)())(3()())&quot;, but you need to omit all the unnecessary empty parenthesis pairs. And it will be &quot;1(2(4))(3)&quot;.



Example 2:
Input: Binary tree: [1,2,3,null,4]
       1
     /   \
    2     3
     \  
      4 

Output: &quot;1(2()(4))(3)&quot;
Explanation: Almost the same as the first example, except we can&apos;t omit the first parenthesis pair to break the one-to-one mapping relationship between the input and the output.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution606 {
    public class Solution {
        public void Init () {

        }

        public string Tree2str (TreeNode t) {
            return null;
        }
    }

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode (int x) {
            val = x;
        }
    }
}