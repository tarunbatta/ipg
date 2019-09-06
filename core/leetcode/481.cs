// Url:https://leetcode.com/problems/magical-string

/*
481. Magical String
Medium

A magical string S consists of only &apos;1&apos; and &apos;2&apos; and obeys the following rules:


The string S is magical because concatenating the number of contiguous occurrences of characters &apos;1&apos; and &apos;2&apos; generates the string S itself.



The first few elements of string S is the following:
S = &quot;1221121221221121122&#x2026;&#x2026;&quot;



If we group the consecutive &apos;1&apos;s and &apos;2&apos;s in S, it will be:


1   22  11  2  1  22  1  22  11  2  11  22 ......


and the occurrences of &apos;1&apos;s or &apos;2&apos;s in each group are:


1   2	   2    1   1    2     1    2     2    1    2    2 ......



You can see that the occurrence sequence above is the S itself. 



Given an integer N as input, return the number of &apos;1&apos;s in the first N number in the magical string S.


Note:
N will not exceed 100,000.



Example 1:
Input: 6
Output: 3
Explanation: The first 6 elements of magical string S is &quot;12211&quot; and it contains three 1&apos;s, so return 3.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution481
{
    public class Solution
    {
        public void Init() { }

        public int MagicalString(int n) { }
    }
}
