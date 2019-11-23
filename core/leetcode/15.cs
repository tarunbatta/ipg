// Url: https://leetcode.com/problems/3sum/

/*
15. 3Sum
Medium

Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

Note:

The solution set must not contain duplicate triplets.

Example:

Given array nums = [-1, 0, 1, 2, -1, -4],

A solution set is:
[
  [-1, 0, 1],
  [-1, -1, 2]
]
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.problem15
{
    public class Solution
    {
        public void Init()
        {
            Console.WriteLine(ThreeSum(null));
            Console.WriteLine(ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }));
            Console.WriteLine(ThreeSum(new int[] { -1, 0, 1 }));
            Console.WriteLine(ThreeSum(new int[] { -1, 0, 2 }));
            Console.WriteLine(ThreeSum(new int[] { -1, 0 }));
            Console.WriteLine(ThreeSum(new int[] { -1, 0, 1, 2, -1, -2 }));
        }

        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            if (nums != null && nums.Length >= 3)
            {
                Array.Sort(nums);

                for (int i = 0; i < nums.Length - 2;)
                {
                    int j = i + 1;
                    int k = nums.Length - 1;
                    int sumRight = nums[i] * -1;

                    while (k > j)
                    {
                        int sumLeft = nums[j] + nums[k];

                        if (sumLeft == sumRight)
                        {
                            result.Add(new List<int>() { nums[i], nums[j], nums[k] });

                            int x = nums[j];
                            while (nums[j] == x && j < k)
                            {
                                j++;
                            }
                        }
                        else if (sumLeft > sumRight)
                        {
                            k--;
                        }
                        else
                        {
                            j++;
                        }
                    }

                    int val = nums[i];
                    while (nums[i] == val && i < nums.Length - 1)
                    {
                        i++;
                    }
                }
            }

            return result;
        }
    }
}