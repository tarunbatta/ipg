// Url:https://leetcode.com/problems/least-operators-to-express-number

/*
964. Least Operators to Express Number
Hard

Given a single positive integer x, we will write an expression of the form x (op1) x (op2) x (op3) x ...&#xA0;where each operator op1, op2, etc. is either addition, subtraction, multiplication, or division (+, -, *, or /).&#xA0; For example, with x = 3, we might write 3 * 3 / 3 + 3 - 3&#xA0;which is a value of 3.

When writing such an expression, we adhere to the following conventions:


	The division operator (/) returns rational numbers.
	There are no parentheses placed anywhere.
	We use the usual order of operations: multiplication and division happens before addition and subtraction.
	It&apos;s not allowed to use the unary negation&#xA0;operator (-).&#xA0; For example, &quot;x&#xA0;- x&quot;&#xA0;is a valid expression as it only uses subtraction, but &quot;-x +&#xA0;x&quot; is not because it uses negation.


We would like to write an expression with the least number of operators such that the expression equals the given target.&#xA0; Return the least number of operators used.

&#xA0;


Example 1:

Input: x = 3, target = 19
Output: 5
Explanation: 3 * 3 + 3 * 3 + 3 / 3.  The expression contains 5 operations.


Example 2:


Input: x = 5, target = 501
Output: 8
Explanation: 5 * 5 * 5 * 5 - 5 * 5 * 5 + 5 / 5.  The expression contains 8 operations.



Example 3:

Input: x = 100, target = 100000000
Output: 3
Explanation: 100 * 100 * 100 * 100.  The expression contains 3 operations.

&#xA0;




Note:


	2 &lt;= x &lt;= 100
	1 &lt;= target &lt;= 2 * 10^8




&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution964
{
    public class Solution
    {
        public void Init() { }

        public int LeastOpsExpressTarget(int x, int target) { }
    }
}
