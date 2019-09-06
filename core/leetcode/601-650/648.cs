// Url:https://leetcode.com/problems/replace-words

/*
648. Replace Words
Medium

In English, we have a concept called root, which can be followed by some other words to form another longer word - let&apos;s call this word successor. For example, the root an, followed by other, which can form another word another.

Now, given a dictionary consisting of many roots and a sentence. You need to replace all the successor in the sentence with the root forming it. If a successor has many roots can form it, replace it with the root with the shortest length.

You need to output the sentence after the replacement.

Example 1:

Input: dict = [&quot;cat&quot;, &quot;bat&quot;, &quot;rat&quot;]
sentence = &quot;the cattle was rattled by the battery&quot;
Output: &quot;the cat was rat by the bat&quot;


&#xA0;

Note:


	The input will only have lower-case letters.
	1 &lt;= dict words number &lt;= 1000
	1 &lt;= sentence words number &lt;= 1000
	1 &lt;= root length &lt;= 100
	1 &lt;= sentence words length &lt;= 1000


&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution648
{
    public class Solution
    {
        public void Init() { }

        public string ReplaceWords(IList<string> dict, string sentence) { }
    }
}
