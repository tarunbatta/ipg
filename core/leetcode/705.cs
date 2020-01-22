// Url:https://leetcode.com/problems/design-hashset

/*
705. Design HashSet
Easy

Design a HashSet without using any built-in hash table libraries.

To be specific, your design should include these functions:


	add(value): Insert a value into the HashSet. 
	contains(value) : Return whether the value exists in the HashSet or not.
	remove(value): Remove a value in the HashSet. If the value does not exist in the HashSet, do nothing.



Example:

MyHashSet hashSet = new MyHashSet();
hashSet.add(1);         
hashSet.add(2);         
hashSet.contains(1);    // returns true
hashSet.contains(3);    // returns false (not found)
hashSet.add(2);          
hashSet.contains(2);    // returns true
hashSet.remove(2);          
hashSet.contains(2);    // returns false (already removed)



Note:


	All values will be in the range of [0, 1000000].
	The number of operations will be in the range of [1, 10000].
	Please do not use the built-in HashSet library.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem705 {
    public class Solution {
        public void Init () {
            MyHashSet obj = new MyHashSet ();
            obj.Add (0);
            obj.Remove (0);
            bool param_3 = obj.Contains (0);
        }
    }

    public class MyHashSet {
        public MyHashSet () {

        }

        public void Add (int key) {

        }

        public void Remove (int key) {

        }

        // Returns true if this set contains the specified element
        public bool Contains (int key) {
            return false;
        }
    }
}