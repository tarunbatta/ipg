// Url:https://leetcode.com/problems/scramble-string

/*
87. Scramble String
Hard

Given a string s1, we may represent it as a binary tree by partitioning it to two non-empty substrings recursively.

Below is one possible representation of s1 = &quot;great&quot;:

    great
   /    \
  gr    eat
 / \    /  \
g   r  e   at
           / \
          a   t


To scramble the string, we may choose any non-leaf node and swap its two children.

For example, if we choose the node &quot;gr&quot; and swap its two children, it produces a scrambled string &quot;rgeat&quot;.

    rgeat
   /    \
  rg    eat
 / \    /  \
r   g  e   at
           / \
          a   t


We say that &quot;rgeat&quot; is a scrambled string of &quot;great&quot;.

Similarly, if we continue to swap the children of nodes &quot;eat&quot; and &quot;at&quot;, it produces a scrambled string &quot;rgtae&quot;.

    rgtae
   /    \
  rg    tae
 / \    /  \
r   g  ta  e
       / \
      t   a


We say that &quot;rgtae&quot; is a scrambled string of &quot;great&quot;.

Given two strings s1 and s2 of the same length, determine if s2 is a scrambled string of s1.

Example 1:

Input: s1 = &quot;great&quot;, s2 = &quot;rgeat&quot;
Output: true


Example 2:

Input: s1 = &quot;abcde&quot;, s2 = &quot;caebd&quot;
Output: false
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution87
{
    public class Solution
    {
        public void Init() { }

        public bool IsScramble(string s1, string s2) { }
    }
}
