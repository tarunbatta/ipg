// Url:https://leetcode.com/problems/clumsy-factorial

/*
1006. Clumsy Factorial
Medium

Normally, the factorial of a positive integer n&#xA0;is the product of all positive integers less than or equal to n.&#xA0; For example, factorial(10) = 10 * 9 * 8 * 7 * 6 * 5 * 4 * 3 * 2 * 1.

We instead make a clumsy factorial:&#xA0;using the integers in decreasing order, we&#xA0;swap out the multiply operations for a fixed rotation of operations:&#xA0;multiply (*), divide (/), add (+) and subtract (-) in this order.

For example, clumsy(10) = 10 * 9 / 8 + 7 - 6 * 5 / 4 + 3 - 2 * 1.&#xA0; However, these operations are still applied using the usual order of operations of arithmetic: we do all multiplication and division steps before any addition or subtraction steps, and multiplication and division steps are processed left to right.

Additionally, the division that we use is floor division&#xA0;such that&#xA0;10 * 9 / 8&#xA0;equals&#xA0;11.&#xA0; This guarantees the result is&#xA0;an integer.

Implement the&#xA0;clumsy&#xA0;function&#xA0;as defined above: given an integer N, it returns the clumsy factorial of N.

&#xA0;

Example 1:

Input: 4
Output:&#xA0;7
Explanation: 7 = 4 * 3 / 2 + 1


Example 2:

Input: 10
Output: 12
Explanation: 12 = 10 * 9 / 8 + 7 - 6 * 5 / 4 + 3 - 2 * 1


&#xA0;

Note:


	1 &lt;= N &lt;= 10000
	-2^31 &lt;= answer &lt;= 2^31 - 1&#xA0; (The answer is guaranteed to fit within a 32-bit integer.)
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1006
{
    public class Solution
    {
        public void Init() { }

        public int Clumsy(int N) { }
    }
}
