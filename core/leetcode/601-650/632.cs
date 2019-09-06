// Url:https://leetcode.com/problems/smallest-range-covering-elements-from-k-lists

/*
632. Smallest Range Covering Elements from K Lists
Hard

You have k lists of sorted integers in ascending order. Find the smallest range that includes at least one number from each of the k lists.

We define the range [a,b] is smaller than range [c,d] if b-a &lt; d-c or a &lt; c if b-a == d-c.

&#xA0;

Example 1:

Input: [[4,10,15,24,26], [0,9,12,20], [5,18,22,30]]
Output: [20,24]
Explanation: 
List 1: [4, 10, 15, 24,26], 24 is in range [20,24].
List 2: [0, 9, 12, 20], 20 is in range [20,24].
List 3: [5, 18, 22, 30], 22 is in range [20,24].


&#xA0;

Note:


	The given list may contain duplicates, so ascending order means &gt;= here.
	1 &lt;= k &lt;= 3500
	-105 &lt;= value of elements &lt;= 105.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution632
{
    public class Solution
    {
        public void Init() { }

        public int[] SmallestRange(IList<IList<int>> nums) { }
    }
}
