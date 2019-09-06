// Url:https://leetcode.com/problems/reorder-data-in-log-files

/*
937. Reorder Data in Log Files
Easy

You have an array of logs.&#xA0; Each log is a space delimited string of words.

For each log, the first word in each log is an alphanumeric identifier.&#xA0; Then, either:


	Each word after the identifier will consist only of lowercase letters, or;
	Each word after the identifier will consist only of digits.


We will call these two varieties of logs letter-logs and digit-logs.&#xA0; It is guaranteed that each log has at least one word after its identifier.

Reorder the logs so that all of the letter-logs come before any digit-log.&#xA0; The letter-logs are ordered lexicographically ignoring identifier, with the identifier used in case of ties.&#xA0; The digit-logs should be put in their original order.

Return the final order of the logs.

&#xA0;
Example 1:
Input: logs = [&quot;dig1 8 1 5 1&quot;,&quot;let1 art can&quot;,&quot;dig2 3 6&quot;,&quot;let2 own kit dig&quot;,&quot;let3 art zero&quot;]
Output: [&quot;let1 art can&quot;,&quot;let3 art zero&quot;,&quot;let2 own kit dig&quot;,&quot;dig1 8 1 5 1&quot;,&quot;dig2 3 6&quot;]

&#xA0;
Constraints:


	0 &lt;= logs.length &lt;= 100
	3 &lt;= logs[i].length &lt;= 100
	logs[i] is guaranteed to have an identifier, and a word after the identifier.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution937
{
    public class Solution
    {
        public void Init() { }

        public string[] ReorderLogFiles(string[] logs) { }
    }
}
