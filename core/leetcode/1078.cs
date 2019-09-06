// Url:https://leetcode.com/problems/occurrences-after-bigram

/*
1078. Occurrences After Bigram
Easy

Given words first and second, consider occurrences in some&#xA0;text of the form &quot;first second third&quot;, where second comes immediately after first, and third comes immediately after second.

For each such occurrence, add &quot;third&quot; to the answer, and return the answer.

&#xA0;

Example 1:

Input: text = &quot;alice is a good girl she is a good student&quot;, first = &quot;a&quot;, second = &quot;good&quot;
Output: [&quot;girl&quot;,&quot;student&quot;]



Example 2:

Input: text = &quot;we will we will rock you&quot;, first = &quot;we&quot;, second = &quot;will&quot;
Output: [&quot;we&quot;,&quot;rock&quot;]


&#xA0;

Note:


	1 &lt;= text.length &lt;= 1000
	text consists of space separated words, where each word consists of lowercase English letters.
	1 &lt;= first.length, second.length &lt;= 10
	first and second consist of lowercase English letters.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1078
{
    public class Solution
    {
        public void Init() { }

        public string[] FindOcurrences(string text, string first, string second) { }
    }
}
