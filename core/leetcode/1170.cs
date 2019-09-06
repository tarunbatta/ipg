// Url:https://leetcode.com/problems/compare-strings-by-frequency-of-the-smallest-character

/*
1170. Compare Strings by Frequency of the Smallest Character
Easy

Let&apos;s define a function f(s) over a non-empty string s, which calculates the frequency of the smallest character in s. For example,&#xA0;if s = &quot;dcce&quot; then f(s) = 2 because the smallest character is &quot;c&quot; and its frequency is 2.

Now, given string arrays queries&#xA0;and words, return an integer array answer, where each answer[i]&#xA0;is the number of words such that f(queries[i])&#xA0;&lt; f(W), where W&#xA0;is a word in words.

&#xA0;
Example 1:

Input: queries = [&quot;cbd&quot;], words = [&quot;zaaaz&quot;]
Output: [1]
Explanation: On the first query we have f(&quot;cbd&quot;) = 1, f(&quot;zaaaz&quot;) = 3 so f(&quot;cbd&quot;) &lt; f(&quot;zaaaz&quot;).


Example 2:

Input: queries = [&quot;bbb&quot;,&quot;cc&quot;], words = [&quot;a&quot;,&quot;aa&quot;,&quot;aaa&quot;,&quot;aaaa&quot;]
Output: [1,2]
Explanation: On the first query only f(&quot;bbb&quot;) &lt; f(&quot;aaaa&quot;). On the second query both f(&quot;aaa&quot;) and f(&quot;aaaa&quot;) are both &gt; f(&quot;cc&quot;).


&#xA0;
Constraints:


	1 &lt;= queries.length &lt;= 2000
	1 &lt;= words.length &lt;= 2000
	1 &lt;= queries[i].length, words[i].length &lt;= 10
	queries[i][j], words[i][j] are English lowercase letters.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1170
{
    public class Solution
    {
        public void Init() { }

        public int[] NumSmallerByFrequency(string[] queries, string[] words) { }
    }
}
