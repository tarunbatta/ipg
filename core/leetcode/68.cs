// Url:https://leetcode.com/problems/text-justification

/*
68. Text Justification
Hard

Given an array of words and a width&#xA0;maxWidth, format the text such that each line has exactly maxWidth characters and is fully (left and right) justified.

You should pack your words in a greedy approach; that is, pack as many words as you can in each line. Pad extra spaces &apos; &apos; when necessary so that each line has exactly maxWidth characters.

Extra spaces between words should be distributed as evenly as possible. If the number of spaces on a line do not divide evenly between words, the empty slots on the left will be assigned more spaces than the slots on the right.

For the last line of text, it should be left justified and no extra space is inserted between words.

Note:


	A word is defined as a character sequence consisting&#xA0;of non-space characters only.
	Each word&apos;s length is&#xA0;guaranteed to be greater than 0 and not exceed maxWidth.
	The input array words&#xA0;contains at least one word.


Example 1:

Input:
words = [&quot;This&quot;, &quot;is&quot;, &quot;an&quot;, &quot;example&quot;, &quot;of&quot;, &quot;text&quot;, &quot;justification.&quot;]
maxWidth = 16
Output:
[
&#xA0; &#xA0;&quot;This &#xA0; &#xA0;is &#xA0; &#xA0;an&quot;,
&#xA0; &#xA0;&quot;example &#xA0;of text&quot;,
&#xA0; &#xA0;&quot;justification. &#xA0;&quot;
]


Example 2:

Input:
words = [&quot;What&quot;,&quot;must&quot;,&quot;be&quot;,&quot;acknowledgment&quot;,&quot;shall&quot;,&quot;be&quot;]
maxWidth = 16
Output:
[
&#xA0; &quot;What &#xA0; must &#xA0; be&quot;,
&#xA0; &quot;acknowledgment &#xA0;&quot;,
&#xA0; &quot;shall be &#xA0; &#xA0; &#xA0; &#xA0;&quot;
]
Explanation: Note that the last line is &quot;shall be    &quot; instead of &quot;shall     be&quot;,
&#xA0;            because the last line must be left-justified instead of fully-justified.
             Note that the second line is also left-justified becase it contains only one word.


Example 3:

Input:
words = [&quot;Science&quot;,&quot;is&quot;,&quot;what&quot;,&quot;we&quot;,&quot;understand&quot;,&quot;well&quot;,&quot;enough&quot;,&quot;to&quot;,&quot;explain&quot;,
&#xA0;        &quot;to&quot;,&quot;a&quot;,&quot;computer.&quot;,&quot;Art&quot;,&quot;is&quot;,&quot;everything&quot;,&quot;else&quot;,&quot;we&quot;,&quot;do&quot;]
maxWidth = 20
Output:
[
&#xA0; &quot;Science &#xA0;is &#xA0;what we&quot;,
  &quot;understand &#xA0; &#xA0; &#xA0;well&quot;,
&#xA0; &quot;enough to explain to&quot;,
&#xA0; &quot;a &#xA0;computer. &#xA0;Art is&quot;,
&#xA0; &quot;everything &#xA0;else &#xA0;we&quot;,
&#xA0; &quot;do &#xA0; &#xA0; &#xA0; &#xA0; &#xA0; &#xA0; &#xA0; &#xA0; &#xA0;&quot;
]
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution68
{
    public class Solution
    {
        public void Init() { }

        public IList<string> FullJustify(string[] words, int maxWidth) { }
    }
}
