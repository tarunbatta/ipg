// Url:https://leetcode.com/problems/pyramid-transition-matrix

/*
756. Pyramid Transition Matrix
Medium

We are stacking blocks to form a pyramid. Each block has a color which is a one letter string.

We are allowed to place any color block C on top of two adjacent blocks of colors A and B, if and only if ABC is an allowed triple.

We start with a bottom row of bottom, represented as a single string. We also start with a list of allowed triples allowed. Each allowed triple is represented as a string of length 3.

Return true if we can build the pyramid all the way to the top, otherwise false.

Example 1:

Input: bottom = &quot;BCD&quot;, allowed = [&quot;BCG&quot;, &quot;CDE&quot;, &quot;GEA&quot;, &quot;FFF&quot;]
Output: true
Explanation:
We can stack the pyramid like this:
    A
   / \
  G   E
 / \ / \
B   C   D

We are allowed to place G on top of B and C because BCG is an allowed triple.  Similarly, we can place E on top of C and D, then A on top of G and E.

&#xA0;

Example 2:

Input: bottom = &quot;AABA&quot;, allowed = [&quot;AAA&quot;, &quot;AAB&quot;, &quot;ABA&quot;, &quot;ABB&quot;, &quot;BAC&quot;]
Output: false
Explanation:
We can&apos;t stack the pyramid to the top.
Note that there could be allowed triples (A, B, C) and (A, B, D) with C != D.


&#xA0;

Note:


	bottom will be a string with length in range [2, 8].
	allowed will have length in range [0, 200].
	Letters in all strings will be chosen from the set {&apos;A&apos;, &apos;B&apos;, &apos;C&apos;, &apos;D&apos;, &apos;E&apos;, &apos;F&apos;, &apos;G&apos;}.


&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution756
{
    public class Solution
    {
        public void Init() { }

        public bool PyramidTransition(string bottom, IList<string> allowed) { }
    }
}
