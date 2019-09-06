// Url:https://leetcode.com/problems/snapshot-array

/*
1146. Snapshot Array
Medium

Implement a SnapshotArray that supports the following interface:


	SnapshotArray(int length) initializes an array-like data structure with the given length.&#xA0; Initially, each element equals 0.
	void set(index, val) sets the element at the given index to be equal to val.
	int snap()&#xA0;takes a snapshot of the array and returns the snap_id: the total number of times we called snap() minus 1.
	int get(index, snap_id)&#xA0;returns the value at the given index, at the time we took the snapshot with the given snap_id


&#xA0;
Example 1:

Input: [&quot;SnapshotArray&quot;,&quot;set&quot;,&quot;snap&quot;,&quot;set&quot;,&quot;get&quot;]
[[3],[0,5],[],[0,6],[0,0]]
Output: [null,null,0,null,5]
Explanation: 
SnapshotArray snapshotArr = new SnapshotArray(3); // set the length to be 3
snapshotArr.set(0,5);  // Set array[0] = 5
snapshotArr.snap();  // Take a snapshot, return snap_id = 0
snapshotArr.set(0,6);
snapshotArr.get(0,0);  // Get the value of array[0] with snap_id = 0, return 5

&#xA0;
Constraints:


	1 &lt;= length&#xA0;&lt;= 50000
	At most 50000&#xA0;calls will be made to set, snap, and get.
	0 &lt;= index&#xA0;&lt;&#xA0;length
	0 &lt;=&#xA0;snap_id &lt;&#xA0;(the total number of times we call snap())
	0 &lt;=&#xA0;val &lt;= 10^9
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1146
{
    public class SnapshotArray {​    public SnapshotArray(int length) { } public void Set(int index, int val) { } public int Snap() { } public int Get(int index, int snap_id) { } }​/** * Your SnapshotArray object will be instantiated and called as such: * SnapshotArray obj = new SnapshotArray(length); * obj.Set(index,val); * int param_2 = obj.Snap(); * int param_3 = obj.Get(index,snap_id); *
}
