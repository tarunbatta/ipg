// Url:https://leetcode.com/problems/top-k-frequent-words

/*
692. Top K Frequent Words
Medium

Given a non-empty list of words, return the k most frequent elements.
Your answer should be sorted by frequency from highest to lowest. If two words have the same frequency, then the word with the lower alphabetical order comes first.

Example 1:
Input: [&quot;i&quot;, &quot;love&quot;, &quot;leetcode&quot;, &quot;i&quot;, &quot;love&quot;, &quot;coding&quot;], k = 2
Output: [&quot;i&quot;, &quot;love&quot;]
Explanation: &quot;i&quot; and &quot;love&quot; are the two most frequent words.
    Note that &quot;i&quot; comes before &quot;love&quot; due to a lower alphabetical order.



Example 2:
Input: [&quot;the&quot;, &quot;day&quot;, &quot;is&quot;, &quot;sunny&quot;, &quot;the&quot;, &quot;the&quot;, &quot;the&quot;, &quot;sunny&quot;, &quot;is&quot;, &quot;is&quot;], k = 4
Output: [&quot;the&quot;, &quot;is&quot;, &quot;sunny&quot;, &quot;day&quot;]
Explanation: &quot;the&quot;, &quot;is&quot;, &quot;sunny&quot; and &quot;day&quot; are the four most frequent words,
    with the number of occurrence being 4, 3, 2 and 1 respectively.



Note:

You may assume k is always valid, 1 &#x2264; k &#x2264; number of unique elements.
Input words contain only lowercase letters.



Follow up:

Try to solve it in O(n log k) time and O(n) extra space.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution692
{
    public class Solution
    {
        public void Init() { }

        public IList<string> TopKFrequent(string[] words, int k) { }
    }
}
