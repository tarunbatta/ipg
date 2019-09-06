using System;

namespace TechByTarun.InterviewPreperationGuide.App.Leetcode
{
    /// <summary>
    /// Single Element in a Sorted Array
    /// https://leetcode.com/problems/single-element-in-a-sorted-array/
    ///
    /// Given a sorted array consisting of only integers where every element appears twice except for one element which appears once.
    /// Find this single element that appears only once.
    ///
    /// Example 1:
    /// Input: [1,1,2,3,3,4,4,8,8]
    /// Output: 2
    ///
    /// Example 2:
    /// Input: [3,3,7,7,10,11,11]
    /// Output: 10
    ///
    /// Note: Your solution should run in O(log n) time and O(1) space.
    /// </summary>
    public class Question540
    {
        public static void Init()
        {
            Console.WriteLine(SingleNonDuplicate_a(null));
            Console.WriteLine(SingleNonDuplicate_a(new int[] { 1 }));
            Console.WriteLine(SingleNonDuplicate_a(new int[] { 1, 1 }));
            Console.WriteLine(SingleNonDuplicate_a(new int[] { 1, 1, 2 }));
            Console.WriteLine(SingleNonDuplicate_a(new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 }));
            Console.WriteLine(SingleNonDuplicate_a(new int[] { 3, 3, 7, 7, 10, 11, 11 }));
            Console.WriteLine(SingleNonDuplicate_a(new int[] { 1, 1, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5 }));
            Console.WriteLine(SingleNonDuplicate_a(new int[] { 1, 1, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5 }));

            Console.WriteLine(SingleNonDuplicate_b(null));
            Console.WriteLine(SingleNonDuplicate_b(new int[] { 1 }));
            Console.WriteLine(SingleNonDuplicate_b(new int[] { 1, 1 }));
            Console.WriteLine(SingleNonDuplicate_b(new int[] { 1, 1, 2 }));
            Console.WriteLine(SingleNonDuplicate_b(new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 }));
            Console.WriteLine(SingleNonDuplicate_b(new int[] { 3, 3, 7, 7, 10, 11, 11 }));
            Console.WriteLine(SingleNonDuplicate_b(new int[] { 1, 1, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5 }));
            Console.WriteLine(SingleNonDuplicate_b(new int[] { 1, 1, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5 }));
        }

        public static int SingleNonDuplicate_a(int[] nums)
        {
            int result = 0;

            if (nums != null)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    result ^= nums[i];
                }
            }

            return result;
        }

        public static int SingleNonDuplicate_b(int[] nums)
        {
            int result = 0;

            if (nums != null)
            {
                if (nums.Length == 1)
                {
                    result = nums[0];
                }
                else if (nums.Length == 2)
                {
                    result = 0;
                }
                else
                {
                    result = SingleNonDuplicateHelper(nums, 0, nums.Length - 1);
                }
            }

            return result;
        }

        public static int SingleNonDuplicateHelper(int[] nums, int start, int end)
        {
            if (start == end)
            {
                return nums[start];
            }

            if (start < end)
            {
                int mid = (end - start) / 2 + start;

                if (mid % 2 == 0)
                {
                    if (nums[mid] == nums[mid + 1])
                    {
                        return SingleNonDuplicateHelper(nums, mid + 2, end);
                    }
                    else
                    {
                        return SingleNonDuplicateHelper(nums, start, mid);
                    }
                }
                else
                {
                    if (nums[mid] == nums[mid - 1])
                    {
                        return SingleNonDuplicateHelper(nums, mid + 1, end);
                    }
                    else
                    {
                        return SingleNonDuplicateHelper(nums, start, mid);
                    }
                }
            }

            return 0;
        }
    }
}