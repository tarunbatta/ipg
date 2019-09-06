// Url:https://leetcode.com/problems/random-pick-index

/*
398. Random Pick Index
Medium

Given an array of integers with possible duplicates, randomly output the index of a given target number. You can assume that the given target number must exist in the array.

Note:
The array size can be very large. Solution that uses too much extra space will not pass the judge.

Example:

int[] nums = new int[] {1,2,3,3,3};
Solution solution = new Solution(nums);

// pick(3) should return either index 2, 3, or 4 randomly. Each index should have equal probability of returning.
solution.pick(3);

// pick(1) should return 0. Since in the array only nums[0] is equal to 1.
solution.pick(1);
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution398
{
    public class Solution
    {
        public void Init()
        {

        }

​    public Solution(int[] nums) { }
        public int Pick(int target) { }
    }​/** * Your Solution object will be instantiated and called as such: * Solution obj = new Solution(nums); * int param_1 = obj.Pick(target); *
}
