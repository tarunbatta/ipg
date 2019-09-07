// Url:https://leetcode.com/problems/shuffle-an-array

/*
384. Shuffle an Array
Medium

Shuffle a set of numbers without duplicates.


Example:
// Init an array with set 1, 2, and 3.
int[] nums = {1,2,3};
Solution solution = new Solution(nums);

// Shuffle the array [1,2,3] and return its result. Any permutation of [1,2,3] must equally likely to be returned.
solution.shuffle();

// Resets the array back to its original configuration [1,2,3].
solution.reset();

// Returns the random shuffling of array [1,2,3].
solution.shuffle();
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution384 {
    public class Solution {
        public void Init () {
            Solution obj = new Solution (null);
            int[] param_1 = obj.Reset ();
            int[] param_2 = obj.Shuffle ();
        }

        public Solution (int[] nums) {

        }

        // Resets the array to its original configuration and return it
        public int[] Reset () {
            return null;
        }

        // Returns a random shuffling of the array
        public int[] Shuffle () {
            return null;
        }
    }
}