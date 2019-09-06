// Url:https://leetcode.com/problems/sliding-window-maximum

/*
239. Sliding Window Maximum
Hard

Given an array nums, there is a sliding window of size k which is moving from the very left of the array to the very right. You can only see the k numbers in the window. Each time the sliding window moves right by one position. Return the max sliding window.

Example:

Input: nums = [1,3,-1,-3,5,3,6,7], and k = 3
Output: [3,3,5,5,6,7] 
Explanation: 

Window position                Max
---------------               -----
[1  3  -1] -3  5  3  6  7       3
 1 [3  -1  -3] 5  3  6  7       3
 1  3 [-1  -3  5] 3  6  7       5
 1  3  -1 [-3  5  3] 6  7       5
 1  3  -1  -3 [5  3  6] 7       6
 1  3  -1  -3  5 [3  6  7]      7


Note: 
You may assume k is always valid, 1 &#x2264; k &#x2264; input array&apos;s size for non-empty array.

Follow up:
Could you solve it in linear time?
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution239
{
    public class Solution
    {
        public void Init() { }

        public int[] MaxSlidingWindow(int[] nums, int k) { }
    }
}
