// Url:https://leetcode.com/problems/similar-string-groups

/*
839. Similar String Groups
Hard

Two strings X&#xA0;and Y&#xA0;are similar if we can swap two letters (in different positions) of X, so that&#xA0;it equals Y.

For example, &quot;tars&quot;&#xA0;and &quot;rats&quot;&#xA0;are similar (swapping at positions 0 and 2), and &quot;rats&quot; and &quot;arts&quot; are similar, but &quot;star&quot; is not similar to &quot;tars&quot;, &quot;rats&quot;, or &quot;arts&quot;.

Together, these form two connected groups by similarity: {&quot;tars&quot;, &quot;rats&quot;, &quot;arts&quot;} and {&quot;star&quot;}.&#xA0; Notice that &quot;tars&quot; and &quot;arts&quot; are in the same group even though they are not similar.&#xA0; Formally, each group is such that a word is in the group if and only if it is similar to at least one other word in the group.

We are given a list A of strings.&#xA0; Every string in A is an anagram of every other string in A.&#xA0; How many groups are there?

Example 1:

Input: [&quot;tars&quot;,&quot;rats&quot;,&quot;arts&quot;,&quot;star&quot;]
Output: 2

Note:


	A.length &lt;= 2000
	A[i].length &lt;= 1000
	A.length * A[i].length &lt;= 20000
	All words in A&#xA0;consist of lowercase letters only.
	All words in A have the same length and are anagrams of each other.
	The judging time limit has been increased for this question.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution839
{
    public class Solution
    {
        public void Init() { }

        public int NumSimilarGroups(string[] A) { }
    }
}
