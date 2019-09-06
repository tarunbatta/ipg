// Url:https://leetcode.com/problems/3sum-with-multiplicity

/*
923. 3Sum With Multiplicity
Medium

Given an integer array A, and an integer target, return the number of&#xA0;tuples&#xA0;i, j, k&#xA0; such that i &lt; j &lt; k and&#xA0;A[i] + A[j] + A[k] == target.

As the answer can be very large, return it modulo&#xA0;10^9 + 7.

&#xA0;

Example 1:

Input: A = [1,1,2,2,3,3,4,4,5,5], target = 8
Output: 20
Explanation: 
Enumerating by the values (A[i], A[j], A[k]):
(1, 2, 5) occurs 8 times;
(1, 3, 4) occurs 8 times;
(2, 2, 4) occurs 2 times;
(2, 3, 3) occurs 2 times.



Example 2:

Input: A = [1,1,2,2,2,2], target = 5
Output: 12
Explanation: 
A[i] = 1, A[j] = A[k] = 2 occurs 12 times:
We choose one 1 from [1,1] in 2 ways,
and two 2s from [2,2,2,2] in 6 ways.


&#xA0;


Note:


	3 &lt;= A.length &lt;= 3000
	0 &lt;= A[i] &lt;= 100
	0 &lt;= target &lt;= 300
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution923
{
    public class Solution
    {
        public void Init() { }

        public int ThreeSumMulti(int[] A, int target) { }
    }
}
