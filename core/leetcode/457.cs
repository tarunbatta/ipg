// Url:https://leetcode.com/problems/circular-array-loop

/*
457. Circular Array Loop
Medium

You are given a circular array nums of positive and negative integers. If a number k at an index is positive, then move forward k steps. Conversely, if it&apos;s negative (-k), move backward k&#xA0;steps. Since the array is circular, you may assume that the last element&apos;s next element is the first element, and the first element&apos;s previous element is the last element.

Determine if there is a loop (or a cycle) in nums. A cycle must start and end at the same index and the cycle&apos;s length &gt; 1. Furthermore, movements in a cycle must all follow a single direction. In other words, a cycle must not consist of both forward and backward movements.

&#xA0;

Example 1:

Input: [2,-1,1,2,2]
Output: true
Explanation: There is a cycle, from index 0 -&gt; 2 -&gt; 3 -&gt; 0. The cycle&apos;s length is 3.


Example 2:

Input: [-1,2]
Output: false
Explanation: The movement from index 1 -&gt; 1 -&gt; 1 ... is not a cycle, because the cycle&apos;s length is 1. By definition the cycle&apos;s length must be greater than 1.


Example 3:

Input: [-2,1,-1,-2,-2]
Output: false
Explanation: The movement from index 1 -&gt; 2 -&gt; 1 -&gt; ... is not a cycle, because movement from index 1 -&gt; 2 is a forward movement, but movement from index 2 -&gt; 1 is a backward movement. All movements in a cycle must follow a single direction.

&#xA0;

Note:


	-1000 &#x2264;&#xA0;nums[i] &#x2264;&#xA0;1000
	nums[i] &#x2260;&#xA0;0
	1 &#x2264;&#xA0;nums.length &#x2264; 5000


&#xA0;

Follow up:

Could you solve it in O(n) time complexity and&#xA0;O(1) extra space complexity?
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution457
{
    public class Solution
    {
        public void Init() { }

        public bool CircularArrayLoop(int[] nums) { }
    }
}
