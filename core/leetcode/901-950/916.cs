// Url:https://leetcode.com/problems/word-subsets

/*
916. Word Subsets
Medium

We are given two arrays A and B of words.&#xA0; Each word is a string of lowercase letters.

Now, say that&#xA0;word b is a subset of word a&#xA0;if every letter in b occurs in a, including multiplicity.&#xA0; For example, &quot;wrr&quot; is a subset of &quot;warrior&quot;, but is not a subset of &quot;world&quot;.

Now say a word a from A is universal if for every b in B, b&#xA0;is a subset of a.&#xA0;

Return a list of all universal words in A.&#xA0; You can return the words in any order.

&#xA0;





Example 1:

Input: A = [&quot;amazon&quot;,&quot;apple&quot;,&quot;facebook&quot;,&quot;google&quot;,&quot;leetcode&quot;], B = [&quot;e&quot;,&quot;o&quot;]
Output: [&quot;facebook&quot;,&quot;google&quot;,&quot;leetcode&quot;]



Example 2:

Input: A = [&quot;amazon&quot;,&quot;apple&quot;,&quot;facebook&quot;,&quot;google&quot;,&quot;leetcode&quot;], B = [&quot;l&quot;,&quot;e&quot;]
Output: [&quot;apple&quot;,&quot;google&quot;,&quot;leetcode&quot;]



Example 3:

Input: A = [&quot;amazon&quot;,&quot;apple&quot;,&quot;facebook&quot;,&quot;google&quot;,&quot;leetcode&quot;], B = [&quot;e&quot;,&quot;oo&quot;]
Output: [&quot;facebook&quot;,&quot;google&quot;]



Example 4:

Input: A = [&quot;amazon&quot;,&quot;apple&quot;,&quot;facebook&quot;,&quot;google&quot;,&quot;leetcode&quot;], B = [&quot;lo&quot;,&quot;eo&quot;]
Output: [&quot;google&quot;,&quot;leetcode&quot;]



Example 5:

Input: A = [&quot;amazon&quot;,&quot;apple&quot;,&quot;facebook&quot;,&quot;google&quot;,&quot;leetcode&quot;], B = [&quot;ec&quot;,&quot;oc&quot;,&quot;ceo&quot;]
Output: [&quot;facebook&quot;,&quot;leetcode&quot;]


&#xA0;

Note:


	1 &lt;= A.length, B.length &lt;= 10000
	1 &lt;= A[i].length, B[i].length&#xA0;&lt;= 10
	A[i] and B[i] consist only of lowercase letters.
	All words in A[i] are unique: there isn&apos;t i != j with A[i] == A[j].
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution916
{
    public class Solution
    {
        public void Init() { }

        public IList<string> WordSubsets(string[] A, string[] B) { }
    }
}
