// Url:https://leetcode.com/problems/invalid-transactions

/*
1169. Invalid Transactions
Medium

A transaction is possibly invalid if:


	the amount exceeds $1000, or;
	if it occurs within (and including) 60 minutes of another transaction with the same name in a different city.


Each transaction string transactions[i]&#xA0;consists of&#xA0;comma separated values representing&#xA0;the name, time (in minutes), amount, and city of the transaction.

Given a list of transactions,&#xA0;return a list of transactions that are possibly invalid.&#xA0; You may return the answer in any order.

&#xA0;
Example 1:

Input: transactions = [&quot;alice,20,800,mtv&quot;,&quot;alice,50,100,beijing&quot;]
Output: [&quot;alice,20,800,mtv&quot;,&quot;alice,50,100,beijing&quot;]
Explanation: The first transaction is invalid because the second transaction occurs within a difference of 60 minutes, have the same name and is in a different city. Similarly the second one is invalid too.

Example 2:

Input: transactions = [&quot;alice,20,800,mtv&quot;,&quot;alice,50,1200,mtv&quot;]
Output: [&quot;alice,50,1200,mtv&quot;]


Example 3:

Input: transactions = [&quot;alice,20,800,mtv&quot;,&quot;bob,50,1200,mtv&quot;]
Output: [&quot;bob,50,1200,mtv&quot;]


&#xA0;
Constraints:


	transactions.length &lt;= 1000
	Each transactions[i] takes the form &quot;{name},{time},{amount},{city}&quot;
	Each {name} and {city}&#xA0;consist of&#xA0;lowercase English letters, and have lengths between 1 and 10.
	Each {time} consist of&#xA0;digits, and represent an integer between 0 and 1000.
	Each {amount}&#xA0;consist of&#xA0;digits, and represent an integer between 0 and 2000.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1169
{
    public class Solution
    {
        public void Init() { }

        public IList<string> InvalidTransactions(string[] transactions) { }
    }
}
