// Url:https://leetcode.com/problems/shifting-letters

/*
848. Shifting Letters
Medium

We have a string S of lowercase letters, and an integer array shifts.

Call the shift of a letter, the next letter in the alphabet, (wrapping around so that &apos;z&apos; becomes &apos;a&apos;).&#xA0;

For example, shift(&apos;a&apos;) = &apos;b&apos;, shift(&apos;t&apos;) = &apos;u&apos;, and shift(&apos;z&apos;) = &apos;a&apos;.

Now for each shifts[i] = x, we want to shift the first i+1&#xA0;letters of S, x times.

Return the final string&#xA0;after all such shifts to S are applied.

Example 1:

Input: S = &quot;abc&quot;, shifts = [3,5,9]
Output: &quot;rpl&quot;
Explanation: 
We start with &quot;abc&quot;.
After shifting the first 1 letters of S by 3, we have &quot;dbc&quot;.
After shifting the first 2 letters of S by 5, we have &quot;igc&quot;.
After shifting the first 3 letters of S by 9, we have &quot;rpl&quot;, the answer.


Note:


	1 &lt;= S.length = shifts.length &lt;= 20000
	0 &lt;= shifts[i] &lt;= 10 ^ 9
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution848
{
    public class Solution
    {
        public void Init() { }

        public string ShiftingLetters(string S, int[] shifts) { }
    }
}
