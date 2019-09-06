// Url:https://leetcode.com/problems/numbers-at-most-n-given-digit-set

/*
902. Numbers At Most N Given Digit Set
Hard

We have a sorted set of digits D, a non-empty subset of {&apos;1&apos;,&apos;2&apos;,&apos;3&apos;,&apos;4&apos;,&apos;5&apos;,&apos;6&apos;,&apos;7&apos;,&apos;8&apos;,&apos;9&apos;}.&#xA0; (Note that &apos;0&apos; is not included.)

Now, we write numbers using these digits, using each digit as many times as we want.&#xA0; For example, if D = {&apos;1&apos;,&apos;3&apos;,&apos;5&apos;}, we may write numbers such as &apos;13&apos;, &apos;551&apos;, &apos;1351315&apos;.

Return the number of positive integers that can be written (using the digits of D) that are less than or equal to N.

&#xA0;

Example 1:

Input: D = [&quot;1&quot;,&quot;3&quot;,&quot;5&quot;,&quot;7&quot;], N = 100
Output: 20
Explanation: 
The 20 numbers that can be written are:
1, 3, 5, 7, 11, 13, 15, 17, 31, 33, 35, 37, 51, 53, 55, 57, 71, 73, 75, 77.



Example 2:

Input: D = [&quot;1&quot;,&quot;4&quot;,&quot;9&quot;], N = 1000000000
Output: 29523
Explanation: 
We can write 3 one digit numbers, 9 two digit numbers, 27 three digit numbers,
81 four digit numbers, 243 five digit numbers, 729 six digit numbers,
2187 seven digit numbers, 6561 eight digit numbers, and 19683 nine digit numbers.
In total, this is 29523 integers that can be written using the digits of D.


&#xA0;

Note:


	D is a&#xA0;subset of digits &apos;1&apos;-&apos;9&apos; in sorted order.
	1 &lt;= N &lt;= 10^9
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution902
{
    public class Solution
    {
        public void Init() { }

        public int AtMostNGivenDigitSet(string[] D, int N) { }
    }
}
