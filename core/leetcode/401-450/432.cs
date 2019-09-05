// Url:https://leetcode.com/problems/all-oone-data-structure

/*
432. All O`one Data Structure
Hard

Implement a data structure supporting the following operations:



Inc(Key) - Inserts a new key  with value 1. Or increments an existing key by 1. Key is guaranteed to be a non-empty string.
Dec(Key) - If Key&apos;s value is 1, remove it from the data structure. Otherwise decrements an existing key by 1. If the key does not exist, this function does nothing. Key is guaranteed to be a non-empty string.
GetMaxKey() - Returns one of the keys with maximal value. If no element exists, return an empty string &quot;&quot;.
GetMinKey() - Returns one of the keys with minimal value. If no element exists, return an empty string &quot;&quot;.




Challenge: Perform all these in O(1) time complexity.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution432
{
    public class AllOne {​    /** Initialize your data structure here. */    public AllOne() { }        /** Inserts a new key <Key> with value 1. Or increments an existing key by 1. */    public void Inc(string key) { }        /** Decrements an existing key by 1. If Key's value is 1, remove it from the data structure. */    public void Dec(string key) { }        /** Returns one of the keys with maximal value. */    public string GetMaxKey() { }        /** Returns one of the keys with Minimal value. */    public string GetMinKey() { } }​/** * Your AllOne object will be instantiated and called as such: * AllOne obj = new AllOne(); * obj.Inc(key); * obj.Dec(key); * string param_3 = obj.GetMaxKey(); * string param_4 = obj.GetMinKey(); *
}
