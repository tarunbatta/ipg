// Url: https://leetcode.com/problems/move-zeroes/

/*
283. Move Zeroes
Easy

Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Example:
Input: [0,1,0,3,12]
Output: [1,3,12,0,0]

Note:
You must do this in-place without making a copy of the array.
Minimize the total number of operations.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem283
{
    public class Solution
    {
        public void Init()
        {
            MoveZeroes_a(null);
            MoveZeroes_a(new int[] { 0, 1, 0, 3, 12 });
            MoveZeroes_a(new int[] { 1, 3, 12 });

            MoveZeroes_b(null);
            MoveZeroes_b(new int[] { 0, 1, 0, 3, 12 });
            MoveZeroes_b(new int[] { 1, 3, 12 });
        }

        public void MoveZeroes_a(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return;
            }

            int x = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[x] = nums[i];
                }
            }

            for (int i = x; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        public void MoveZeroes_b(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return;
            }

            for (int x = 0, i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    Swap(nums, x++, i);
                }
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}