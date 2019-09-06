// Url:https://leetcode.com/problems/powerful-integers

/*
970. Powerful Integers
Easy

Given two positive integers x and y, an integer is powerful&#xA0;if it is equal to x^i + y^j&#xA0;for&#xA0;some integers i &gt;= 0 and j &gt;= 0.

Return a list of all powerful integers that have value less than or equal to bound.

You may return the answer in any order.&#xA0; In your answer, each value should occur at most once.

&#xA0;


Example 1:

Input: x = 2, y = 3, bound = 10
Output: [2,3,4,5,7,9,10]
Explanation: 
2 = 2^0 + 3^0
3 = 2^1 + 3^0
4 = 2^0 + 3^1
5 = 2^1 + 3^1
7 = 2^2 + 3^1
9 = 2^3 + 3^0
10 = 2^0 + 3^2



Example 2:

Input: x = 3, y = 5, bound = 15
Output: [2,4,6,8,10,14]




&#xA0;

Note:


	1 &lt;= x &lt;= 100
	1 &lt;= y&#xA0;&lt;= 100
	0 &lt;= bound&#xA0;&lt;= 10^6
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution970
{
    public class Solution
    {
        public void Init() { }

        public IList<int> PowerfulIntegers(int x, int y, int bound) { }
    }
}
