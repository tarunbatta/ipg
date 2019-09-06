// Url:https://leetcode.com/problems/concatenated-words

/*
472. Concatenated Words
Hard

Given a list of words (without duplicates), please write a program that returns all concatenated words in the given list of words.
A concatenated word is defined as a string that is comprised entirely of at least two shorter words in the given array.

Example:
Input: [&quot;cat&quot;,&quot;cats&quot;,&quot;catsdogcats&quot;,&quot;dog&quot;,&quot;dogcatsdog&quot;,&quot;hippopotamuses&quot;,&quot;rat&quot;,&quot;ratcatdogcat&quot;]

Output: [&quot;catsdogcats&quot;,&quot;dogcatsdog&quot;,&quot;ratcatdogcat&quot;]

Explanation: &quot;catsdogcats&quot; can be concatenated by &quot;cats&quot;, &quot;dog&quot; and &quot;cats&quot;;  &quot;dogcatsdog&quot; can be concatenated by &quot;dog&quot;, &quot;cats&quot; and &quot;dog&quot;; &quot;ratcatdogcat&quot; can be concatenated by &quot;rat&quot;, &quot;cat&quot;, &quot;dog&quot; and &quot;cat&quot;.



Note:

The number of elements of the given array will not exceed 10,000 
The length sum of elements in the given array will not exceed 600,000. 
All the input string will only include lower case letters.
The returned elements order does not matter.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution472
{
    public class Solution
    {
        public void Init() { }

        public IList<string> FindAllConcatenatedWordsInADict(string[] words) { }
    }
}
