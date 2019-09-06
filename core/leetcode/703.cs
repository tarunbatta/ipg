// Url:https://leetcode.com/problems/kth-largest-element-in-a-stream

/*
703. Kth Largest Element in a Stream
Easy

Design a class to find&#xA0;the kth largest element in a stream. Note that it is the kth largest element in the sorted order, not the kth distinct element.

Your&#xA0;KthLargest&#xA0;class will have a constructor which accepts an integer k and an integer array nums, which contains initial elements from&#xA0;the stream. For each call to the method KthLargest.add, return the element representing the kth largest element in the stream.

Example:

int k = 3;
int[] arr = [4,5,8,2];
KthLargest kthLargest = new KthLargest(3, arr);
kthLargest.add(3);&#xA0; &#xA0;// returns 4
kthLargest.add(5);&#xA0; &#xA0;// returns 5
kthLargest.add(10);&#xA0; // returns 5
kthLargest.add(9);&#xA0; &#xA0;// returns 8
kthLargest.add(4);&#xA0; &#xA0;// returns 8


Note: 
You may assume that&#xA0;nums&apos; length&#xA0;&#x2265;&#xA0;k-1&#xA0;and k &#x2265;&#xA0;1.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution703
{
    public class KthLargest {​    public KthLargest(int k, int[] nums) { } public int Add(int val) { } }​/** * Your KthLargest object will be instantiated and called as such: * KthLargest obj = new KthLargest(k, nums); * int param_1 = obj.Add(val); *
}
