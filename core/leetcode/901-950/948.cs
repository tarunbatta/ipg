// Url:https://leetcode.com/problems/bag-of-tokens

/*
948. Bag of Tokens
Medium

You have an initial power P, an initial score of 0 points, and a bag of tokens.

Each token can be used at most once, has a value token[i], and has potentially two ways to use it.


	If we have at least token[i] power, we may play the token face up, losing token[i] power, and gaining 1 point.
	If we have at least 1 point, we may play the token face down, gaining token[i] power, and losing 1 point.


Return the largest number of points we can have after playing any number of tokens.

&#xA0;





Example 1:

Input: tokens = [100], P = 50
Output: 0



Example 2:

Input: tokens = [100,200], P = 150
Output: 1



Example 3:

Input: tokens = [100,200,300,400], P = 200
Output: 2


&#xA0;

Note:


	tokens.length &lt;= 1000
	0 &lt;= tokens[i] &lt; 10000
	0 &lt;= P &lt; 10000
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution948
{
    public class Solution
    {
        public int BagOfTokensScore(int[] tokens, int P) { }
    }
