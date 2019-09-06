// Url:https://leetcode.com/problems/map-sum-pairs

/*
677. Map Sum Pairs
Medium

Implement a MapSum class with insert, and sum methods.



For the method insert, you&apos;ll be given a pair of (string, integer). The string represents the key and the integer represents the value. If the key already existed, then the original key-value pair will be overridden to the new one.



For the method sum, you&apos;ll be given a string representing the prefix, and you need to return the sum of all the pairs&apos; value whose key starts with the prefix.


Example 1:
Input: insert(&quot;apple&quot;, 3), Output: Null
Input: sum(&quot;ap&quot;), Output: 3
Input: insert(&quot;app&quot;, 2), Output: Null
Input: sum(&quot;ap&quot;), Output: 5
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution677
{
    public class MapSum {​    /** Initialize your data structure here. */    public MapSum() { } public void Insert(string key, int val) { } public int Sum(string prefix) { } }​/** * Your MapSum object will be instantiated and called as such: * MapSum obj = new MapSum(); * obj.Insert(key,val); * int param_2 = obj.Sum(prefix); *
}
