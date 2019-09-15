// Url:https://leetcode.com/problems/binary-search-tree-iterator

/*
173. Binary Search Tree Iterator
Medium

Implement an iterator over a binary search tree (BST). Your iterator will be initialized with the root node of a BST.

Calling next() will return the next smallest number in the BST.

 




Example:



BSTIterator iterator = new BSTIterator(root);
iterator.next();    // return 3
iterator.next();    // return 7
iterator.hasNext(); // return true
iterator.next();    // return 9
iterator.hasNext(); // return true
iterator.next();    // return 15
iterator.hasNext(); // return true
iterator.next();    // return 20
iterator.hasNext(); // return false


 

Note:


	next() and hasNext() should run in average O(1) time and uses O(h) memory, where h is the height of the tree.
	You may assume that next() call will always be valid, that is, there will be at least a next smallest number in the BST when next() is called.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem173 {
    public class Solution {
        public void Init () {
            BSTIterator obj = new BSTIterator (null);
            int param_1 = obj.Next ();
            bool param_2 = obj.HasNext ();
        }
    }
    public class BSTIterator {
        public BSTIterator (TreeNode root) {

        }

        // @return the next smallest number
        public int Next () {
            return 0;
        }

        // @return whether we have a next smallest number
        public bool HasNext () {
            return false;
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