// Url:https://leetcode.com/problems/max-chunks-to-make-sorted-ii

/*
768. Max Chunks To Make Sorted II
Hard

This question is the same as "Max Chunks to Make Sorted" except the integers of the given array are not necessarily distinct, the input array could be up to length 2000, and the elements could be up to 10**8.



Given an array arr of integers (not necessarily distinct), we split the array into some number of "chunks" (partitions), and individually sort each chunk.  After concatenating them, the result equals the sorted array.

What is the most number of chunks we could have made?

Example 1:

Input: arr = [5,4,3,2,1]
Output: 1
Explanation:
Splitting into two or more chunks will not return the required result.
For example, splitting into [5, 4], [3, 2, 1] will result in [4, 5, 1, 2, 3], which isn't sorted.


Example 2:

Input: arr = [2,1,3,4,4]
Output: 4
Explanation:
We can split into two chunks, such as [2, 1], [3, 4, 4].
However, splitting into [2, 1], [3], [4], [4] is the highest number of chunks possible.


Note:
	arr will have length in range [1, 2000].
	arr[i] will be an integer in range [0, 10**8].
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.problem768 {
    public class Solution {
        public void Init () {
            Console.WriteLine ();
        }

        // Time: O (n log (n))
        // Space: O (n)
        // Let arr_sorted be the arr array after being sorted. A "chunk" is an interval [i, j] such that arr[i], ..., arr[j] is just a permutation of arr_sorted[i], ..., arr_sorted[j]. Since each chunk is just a permutation, the sums of these two lists of numbers will be equal.
        public int MaxChunksToSorted (int[] arr) {
            int result = 0;

            if (arr == null || arr.Length == 0) {
                return result;
            }

            int[] expect = (int[]) arr.Clone ();
            Array.Sort (expect);

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < arr.Length; ++i) {
                sum1 += expect[i];
                sum2 += arr[i];

                if (sum1 == sum2) {
                    result++;
                }
            }

            return result;
        }
    }
}