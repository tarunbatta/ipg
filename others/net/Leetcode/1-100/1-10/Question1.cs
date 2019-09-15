using System;
using System.Collections;

namespace InterviewPreperationGuide.App.Leetcode {
    /// <summary>
    /// Two Sum
    /// https://leetcode.com/problems/two-sum/
    ///
    /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    /// You may assume that each input would have exactly one solution.
    /// Example:
    /// Given nums = [2, 7, 11, 15], target = 9,
    /// Because nums[0] + nums[1] = 2 + 7 = 9,
    /// return [0, 1].
    /// </summary>
    public class Question1 {
        public static void Init (string[] args) {
            Console.WriteLine (Program.PrintArray (TwoSum_a (null, 5)));
            Program.PrintLine ();
            Console.WriteLine (Program.PrintArray (TwoSum_a (new int[] { 2, 7, 11, 15 }, 9)));
            Program.PrintLine ();
            Console.WriteLine (Program.PrintArray (TwoSum_a (new int[] { 2, 7, 11, 15, 4, 2, 1 }, 5)));

            Program.PrintSeperator ();

            Console.WriteLine (Program.PrintArray (TwoSum_b (null, 5)));
            Program.PrintLine ();
            Console.WriteLine (Program.PrintArray (TwoSum_b (new int[] { 2, 7, 11, 15 }, 9)));
            Program.PrintLine ();
            Console.WriteLine (Program.PrintArray (TwoSum_b (new int[] { 2, 7, 11, 15, 4, 10, 1 }, 5)));

            Program.PrintSeperator ();

            Console.WriteLine (Program.PrintArray (TwoSum_c (null, 5)));
            Program.PrintLine ();
            Console.WriteLine (Program.PrintArray (TwoSum_c (new int[] { 2, 7, 11, 15 }, 9)));
            Program.PrintLine ();
            Console.WriteLine (Program.PrintArray (TwoSum_c (new int[] { 2, 7, 11, 15, 4, 10, 1 }, 5)));
        }

        public static int[] TwoSum_a (int[] nums, int target) {
            if (nums != null) {
                for (int i = 0; i < nums.Length - 1; i++) {
                    for (int j = i + 1; j < nums.Length; j++) {
                        if (nums[i] + nums[j] == target) {
                            return new int[] { nums[i], nums[j] };
                        }
                    }
                }
            }

            return null;
        }

        public static int[] TwoSum_b (int[] nums, int target) {
            if (nums != null) {
                Hashtable hash = new Hashtable ();
                for (int i = 0; i < nums.Length; i++) {
                    hash.Add ((int) nums[i], i);
                }

                for (int i = 0; i < nums.Length; i++) {
                    int diff = target - nums[i];

                    if (hash.ContainsKey (diff)) {
                        return new int[] { nums[i], diff };
                    }
                }
            }

            return null;
        }

        public static int[] TwoSum_c (int[] nums, int target) {
            if (nums != null) {
                Array.Sort (nums);

                int i = 0;
                int j = nums.Length - 1;

                while (i < j) {
                    int sum = nums[i] + nums[j];

                    if (sum == target) {
                        return new int[] { nums[i], nums[j] };
                    } else if (sum < target) {
                        i++;
                    } else {
                        j--;
                    }
                }
            }

            return null;
        }
    }
}