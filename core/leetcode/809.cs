// Url:https://leetcode.com/problems/expressive-words

/*
809. Expressive Words
Medium

Sometimes people repeat letters to represent extra feeling, such as &quot;hello&quot; -&gt; &quot;heeellooo&quot;, &quot;hi&quot; -&gt; &quot;hiiii&quot;.&#xA0; In these strings like &quot;heeellooo&quot;, we have groups of adjacent letters that are all the same:&#xA0; &quot;h&quot;, &quot;eee&quot;, &quot;ll&quot;, &quot;ooo&quot;.

For some given string S, a query word is stretchy if it can be made to be equal to S by any&#xA0;number of&#xA0;applications of the following extension operation: choose a group consisting of&#xA0;characters c, and add some number of characters c to the group so that the size of the group is 3 or more.

For example, starting with &quot;hello&quot;, we could do an extension on the group &quot;o&quot; to get &quot;hellooo&quot;, but we cannot get &quot;helloo&quot; since the group &quot;oo&quot; has size less than 3.&#xA0; Also, we could do another extension like &quot;ll&quot; -&gt; &quot;lllll&quot; to get &quot;helllllooo&quot;.&#xA0; If S = &quot;helllllooo&quot;, then the query word &quot;hello&quot; would be stretchy because of these two extension operations:&#xA0;query = &quot;hello&quot; -&gt; &quot;hellooo&quot; -&gt;&#xA0;&quot;helllllooo&quot; = S.

Given a list of query words, return the number of words that are stretchy.&#xA0;

&#xA0;

Example:
Input: 
S = &quot;heeellooo&quot;
words = [&quot;hello&quot;, &quot;hi&quot;, &quot;helo&quot;]
Output: 1
Explanation: 
We can extend &quot;e&quot; and &quot;o&quot; in the word &quot;hello&quot; to get &quot;heeellooo&quot;.
We can&apos;t extend &quot;helo&quot; to get &quot;heeellooo&quot; because the group &quot;ll&quot; is not size 3 or more.


&#xA0;

Notes: 


	0 &lt;= len(S) &lt;= 100.
	0 &lt;= len(words) &lt;= 100.
	0 &lt;= len(words[i]) &lt;= 100.
	S and all words in words&#xA0;consist only of&#xA0;lowercase letters


&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution809
{
    public class Solution
    {
        public void Init() { }

        public int ExpressiveWords(string S, string[] words) { }
    }
}
