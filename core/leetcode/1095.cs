// Url:https://leetcode.com/problems/find-in-mountain-array

/*
1095. Find in Mountain Array
Hard

(This problem is an&#xA0;interactive problem.)

You may recall that an array&#xA0;A is a mountain array if and only if:


	A.length &gt;= 3
	There exists some&#xA0;i&#xA0;with&#xA0;0 &lt; i&#xA0;&lt; A.length - 1&#xA0;such that:
	
		A[0] &lt; A[1] &lt; ... A[i-1] &lt; A[i]
		A[i] &gt; A[i+1] &gt; ... &gt; A[A.length - 1]
	
	


Given a mountain&#xA0;array mountainArr, return the minimum&#xA0;index such that mountainArr.get(index) == target.&#xA0; If such an index&#xA0;doesn&apos;t exist, return -1.

You can&apos;t access the mountain array directly.&#xA0; You may only access the array using a&#xA0;MountainArray&#xA0;interface:


	MountainArray.get(k) returns the element of the array at index k&#xA0;(0-indexed).
	MountainArray.length()&#xA0;returns the length of the array.


Submissions making more than 100 calls to&#xA0;MountainArray.get&#xA0;will be judged Wrong Answer.&#xA0; Also, any solutions that attempt to circumvent the judge&#xA0;will result in disqualification.




&#xA0;
Example 1:

Input: array = [1,2,3,4,5,3,1], target = 3
Output: 2
Explanation: 3 exists in the array, at index=2 and index=5. Return the minimum index, which is 2.

Example 2:

Input: array = [0,1,2,4,2,1], target = 3
Output: -1
Explanation: 3 does not exist in the array, so we return -1.


&#xA0;
Constraints:


	3 &lt;= mountain_arr.length() &lt;= 10000
	0 &lt;= target &lt;= 10^9
	0 &lt;= mountain_arr.get(index) &lt;=&#xA0;10^9
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1095
{
    /** * // This is MountainArray's API interface. * // You should not implement it, or speculate about its implementation * class MountainArray { *     public int Get(int index) {} *     public int Length() {} * } */
    class Solution { public int FindInMountainArray(int target, MountainArray mountainArr) { } }
}
