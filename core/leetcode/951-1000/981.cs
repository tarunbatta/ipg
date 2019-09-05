// Url:https://leetcode.com/problems/time-based-key-value-store

/*
981. Time Based Key-Value Store
Medium

Create a timebased key-value store class&#xA0;TimeMap, that supports two operations.

1. set(string key, string value, int timestamp)


	Stores the key and value, along with the given timestamp.


2. get(string key, int timestamp)


	Returns a value such that set(key, value, timestamp_prev) was called previously, with timestamp_prev &lt;= timestamp.
	If there are multiple such values, it returns the one with the largest timestamp_prev.
	If there are no values, it returns the empty string (&quot;&quot;).


&#xA0;


Example 1:

Input: inputs = [&quot;TimeMap&quot;,&quot;set&quot;,&quot;get&quot;,&quot;get&quot;,&quot;set&quot;,&quot;get&quot;,&quot;get&quot;], inputs = [[],[&quot;foo&quot;,&quot;bar&quot;,1],[&quot;foo&quot;,1],[&quot;foo&quot;,3],[&quot;foo&quot;,&quot;bar2&quot;,4],[&quot;foo&quot;,4],[&quot;foo&quot;,5]]
Output: [null,null,&quot;bar&quot;,&quot;bar&quot;,null,&quot;bar2&quot;,&quot;bar2&quot;]
Explanation: &#xA0; 
TimeMap kv; &#xA0; 
kv.set(&quot;foo&quot;, &quot;bar&quot;, 1); // store the key &quot;foo&quot; and value &quot;bar&quot; along with timestamp = 1 &#xA0; 
kv.get(&quot;foo&quot;, 1);  // output &quot;bar&quot; &#xA0; 
kv.get(&quot;foo&quot;, 3); // output &quot;bar&quot; since there is no value corresponding to foo at timestamp 3 and timestamp 2, then the only value is at timestamp 1 ie &quot;bar&quot; &#xA0; 
kv.set(&quot;foo&quot;, &quot;bar2&quot;, 4); &#xA0; 
kv.get(&quot;foo&quot;, 4); // output &quot;bar2&quot; &#xA0; 
kv.get(&quot;foo&quot;, 5); //output &quot;bar2&quot; &#xA0; 




Example 2:

Input: inputs = [&quot;TimeMap&quot;,&quot;set&quot;,&quot;set&quot;,&quot;get&quot;,&quot;get&quot;,&quot;get&quot;,&quot;get&quot;,&quot;get&quot;], inputs = [[],[&quot;love&quot;,&quot;high&quot;,10],[&quot;love&quot;,&quot;low&quot;,20],[&quot;love&quot;,5],[&quot;love&quot;,10],[&quot;love&quot;,15],[&quot;love&quot;,20],[&quot;love&quot;,25]]
Output: [null,null,null,&quot;&quot;,&quot;high&quot;,&quot;high&quot;,&quot;low&quot;,&quot;low&quot;]




&#xA0;

Note:


	All key/value strings are lowercase.
	All key/value strings have&#xA0;length in the range&#xA0;[1, 100]
	The timestamps for all TimeMap.set operations are strictly increasing.
	1 &lt;= timestamp &lt;= 10^7
	TimeMap.set and TimeMap.get&#xA0;functions will be called a total of 120000 times (combined) per test case.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution981
{
    public class TimeMap {​    /** Initialize your data structure here. */    public TimeMap() { } public void Set(string key, string value, int timestamp) { } public string Get(string key, int timestamp) { } }​/** * Your TimeMap object will be instantiated and called as such: * TimeMap obj = new TimeMap(); * obj.Set(key,value,timestamp); * string param_2 = obj.Get(key,timestamp); *
}
