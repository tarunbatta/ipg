// Url:https://leetcode.com/problems/snapshot-array

/*
1146. Snapshot Array
Medium

Implement a SnapshotArray that supports the following interface:


	SnapshotArray(int length) initializes an array-like data structure with the given length.  Initially, each element equals 0.
	void set(index, val) sets the element at the given index to be equal to val.
	int snap() takes a snapshot of the array and returns the snap_id: the total number of times we called snap() minus 1.
	int get(index, snap_id) returns the value at the given index, at the time we took the snapshot with the given snap_id


 
Example 1:

Input: ["SnapshotArray","set","snap","set","get"]
[[3],[0,5],[],[0,6],[0,0]]
Output: [null,null,0,null,5]
Explanation: 
SnapshotArray snapshotArr = new SnapshotArray(3); // set the length to be 3
snapshotArr.set(0,5);  // Set array[0] = 5
snapshotArr.snap();  // Take a snapshot, return snap_id = 0
snapshotArr.set(0,6);
snapshotArr.get(0,0);  // Get the value of array[0] with snap_id = 0, return 5

 
Constraints:


	1 <= length <= 50000
	At most 50000 calls will be made to set, snap, and get.
	0 <= index < length
	0 <= snap_id < (the total number of times we call snap())
	0 <= val <= 10^9
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.problem1146
{
    public class Solution
    {
        public void Init()
        {
            SnapshotArray obj = new SnapshotArray(0);
            obj.Set(0, 0);
            int param_2 = obj.Snap();
            int param_3 = obj.Get(0, 0);
        }
    }

    public class SnapshotArray
    {
        public SnapshotArray(int length)
        {

        }

        public void Set(int index, int val)
        {

        }

        public int Snap()
        {
            return 0;
        }

        public int Get(int index, int snap_id)
        {
            return 0;
        }
    }
}