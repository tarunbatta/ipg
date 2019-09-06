// Url:https://leetcode.com/problems/find-median-from-data-stream

/*
295. Find Median from Data Stream
Hard

Median is the middle value in an ordered integer list. If the size of the list is even, there is no middle value. So the median is the mean of the two middle value.
For example,

[2,3,4], the median is 3

[2,3], the median is (2 + 3) / 2 = 2.5

Design a data structure that supports the following two operations:


	void addNum(int num) - Add a integer number from the data stream to the data structure.
	double findMedian() - Return the median of all elements so far.


&#xA0;

Example:

addNum(1)
addNum(2)
findMedian() -&gt; 1.5
addNum(3) 
findMedian() -&gt; 2


&#xA0;

Follow up:


	If all integer numbers from the stream are between 0&#xA0;and 100, how would you optimize it?
	If 99% of all integer numbers from the stream are between 0 and 100, how would you optimize it?
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution295
{
    public class MedianFinder {​    /** initialize your data structure here. */    public MedianFinder() { } public void AddNum(int num) { } public double FindMedian() { } }​/** * Your MedianFinder object will be instantiated and called as such: * MedianFinder obj = new MedianFinder(); * obj.AddNum(num); * double param_2 = obj.FindMedian(); *
}
