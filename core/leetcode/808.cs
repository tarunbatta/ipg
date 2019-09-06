// Url:https://leetcode.com/problems/soup-servings

/*
808. Soup Servings
Medium

There are two types of soup: type A and type B. Initially we have N ml of each type of soup. There are four kinds of operations:


	Serve&#xA0;100 ml of soup A and 0 ml of soup B
	Serve&#xA0;75 ml of soup A and 25&#xA0;ml of soup B
	Serve 50 ml of soup A and 50 ml of soup B
	Serve 25&#xA0;ml of soup A and 75&#xA0;ml of soup B


When we serve some soup, we give it to someone and we no longer have it.&#xA0; Each turn,&#xA0;we will choose from the four operations with equal probability 0.25. If the remaining volume of soup is not enough to complete the operation, we will serve&#xA0;as much as we can.&#xA0; We stop once we no longer have some quantity of both types of soup.

Note that we do not have the operation where all 100 ml&apos;s of soup B are used first.&#xA0;&#xA0;

Return the probability that soup A will be empty&#xA0;first, plus half the probability that A and B become empty at the same time.

&#xA0;

Example:
Input: N = 50
Output: 0.625
Explanation: 
If we choose the first two operations, A will become empty first. For the third operation, A and B will become empty at the same time. For the fourth operation, B will become empty first. So the total probability of A becoming empty first plus half the probability that A and B become empty at the same time, is 0.25 * (1 + 1 + 0.5 + 0) = 0.625.



Notes: 


	0 &lt;= N &lt;= 10^9.&#xA0;
	Answers within&#xA0;10^-6&#xA0;of the true value will be accepted as correct.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution808
{
    public class Solution
    {
        public void Init() { }

        public double SoupServings(int N) { }
    }
}
