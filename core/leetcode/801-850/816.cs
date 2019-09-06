// Url:https://leetcode.com/problems/ambiguous-coordinates

/*
816. Ambiguous Coordinates
Medium

We had some 2-dimensional coordinates, like &quot;(1, 3)&quot; or &quot;(2, 0.5)&quot;.&#xA0; Then, we removed&#xA0;all commas, decimal points, and spaces, and ended up with the string&#xA0;S.&#xA0; Return a list of strings representing&#xA0;all possibilities for what our original coordinates could have been.

Our original representation never had extraneous zeroes, so we never started with numbers like &quot;00&quot;, &quot;0.0&quot;, &quot;0.00&quot;, &quot;1.0&quot;, &quot;001&quot;, &quot;00.01&quot;, or any other number that can be represented with&#xA0;less digits.&#xA0; Also, a decimal point within a number never occurs without at least one digit occuring before it, so we never started with numbers like &quot;.1&quot;.

The final answer list can be returned in any order.&#xA0; Also note that all coordinates in the final answer&#xA0;have exactly one space between them (occurring after the comma.)

Example 1:
Input: &quot;(123)&quot;
Output: [&quot;(1, 23)&quot;, &quot;(12, 3)&quot;, &quot;(1.2, 3)&quot;, &quot;(1, 2.3)&quot;]


Example 2:
Input: &quot;(00011)&quot;
Output: &#xA0;[&quot;(0.001, 1)&quot;, &quot;(0, 0.011)&quot;]
Explanation: 
0.0, 00, 0001 or 00.01 are not allowed.


Example 3:
Input: &quot;(0123)&quot;
Output: [&quot;(0, 123)&quot;, &quot;(0, 12.3)&quot;, &quot;(0, 1.23)&quot;, &quot;(0.1, 23)&quot;, &quot;(0.1, 2.3)&quot;, &quot;(0.12, 3)&quot;]


Example 4:
Input: &quot;(100)&quot;
Output: [(10, 0)]
Explanation: 
1.0 is not allowed.


&#xA0;

Note: 


	4 &lt;= S.length &lt;= 12.
	S[0] = &quot;(&quot;, S[S.length - 1] = &quot;)&quot;, and the other elements in S are digits.


&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution816
{
    public class Solution
    {
        public void Init() { }

        public IList<string> AmbiguousCoordinates(string S) { }
    }
}
