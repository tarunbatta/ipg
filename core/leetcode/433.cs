// Url:https://leetcode.com/problems/minimum-genetic-mutation

/*
433. Minimum Genetic Mutation
Medium

A gene string can be represented by an 8-character long string, with choices from &quot;A&quot;, &quot;C&quot;, &quot;G&quot;, &quot;T&quot;.

Suppose we need to investigate about a mutation (mutation from &quot;start&quot; to &quot;end&quot;), where ONE mutation is defined as ONE single character changed in the gene string.

For example, &quot;AACCGGTT&quot; -&gt; &quot;AACCGGTA&quot; is 1 mutation.

Also, there is a given gene &quot;bank&quot;, which records all the valid gene mutations. A gene must be in the bank to make it a valid gene string.

Now, given 3 things - start, end, bank, your task is to determine what is the minimum number of mutations needed to mutate from &quot;start&quot; to &quot;end&quot;. If there is no such a mutation, return -1.

Note:


	Starting point is assumed to be valid, so it might not be included in the bank.
	If multiple mutations are needed, all mutations during in the sequence must be valid.
	You may assume start and end string is not the same.


&#xA0;

Example 1:

start: &quot;AACCGGTT&quot;
end:   &quot;AACCGGTA&quot;
bank: [&quot;AACCGGTA&quot;]

return: 1


&#xA0;

Example 2:

start: &quot;AACCGGTT&quot;
end:   &quot;AAACGGTA&quot;
bank: [&quot;AACCGGTA&quot;, &quot;AACCGCTA&quot;, &quot;AAACGGTA&quot;]

return: 2


&#xA0;

Example 3:

start: &quot;AAAAACCC&quot;
end:   &quot;AACCCCCC&quot;
bank: [&quot;AAAACCCC&quot;, &quot;AAACCCCC&quot;, &quot;AACCCCCC&quot;]

return: 3


&#xA0;
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution433
{
    public class Solution
    {
        public void Init() { }

        public int MinMutation(string start, string end, string[] bank) { }
    }
}
