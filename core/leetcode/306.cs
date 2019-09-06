// Url:https://leetcode.com/problems/additive-number

/*
306. Additive Number
Medium

Additive number is a string whose digits can form additive sequence.

A valid additive sequence should contain at least three numbers. Except for the first two numbers, each subsequent number in the sequence must be the sum of the preceding two.

Given a string containing only digits &apos;0&apos;-&apos;9&apos;, write a function to determine if it&apos;s an additive number.

Note: Numbers in the additive sequence cannot have leading zeros, so sequence 1, 2, 03 or 1, 02, 3 is invalid.

Example 1:

Input: &quot;112358&quot;
Output: true 
Explanation: The digits can form an additive sequence: 1, 1, 2, 3, 5, 8. 
&#xA0;            1 + 1 = 2, 1 + 2 = 3, 2 + 3 = 5, 3 + 5 = 8


Example 2:

Input: &quot;199100199&quot;
Output: true 
Explanation: The additive sequence is: 1, 99, 100, 199.&#xA0;
&#xA0;            1 + 99 = 100, 99 + 100 = 199

Follow up:
How would you handle overflow for very large input integers?
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution306
{
    public class Solution
    {
        public void Init() { }

        public bool IsAdditiveNumber(string num) { }
    }
}
