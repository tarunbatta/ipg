// Url:https://leetcode.com/problems/number-of-lines-to-write-string

/*
806. Number of Lines To Write String
Easy

We are to write the letters of a given string S, from left to right into lines. Each line has maximum width 100 units, and if writing a letter would cause the width of the line to exceed 100 units, it is written on the next line. We are given an array&#xA0;widths, an array where widths[0] is the width of &apos;a&apos;, widths[1] is the width of &apos;b&apos;, ..., and widths[25] is the width of &apos;z&apos;.

Now answer two questions: how many lines have at least one character from S, and what is the width used by the last such line? Return your answer as an integer list of length 2.

&#xA0;

Example :
Input: 
widths = [10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10]
S = &quot;abcdefghijklmnopqrstuvwxyz&quot;
Output: [3, 60]
Explanation: 
All letters have the same length of 10. To write all 26 letters,
we need two full lines and one line with 60 units.


Example :
Input: 
widths = [4,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10]
S = &quot;bbbcccdddaaa&quot;
Output: [2, 4]
Explanation: 
All letters except &apos;a&apos; have the same length of 10, and 
&quot;bbbcccdddaa&quot; will cover 9 * 10 + 2 * 4 = 98 units.
For the last &apos;a&apos;, it is written on the second line because
there is only 2 units left in the first line.
So the answer is 2 lines, plus 4 units in the second line.


&#xA0;

Note:


	The length of S will be in the range&#xA0;[1, 1000].
	S will only contain lowercase letters.
	widths is&#xA0;an array of length 26.
	widths[i] will be in the range of [2, 10].
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution806
{
    public class Solution
    {
        public void Init() { }

        public int[] NumberOfLines(int[] widths, string S) { }
    }
}
