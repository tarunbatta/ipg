// Url:https://leetcode.com/problems/accounts-merge

/*
721. Accounts Merge
Medium

Given a list accounts, each element accounts[i] is a list of strings, where the first element accounts[i][0] is a name, and the rest of the elements are emails representing emails of the account.

Now, we would like to merge these accounts.  Two accounts definitely belong to the same person if there is some email that is common to both accounts.  Note that even if two accounts have the same name, they may belong to different people as people could have the same name.  A person can have any number of accounts initially, but all of their accounts definitely have the same name.

After merging the accounts, return the accounts in the following format: the first element of each account is the name, and the rest of the elements are emails in sorted order.  The accounts themselves can be returned in any order.

Example 1:
Input: 
accounts = [[&quot;John&quot;, &quot;johnsmith@mail.com&quot;, &quot;john00@mail.com&quot;], [&quot;John&quot;, &quot;johnnybravo@mail.com&quot;], [&quot;John&quot;, &quot;johnsmith@mail.com&quot;, &quot;john_newyork@mail.com&quot;], [&quot;Mary&quot;, &quot;mary@mail.com&quot;]]
Output: [[&quot;John&quot;, &apos;john00@mail.com&apos;, &apos;john_newyork@mail.com&apos;, &apos;johnsmith@mail.com&apos;],  [&quot;John&quot;, &quot;johnnybravo@mail.com&quot;], [&quot;Mary&quot;, &quot;mary@mail.com&quot;]]
Explanation: 
The first and third John&apos;s are the same person as they have the common email &quot;johnsmith@mail.com&quot;.
The second John and Mary are different people as none of their email addresses are used by other accounts.
We could return these lists in any order, for example the answer [[&apos;Mary&apos;, &apos;mary@mail.com&apos;], [&apos;John&apos;, &apos;johnnybravo@mail.com&apos;], 
[&apos;John&apos;, &apos;john00@mail.com&apos;, &apos;john_newyork@mail.com&apos;, &apos;johnsmith@mail.com&apos;]] would still be accepted.



Note:
The length of accounts will be in the range [1, 1000].
The length of accounts[i] will be in the range [1, 10].
The length of accounts[i][j] will be in the range [1, 30].
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution721
{
    public class Solution
    {
        public void Init() { }

        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts) { }
    }
}
