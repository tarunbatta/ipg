// Url:https://leetcode.com/problems/count-the-repetitions

/*
466. Count The Repetitions
Hard

Define S = [s,n] as the string S which consists of n connected strings s. For example, [&quot;abc&quot;, 3] =&quot;abcabcabc&quot;. 
On the other hand, we define that string s1 can be obtained from string s2 if we can remove some characters from s2 such that it becomes s1. For example, &#x201C;abc&#x201D;  can be obtained from &#x201C;abdbec&#x201D; based on our definition, but it can not be obtained from &#x201C;acbbe&#x201D;.
You are given two non-empty strings s1 and s2 (each at most 100 characters long) and two integers 0 &#x2264; n1 &#x2264; 106 and 1 &#x2264; n2 &#x2264; 106. Now consider the strings S1 and S2, where S1=[s1,n1] and S2=[s2,n2]. Find the maximum integer M such that [S2,M] can be obtained from S1.

Example:
Input:
s1=&quot;acb&quot;, n1=4
s2=&quot;ab&quot;, n2=2

Return:
2
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution466
{
    public class Solution
    {
        public void Init() { }

        public int GetMaxRepetitions(string s1, int n1, string s2, int n2) { }
    }
}
