using System;
using System.Collections.Generic;

namespace TechByTarun.InterviewPreperationGuide.App.Leetcode
{
    /// <summary>
    /// 3Sum
    /// https://leetcode.com/problems/3sum/
    ///
    /// Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0?
    /// Find all unique triplets in the array which gives the sum of zero.
    /// Note: The solution set must not contain duplicate triplets.
    /// For example, given array S = [-1, 0, 1, 2, -1, -4]
    /// A solution set is:
    /// [
    ///     [-1, 0, 1],
    ///     [-1, -1, 2]
    /// ]
    /// </summary>
    public class Question15
    {
        public static void Init(string[] args)
        {
            Program.PrintListofList(null);
            Program.PrintLine();
            Program.PrintListofList(ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }));
            Program.PrintLine();
            Program.PrintListofList(ThreeSum(new int[] { -1, 0, 1 }));
            Program.PrintLine();
            Program.PrintListofList(ThreeSum(new int[] { -1, 0, 2 }));
            Program.PrintLine();
            Program.PrintListofList(ThreeSum(new int[] { -1, 0 }));
            Program.PrintLine();
            Program.PrintListofList(ThreeSum(new int[] { -1, 0, 1, 2, -1, -2 }));
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
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