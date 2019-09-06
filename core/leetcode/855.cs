// Url:https://leetcode.com/problems/exam-room

/*
855. Exam Room
Medium

In an exam room, there are N seats in a single row, numbered 0, 1, 2, ..., N-1.

When a student enters the room, they must sit in the seat that maximizes the distance to the closest person.&#xA0; If there are multiple such seats, they sit in the seat with the lowest number.&#xA0; (Also, if no one is in the room, then the student sits at seat number 0.)

Return a class ExamRoom(int N)&#xA0;that exposes two functions: ExamRoom.seat()&#xA0;returning an int&#xA0;representing what seat the student sat in, and ExamRoom.leave(int p)&#xA0;representing that the student in seat number p&#xA0;now leaves the room.&#xA0; It is guaranteed that any calls to ExamRoom.leave(p) have a student sitting in seat p.

&#xA0;

Example 1:

Input: [&quot;ExamRoom&quot;,&quot;seat&quot;,&quot;seat&quot;,&quot;seat&quot;,&quot;seat&quot;,&quot;leave&quot;,&quot;seat&quot;], [[10],[],[],[],[],[4],[]]
Output: [null,0,9,4,2,null,5]
Explanation:
ExamRoom(10) -&gt; null
seat() -&gt; 0, no one is in the room, then the student sits at seat number 0.
seat() -&gt; 9, the student sits at the last seat number 9.
seat() -&gt; 4, the student sits at the last seat number 4.
seat() -&gt; 2, the student sits at the last seat number 2.
leave(4) -&gt; null
seat() -&gt; 5, the student sits at the last seat number 5.


&#x200B;&#x200B;&#x200B;&#x200B;&#x200B;&#x200B;&#x200B;

Note:


	1 &lt;= N &lt;= 10^9
	ExamRoom.seat() and ExamRoom.leave() will be called at most 10^4 times across all test cases.
	Calls to ExamRoom.leave(p) are guaranteed to have a student currently sitting in seat number p.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution855
{
    public class ExamRoom {​    public ExamRoom(int N) { } public int Seat() { } public void Leave(int p) { } }​/** * Your ExamRoom object will be instantiated and called as such: * ExamRoom obj = new ExamRoom(N); * int param_1 = obj.Seat(); * obj.Leave(p); *
}
