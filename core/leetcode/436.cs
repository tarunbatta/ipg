// Url:https://leetcode.com/problems/find-right-interval

/*
436. Find Right Interval
Medium

Given a set of intervals, for each of the interval i, check if there exists an interval j whose start point is bigger than or equal to the end point of the interval i, which can be called that j is on the &quot;right&quot; of i.

For any interval i, you need to store the minimum interval j&apos;s index, which means that the interval j has the minimum start point to build the &quot;right&quot; relationship for interval i. If the interval j doesn&apos;t exist, store -1 for the interval i. Finally, you need output the stored value of each interval as an array.

Note:


	You may assume the interval&apos;s end point is always bigger than its start point.
	You may assume none of these intervals have the same start point.


&#xA0;

Example 1:

Input: [ [1,2] ]

Output: [-1]

Explanation: There is only one interval in the collection, so it outputs -1.


&#xA0;

Example 2:

Input: [ [3,4], [2,3], [1,2] ]

Output: [-1, 0, 1]

Explanation: There is no satisfied &quot;right&quot; interval for [3,4].
For [2,3], the interval [3,4] has minimum-&quot;right&quot; start point;
For [1,2], the interval [2,3] has minimum-&quot;right&quot; start point.


&#xA0;

Example 3:

Input: [ [1,4], [2,3], [3,4] ]

Output: [-1, 2, -1]

Explanation: There is no satisfied &quot;right&quot; interval for [1,4] and [3,4].
For [2,3], the interval [3,4] has minimum-&quot;right&quot; start point.


NOTE:&#xA0;input types have been changed on April 15, 2019. Please reset to default code definition to get new method signature.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution436
{
    public class Solution
    {
        public void Init() { }

        public int[] FindRightInterval(int[][] intervals) { }
    }
}
