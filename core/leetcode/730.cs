// Url:https://leetcode.com/problems/count-different-palindromic-subsequences

/*
730. Count Different Palindromic Subsequences
Hard

Given a string S, find the number of different non-empty palindromic subsequences in S, and return that number modulo 10^9 + 7.

A subsequence of a string S is obtained by deleting 0 or more characters from S.

A sequence is palindromic if it is equal to the sequence reversed.

Two sequences A_1, A_2, ... and B_1, B_2, ... are different if there is some i for which A_i != B_i.


Example 1:
Input: 
S = &apos;bccb&apos;
Output: 6
Explanation: 
The 6 different non-empty palindromic subsequences are &apos;b&apos;, &apos;c&apos;, &apos;bb&apos;, &apos;cc&apos;, &apos;bcb&apos;, &apos;bccb&apos;.
Note that &apos;bcb&apos; is counted only once, even though it occurs twice.



Example 2:
Input: 
S = &apos;abcdabcdabcdabcdabcdabcdabcdabcddcbadcbadcbadcbadcbadcbadcbadcba&apos;
Output: 104860361
Explanation: 
There are 3104860382 different non-empty palindromic subsequences, which is 104860361 modulo 10^9 + 7.



Note:
The length of S will be in the range [1, 1000].
Each character S[i] will be in the set {&apos;a&apos;, &apos;b&apos;, &apos;c&apos;, &apos;d&apos;}.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution730
{
    public class Solution
    {
        public void Init() { }

        public int CountPalindromicSubsequences(string S) { }
    }
}
