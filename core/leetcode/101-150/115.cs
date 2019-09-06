// Url:https://leetcode.com/problems/distinct-subsequences

/*
115. Distinct Subsequences
Hard

Given a string S and a string T, count the number of distinct subsequences of S which equals T.

A subsequence of a string is a new string which is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (ie, &quot;ACE&quot; is a subsequence of &quot;ABCDE&quot; while &quot;AEC&quot; is not).

Example 1:

Input: S = &quot;rabbbit&quot;, T = &quot;rabbit&quot;
Output:&#xA0;3
Explanation:

As shown below, there are 3 ways you can generate &quot;rabbit&quot; from S.
(The caret symbol ^ means the chosen letters)

rabbbit
^^^^ ^^
rabbbit
^^ ^^^^
rabbbit
^^^ ^^^


Example 2:

Input: S = &quot;babgbag&quot;, T = &quot;bag&quot;
Output:&#xA0;5
Explanation:

As shown below, there are 5 ways you can generate &quot;bag&quot; from S.
(The caret symbol ^ means the chosen letters)

babgbag
^^ ^
babgbag
^^    ^
babgbag
^    ^^
babgbag
  ^  ^^
babgbag
    ^^^
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution115
{
    public class Solution
    {
        public void Init() { }

        public int NumDistinct(string s, string t) { }
    }
}
