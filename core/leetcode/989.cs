// Url:https://leetcode.com/problems/add-to-array-form-of-integer

/*
989. Add to Array-Form of Integer
Easy

For a non-negative integer X, the&#xA0;array-form of X&#xA0;is an array of its digits in left to right order.&#xA0; For example, if X = 1231, then the array form is&#xA0;[1,2,3,1].

Given the array-form A of a non-negative&#xA0;integer X, return the array-form of the integer X+K.

&#xA0;





Example 1:

Input: A = [1,2,0,0], K = 34
Output: [1,2,3,4]
Explanation: 1200 + 34 = 1234



Example 2:

Input: A = [2,7,4], K = 181
Output: [4,5,5]
Explanation: 274 + 181 = 455



Example 3:

Input: A = [2,1,5], K = 806
Output: [1,0,2,1]
Explanation: 215 + 806 = 1021



Example 4:

Input: A = [9,9,9,9,9,9,9,9,9,9], K = 1
Output: [1,0,0,0,0,0,0,0,0,0,0]
Explanation: 9999999999 + 1 = 10000000000


&#xA0;

Note&#xFF1A;


	1 &lt;= A.length &lt;= 10000
	0 &lt;= A[i] &lt;= 9
	0 &lt;= K &lt;= 10000
	If A.length &gt; 1, then A[0] != 0
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution989
{
    public class Solution
    {
        public void Init() { }

        public IList<int> AddToArrayForm(int[] A, int K) { }
    }
}
