// Url:https://leetcode.com/problems/word-ladder

/*
127. Word Ladder
Medium

Given two words (beginWord and endWord), and a dictionary&apos;s word list, find the length of shortest transformation sequence from beginWord to endWord, such that:


	Only one letter can be changed at a time.
	Each transformed word must exist in the word list. Note that beginWord is not a transformed word.


Note:


	Return 0 if there is no such transformation sequence.
	All words have the same length.
	All words contain only lowercase alphabetic characters.
	You may assume no duplicates in the word list.
	You may assume beginWord and endWord are non-empty and are not the same.


Example 1:

Input:
beginWord = &quot;hit&quot;,
endWord = &quot;cog&quot;,
wordList = [&quot;hot&quot;,&quot;dot&quot;,&quot;dog&quot;,&quot;lot&quot;,&quot;log&quot;,&quot;cog&quot;]

Output: 5

Explanation: As one shortest transformation is &quot;hit&quot; -&gt; &quot;hot&quot; -&gt; &quot;dot&quot; -&gt; &quot;dog&quot; -&gt; &quot;cog&quot;,
return its length 5.


Example 2:

Input:
beginWord = &quot;hit&quot;
endWord = &quot;cog&quot;
wordList = [&quot;hot&quot;,&quot;dot&quot;,&quot;dog&quot;,&quot;lot&quot;,&quot;log&quot;]

Output:&#xA0;0

Explanation:&#xA0;The endWord &quot;cog&quot; is not in wordList, therefore no possible&#xA0;transformation.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution127
{
    public class Solution
    {
        public void Init() { }

        public int LadderLength(string beginWord, string endWord, IList<string> wordList) { }
    }
}
