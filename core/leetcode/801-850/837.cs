// Url:https://leetcode.com/problems/new-21-game

/*
837. New 21 Game
Medium

Alice plays the following game, loosely based on the card game &quot;21&quot;.

Alice starts with 0 points, and draws numbers while she has less than K points.&#xA0; During each draw, she gains an integer number of points randomly from the range [1, W], where W is an integer.&#xA0; Each draw is independent and the outcomes have equal probabilities.

Alice stops drawing numbers when she gets K or more points.&#xA0; What is the probability&#xA0;that she has N or less points?

Example 1:

Input: N = 10, K = 1, W = 10
Output: 1.00000
Explanation:  Alice gets a single card, then stops.


Example 2:

Input: N = 6, K = 1, W = 10
Output: 0.60000
Explanation:  Alice gets a single card, then stops.
In 6 out of W = 10 possibilities, she is at or below N = 6 points.


Example 3:

Input: N = 21, K = 17, W = 10
Output: 0.73278

Note:


	0 &lt;= K &lt;= N &lt;= 10000
	1 &lt;= W &lt;= 10000
	Answers will be accepted as correct if they are within 10^-5 of the correct answer.
	The judging time limit has been reduced for this question.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution837
{
    public class Solution
    {
        public void Init() { }

        public double New21Game(int N, int K, int W) { }
    }
}
