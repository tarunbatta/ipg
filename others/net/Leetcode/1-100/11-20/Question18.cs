using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.App.Leetcode {
    /// <summary>
    /// 4Sum
    /// https://leetcode.com/problems/4sum/
    ///
    /// Given an array S of n integers, are there elements a, b, c, and d in S such that a + b + c + d = target?
    /// Find all unique quadruplets in the array which gives the sum of target.
    ///
    /// Note: The solution set must not contain duplicate quadruplets.
    ///
    /// For example, given array S = [1, 0, -1, 0, -2, 2], and target = 0.
    /// A solution set is:
    /// [
    ///     [-1,  0, 0, 1],
    ///     [-2, -1, 1, 2],
    ///     [-2,  0, 0, 2]
    /// ]
    /// </summary>
    public class Question18 {
        public static void Init (string[] args) {
            Program.PrintListofList (FourSum (null, 0));
            Program.PrintLine ();
            Program.PrintListofList (FourSum (new int[] { 1, 0, -1 }, 0));
            Program.PrintLine ();
            Program.PrintListofList (FourSum (new int[] { 1, 0, -1, 0, -2, 2 }, 0));
        }

        public static IList<IList<int>> FourSum (int[] nums, int target) {
            IList<IList<int>> result = new List<IList<int>> ();

            if (nums != null && nums.Length >= 4) {
                Array.Sort (nums);
                Dictionary<string, List<int>> dict = new Dictionary<string, List<int>> ();

                for (int i = 0; i < nums.Length - 3; i++) {
                    for (int j = i + 1; j < nums.Length - 2; j++) {
                        int k = j + 1;
                        int l = nums.Length - 1;

                        while (k < l) {
                            int sum = nums[i] + nums[j] + nums[k] + nums[l];

                            if (sum > target) {
                                l--;
                            } else if (sum < target) {
                                k++;
                            } else {
                                string key = string.Concat (nums[i], ",", nums[j], ",", nums[k], ",", nums[l]);

                                List<int> val = new List<int> ();
                                val.Add (nums[i]);
                                val.Add (nums[j]);
                                val.Add (nums[k]);
                                val.Add (nums[l]);

                                if (!dict.ContainsKey (key)) {
                                    dict.Add (key, val);
                                    result.Add (val);
                                }

                                k++;
                                l--;
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}