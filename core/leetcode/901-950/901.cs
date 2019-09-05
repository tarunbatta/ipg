// Url:https://leetcode.com/problems/online-stock-span

/*
901. Online Stock Span
Medium

Write a class StockSpanner which collects daily price quotes for some stock, and returns the span&#xA0;of that stock&apos;s price for the current day.

The span of the stock&apos;s price today&#xA0;is defined as the maximum number of consecutive days (starting from today and going backwards)&#xA0;for which the price of the stock was less than or equal to today&apos;s price.

For example, if the price of a stock over the next 7 days were [100, 80, 60, 70, 60, 75, 85], then the stock spans would be [1, 1, 1, 2, 1, 4, 6].

&#xA0;


Example 1:

Input: [&quot;StockSpanner&quot;,&quot;next&quot;,&quot;next&quot;,&quot;next&quot;,&quot;next&quot;,&quot;next&quot;,&quot;next&quot;,&quot;next&quot;], [[],[100],[80],[60],[70],[60],[75],[85]]
Output: [null,1,1,1,2,1,4,6]
Explanation: 
First, S = StockSpanner() is initialized.  Then:
S.next(100) is called and returns 1,
S.next(80) is called and returns 1,
S.next(60) is called and returns 1,
S.next(70) is called and returns 2,
S.next(60) is called and returns 1,
S.next(75) is called and returns 4,
S.next(85) is called and returns 6.

Note that (for example) S.next(75) returned 4, because the last 4 prices
(including today&apos;s price of 75) were less than or equal to today&apos;s price.


&#xA0;

Note:


	Calls to StockSpanner.next(int price) will have 1 &lt;= price &lt;= 10^5.
	There will be at most 10000 calls to StockSpanner.next&#xA0;per test case.
	There will be at most 150000 calls to StockSpanner.next across all test cases.
	The total&#xA0;time limit for this problem has been reduced by 75% for&#xA0;C++, and 50% for all other languages.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution901
{
    public class StockSpanner {​    public StockSpanner() { } public int Next(int price) { } }​/** * Your StockSpanner object will be instantiated and called as such: * StockSpanner obj = new StockSpanner(); * int param_1 = obj.Next(price); *
}
