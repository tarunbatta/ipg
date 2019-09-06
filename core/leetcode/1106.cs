// Url:https://leetcode.com/problems/parsing-a-boolean-expression

/*
1106. Parsing A Boolean Expression
Hard

Return the result of evaluating a given boolean expression, represented as a string.

An expression can either be:


	&quot;t&quot;, evaluating to True;
	&quot;f&quot;, evaluating to False;
	&quot;!(expr)&quot;, evaluating to the logical NOT of the inner expression expr;
	&quot;&amp;(expr1,expr2,...)&quot;, evaluating to the logical AND of 2 or more inner expressions expr1, expr2, ...;
	&quot;|(expr1,expr2,...)&quot;, evaluating to the logical OR of 2 or more inner expressions expr1, expr2, ...


&#xA0;
Example 1:

Input: expression = &quot;!(f)&quot;
Output: true


Example 2:

Input: expression = &quot;|(f,t)&quot;
Output: true


Example 3:

Input: expression = &quot;&amp;(t,f)&quot;
Output: false


Example 4:

Input: expression = &quot;|(&amp;(t,f,t),!(t))&quot;
Output: false


&#xA0;
Constraints:


	1 &lt;= expression.length &lt;= 20000
	expression[i]&#xA0;consists of characters in {&apos;(&apos;, &apos;)&apos;, &apos;&amp;&apos;, &apos;|&apos;, &apos;!&apos;, &apos;t&apos;, &apos;f&apos;, &apos;,&apos;}.
	expression is a valid expression representing a boolean, as given in the description.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1106
{
    public class Solution
    {
        public void Init() { }

        public bool ParseBoolExpr(string expression) { }
    }
}
