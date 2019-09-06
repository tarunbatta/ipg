// Url:https://leetcode.com/problems/data-stream-as-disjoint-intervals

/*
352. Data Stream as Disjoint Intervals
Hard

Given a data stream input of non-negative integers a1, a2, ..., an, ..., summarize the numbers seen so far as a list of disjoint intervals.

For example, suppose the integers from the data stream are 1, 3, 7, 2, 6, ..., then the summary will be:

[1, 1]
[1, 1], [3, 3]
[1, 1], [3, 3], [7, 7]
[1, 3], [7, 7]
[1, 3], [6, 7]


&#xA0;

Follow up:

What if there are lots of merges and the number of disjoint intervals are small compared to the data stream&apos;s size?
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution352
{
    public class SummaryRanges {​    /** Initialize your data structure here. */    public SummaryRanges() { } public void AddNum(int val) { } public int[][] GetIntervals() { } }​/** * Your SummaryRanges object will be instantiated and called as such: * SummaryRanges obj = new SummaryRanges(); * obj.AddNum(val); * int[][] param_2 = obj.GetIntervals(); *
}
