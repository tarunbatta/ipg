// Url:https://leetcode.com/problems/equal-rational-numbers

/*
972. Equal Rational Numbers
Hard

Given two strings S and T, each of which represents a non-negative rational number, return True if and only if they represent the same number. The strings may use parentheses to denote the repeating part of the rational number.

In general a rational number can be represented using up to&#xA0;three parts: an&#xA0;integer part, a&#xA0;non-repeating part, and a&#xA0;repeating part. The number will be represented&#xA0;in one of the following three ways:


	&lt;IntegerPart&gt; (e.g. 0, 12, 123)
	&lt;IntegerPart&gt;&lt;.&gt;&lt;NonRepeatingPart&gt; &#xA0;(e.g. 0.5, 1., 2.12, 2.0001)
	&lt;IntegerPart&gt;&lt;.&gt;&lt;NonRepeatingPart&gt;&lt;(&gt;&lt;RepeatingPart&gt;&lt;)&gt; (e.g. 0.1(6), 0.9(9), 0.00(1212))


The repeating portion of a decimal expansion is conventionally denoted within a pair of round brackets.&#xA0; For example:

1 / 6 = 0.16666666... = 0.1(6) = 0.1666(6) = 0.166(66)

Both 0.1(6) or 0.1666(6) or 0.166(66) are correct representations of 1 / 6.

&#xA0;

Example 1:

Input: S = &quot;0.(52)&quot;, T = &quot;0.5(25)&quot;
Output: true
Explanation:
Because &quot;0.(52)&quot; represents 0.52525252..., and &quot;0.5(25)&quot; represents 0.52525252525..... , the strings represent the same number.



Example 2:

Input: S = &quot;0.1666(6)&quot;, T = &quot;0.166(66)&quot;
Output: true



Example 3:

Input: S = &quot;0.9(9)&quot;, T = &quot;1.&quot;
Output: true
Explanation: 
&quot;0.9(9)&quot; represents 0.999999999... repeated forever, which equals 1.  [See this link for an explanation.]
&quot;1.&quot; represents the number 1, which is formed correctly: (IntegerPart) = &quot;1&quot; and (NonRepeatingPart) = &quot;&quot;.

&#xA0;



Note:


	Each part consists only of digits.
	The &lt;IntegerPart&gt;&#xA0;will&#xA0;not begin with 2 or more zeros.&#xA0; (There is no other restriction on the digits of each part.)
	1 &lt;= &lt;IntegerPart&gt;.length &lt;= 4 
	0 &lt;= &lt;NonRepeatingPart&gt;.length &lt;= 4 
	1 &lt;= &lt;RepeatingPart&gt;.length &lt;= 4
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution972
{
    public class Solution
    {
        public void Init() { }

        public bool IsRationalEqual(string S, string T) { }
    }
}
