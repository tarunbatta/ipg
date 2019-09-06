// Url:https://leetcode.com/problems/word-ladder-ii

/*
126. Word Ladder II
Hard

Given two words (beginWord and endWord), and a dictionary&apos;s word list, find all shortest transformation sequence(s) from beginWord to endWord, such that:


	Only one letter can be changed at a time
	Each transformed word must exist in the word list. Note that beginWord is not a transformed word.


Note:


	Return an empty list if there is no such transformation sequence.
	All words have the same length.
	All words contain only lowercase alphabetic characters.
	You may assume no duplicates in the word list.
	You may assume beginWord and endWord are non-empty and are not the same.


Example 1:

Input:
beginWord = &quot;hit&quot;,
endWord = &quot;cog&quot;,
wordList = [&quot;hot&quot;,&quot;dot&quot;,&quot;dog&quot;,&quot;lot&quot;,&quot;log&quot;,&quot;cog&quot;]

Output:
[
  [&quot;hit&quot;,&quot;hot&quot;,&quot;dot&quot;,&quot;dog&quot;,&quot;cog&quot;],
&#xA0; [&quot;hit&quot;,&quot;hot&quot;,&quot;lot&quot;,&quot;log&quot;,&quot;cog&quot;]
]


Example 2:

Input:
beginWord = &quot;hit&quot;
endWord = &quot;cog&quot;
wordList = [&quot;hot&quot;,&quot;dot&quot;,&quot;dog&quot;,&quot;lot&quot;,&quot;log&quot;]

Output: []

Explanation:&#xA0;The endWord &quot;cog&quot; is not in wordList, therefore no possible&#xA0;transformation.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution126
{
    public class Solution
    {
        public void Init() { }

        public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList) { }
    }
}
