// Url:https://leetcode.com/problems/largest-sum-of-averages

/*
813. Largest Sum of Averages
Medium

We partition a row of numbers A&#xA0;into at most K adjacent (non-empty) groups, then our score is the sum of the average of each group. What is the largest score we can achieve?

Note that our partition must use every number in A, and that scores are not necessarily integers.

Example:
Input: 
A = [9,1,2,3,9]
K = 3
Output: 20
Explanation: 
The best choice is to partition A into [9], [1, 2, 3], [9]. The answer is 9 + (1 + 2 + 3) / 3 + 9 = 20.
We could have also partitioned A into [9, 1], [2], [3, 9], for example.
That partition would lead to a score of 5 + 2 + 6 = 13, which is worse.


&#xA0;

Note: 


	1 &lt;= A.length &lt;= 100.
	1 &lt;= A[i] &lt;= 10000.
	1 &lt;= K &lt;= A.length.
	Answers within 10^-6 of the correct answer will be accepted as correct.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution813 {
    public class Solution {
        public void Init () {

        }

        public double LargestSumOfAverages (int[] A, int K) {
            return 0;
        }
    }
}