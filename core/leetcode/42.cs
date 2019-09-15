// Url: https://leetcode.com/problems/trapping-rain-water

/*
42. Trapping Rain Water
Hard

Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.


The above elevation map is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped. Thanks Marcos for contributing this image!

Example:

Input: [0,1,0,2,1,0,1,3,2,1,2,1]
Output: 6
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution42 {
    public class Solution {
        public void Init () {
            Console.WriteLine (Trap (null));
            Console.WriteLine (Trap (new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }));
        }

        public int Trap (int[] height) {
            int result = 0;

            if (height != null && height.Length > 2) {
                int[] left = new int[height.Length];
                int[] right = new int[height.Length];

                left[0] = height[0];
                for (int i = 1; i < height.Length; i++) {
                    left[i] = Math.Max (left[i - 1], height[i]);
                }

                right[height.Length - 1] = height[height.Length - 1];
                for (int i = height.Length - 2; i >= 0; i--) {
                    right[i] = Math.Max (right[i + 1], height[i]);
                }

                for (int i = 0; i < height.Length; i++) {
                    result += Math.Min (left[i], right[i]) - height[i];
                }
            }

            return result;
        }
    }
}