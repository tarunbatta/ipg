// Url:https://leetcode.com/problems/binary-search-tree-iterator

/*
173. Binary Search Tree Iterator
Medium

Implement an iterator over a binary search tree (BST). Your iterator will be initialized with the root node of a BST.

Calling next() will return the next smallest number in the BST.

&#xA0;




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


&#xA0;

Note:


	next() and hasNext() should run in average O(1) time and uses O(h) memory, where h is the height of the tree.
	You may assume that&#xA0;next()&#xA0;call&#xA0;will always be valid, that is, there will be at least a next smallest number in the BST when next() is called.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution173
{
    /** * Definition for a binary tree node. * public class TreeNode { *     public int val; *     public TreeNode left; *     public TreeNode right; *     public TreeNode(int x) { val = x; } * } */
    public class BSTIterator {​    public BSTIterator(TreeNode root) { }        /** @return the next smallest number */    public int Next() { }        /** @return whether we have a next smallest number */    public bool HasNext() { } }​/** * Your BSTIterator object will be instantiated and called as such: * BSTIterator obj = new BSTIterator(root); * int param_1 = obj.Next(); * bool param_2 = obj.HasNext(); *
}
