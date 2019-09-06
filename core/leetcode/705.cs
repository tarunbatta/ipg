// Url:https://leetcode.com/problems/design-hashset

/*
705. Design HashSet
Easy

Design a HashSet&#xA0;without using any built-in hash table libraries.

To be specific, your design should include these functions:


	add(value):&#xA0;Insert a value into the HashSet.&#xA0;
	contains(value) : Return whether the value exists in the HashSet or not.
	remove(value): Remove a value in&#xA0;the HashSet. If the value does not exist in the HashSet, do nothing.



Example:

MyHashSet hashSet = new MyHashSet();
hashSet.add(1); &#xA0; &#xA0; &#xA0; &#xA0; 
hashSet.add(2); &#xA0; &#xA0; &#xA0; &#xA0; 
hashSet.contains(1); &#xA0;&#xA0;&#xA0;// returns true
hashSet.contains(3); &#xA0;&#xA0;&#xA0;// returns false (not found)
hashSet.add(2); &#xA0; &#xA0; &#xA0; &#xA0; &#xA0;
hashSet.contains(2); &#xA0;&#xA0;&#xA0;// returns true
hashSet.remove(2); &#xA0; &#xA0; &#xA0; &#xA0; &#xA0;
hashSet.contains(2); &#xA0;&#xA0;&#xA0;// returns false (already removed)



Note:


	All values will be in the range of [0, 1000000].
	The number of operations will be in the range of&#xA0;[1, 10000].
	Please do not use the built-in HashSet library.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution705
{
    public class MyHashSet {​    /** Initialize your data structure here. */    public MyHashSet() { } public void Add(int key) { } public void Remove(int key) { }        /** Returns true if this set contains the specified element */    public bool Contains(int key) { } }​/** * Your MyHashSet object will be instantiated and called as such: * MyHashSet obj = new MyHashSet(); * obj.Add(key); * obj.Remove(key); * bool param_3 = obj.Contains(key); *
}
