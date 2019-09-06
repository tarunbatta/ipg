// Url:https://leetcode.com/problems/implement-rand10-using-rand7

/*
470. Implement Rand10() Using Rand7()
Medium

Given a function rand7 which generates a uniform random integer in the range 1 to 7, write a function rand10&#xA0;which generates a uniform random integer in the range 1 to 10.

Do NOT use system&apos;s Math.random().




&#xA0;


Example 1:

Input: 1
Output: [7]



Example 2:

Input: 2
Output: [8,4]



Example 3:

Input: 3
Output: [8,1,10]


&#xA0;

Note:


	rand7 is predefined.
	Each testcase has one argument:&#xA0;n, the number of times that rand10 is called.


&#xA0;

Follow up:


	What is the expected value&#xA0;for the number of calls to&#xA0;rand7()&#xA0;function?
	Could you minimize the number of calls to rand7()?
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution470
{
    /** * The Rand7() API is already defined in the parent class SolBase. * public int Rand7(); * @return a random integer in the range 1 to 7 */
    public class Solution : SolBase { public int Rand10() { } }
}
