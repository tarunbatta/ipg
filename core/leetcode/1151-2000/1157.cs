// Url:https://leetcode.com/problems/online-majority-element-in-subarray

/*
1157. Online Majority Element In Subarray
Hard

Implementing the class MajorityChecker, which has the following API:


	MajorityChecker(int[] arr) constructs an instance of MajorityChecker with the given array arr;
	int query(int left, int right, int threshold)&#xA0;has arguments&#xA0;such that:
	
		0 &lt;= left&#xA0;&lt;= right&#xA0;&lt; arr.length representing a subarray of arr;
		2 * threshold &gt; right - left + 1, ie. the threshold is always a strict majority of the length of&#xA0;the subarray
	
	


Each&#xA0;query(...) returns the element in arr[left], arr[left+1], ..., arr[right] that occurs at least threshold times, or -1 if no such element exists.

&#xA0;

Example:

MajorityChecker majorityChecker = new MajorityChecker([1,1,2,2,1,1]);
majorityChecker.query(0,5,4); // returns 1
majorityChecker.query(0,3,3); // returns -1
majorityChecker.query(2,3,2); // returns 2


&#xA0;
Constraints:


	1 &lt;= arr.length &lt;=&#xA0;20000
	1 &lt;= arr[i]&#xA0;&lt;=&#xA0;20000
	For each query, 0 &lt;= left &lt;= right &lt; len(arr)
	For each query, 2 * threshold &gt; right - left + 1
	The number of queries is at most 10000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1157
{
    public class MajorityChecker {​    public MajorityChecker(int[] arr) { } public int Query(int left, int right, int threshold) { } }​/** * Your MajorityChecker object will be instantiated and called as such: * MajorityChecker obj = new MajorityChecker(arr); * int param_1 = obj.Query(left,right,threshold); *
}
