// Url:https://leetcode.com/problems/stream-of-characters

/*
1032. Stream of Characters
Hard

Implement the StreamChecker class as follows:


	StreamChecker(words): Constructor, init the data structure with the given words.
	query(letter): returns true if and only if for some k &gt;= 1, the last k&#xA0;characters queried (in order from oldest to newest, including this letter just queried) spell one of the words in the given list.


&#xA0;

Example:

StreamChecker streamChecker = new StreamChecker([&quot;cd&quot;,&quot;f&quot;,&quot;kl&quot;]); // init the dictionary.
streamChecker.query(&apos;a&apos;);          // return false
streamChecker.query(&apos;b&apos;);          // return false
streamChecker.query(&apos;c&apos;);          // return false
streamChecker.query(&apos;d&apos;);          // return true, because &apos;cd&apos; is in the wordlist
streamChecker.query(&apos;e&apos;);          // return false
streamChecker.query(&apos;f&apos;);          // return true, because &apos;f&apos; is in the wordlist
streamChecker.query(&apos;g&apos;);          // return false
streamChecker.query(&apos;h&apos;);          // return false
streamChecker.query(&apos;i&apos;);          // return false
streamChecker.query(&apos;j&apos;);          // return false
streamChecker.query(&apos;k&apos;);          // return false
streamChecker.query(&apos;l&apos;);          // return true, because &apos;kl&apos; is in the wordlist


&#xA0;

Note:


	1 &lt;= words.length &lt;= 2000
	1 &lt;= words[i].length &lt;= 2000
	Words will only consist of lowercase English letters.
	Queries will only consist of lowercase English letters.
	The number of queries is at most&#xA0;40000.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1032
{
    public class StreamChecker {​    public StreamChecker(string[] words) { } public bool Query(char letter) { } }​/** * Your StreamChecker object will be instantiated and called as such: * StreamChecker obj = new StreamChecker(words); * bool param_1 = obj.Query(letter); *
}
