// Url:https://leetcode.com/problems/arithmetic-slices

/*
413. Arithmetic Slices
Medium

A sequence of number is called arithmetic if it consists of at least three elements and if the difference between any two consecutive elements is the same.

For example, these are arithmetic sequence:
1, 3, 5, 7, 9
7, 7, 7, 7
3, -1, -5, -9

The following sequence is not arithmetic. 1, 1, 2, 5, 7 


A zero-indexed array A consisting of N numbers is given. A slice of that array is any pair of integers (P, Q) such that 0 &lt;= P &lt; Q &lt; N.

A slice (P, Q) of array A is called arithmetic if the sequence:
    A[P], A[p + 1], ..., A[Q - 1], A[Q] is arithmetic. In particular, this means that P + 1 &lt; Q.

The function should return the number of arithmetic slices in the array A. 


Example:
A = [1, 2, 3, 4]

return: 3, for 3 arithmetic slices in A: [1, 2, 3], [2, 3, 4] and [1, 2, 3, 4] itself.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution413
{
    public class Solution
    {
        public void Init() { }

        public int NumberOfArithmeticSlices(int[] A) { }
    }
}
