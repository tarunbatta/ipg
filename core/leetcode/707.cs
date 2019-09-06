// Url:https://leetcode.com/problems/design-linked-list

/*
707. Design Linked List
Easy

Design your&#xA0;implementation of the linked list. You can choose to use the singly linked list or the doubly linked list. A node in a singly&#xA0;linked list should have two attributes: val&#xA0;and next. val is the value of the current node, and next&#xA0;is&#xA0;a&#xA0;pointer/reference to the next node. If you want to use the doubly linked list,&#xA0;you will need&#xA0;one more attribute prev to indicate the previous node in the linked list. Assume all nodes in the linked list are 0-indexed.

Implement these functions in your linked list class:


	get(index) : Get the value of&#xA0;the index-th&#xA0;node in the linked list. If the index is invalid, return -1.
	addAtHead(val) : Add a node of value val&#xA0;before the first element of the linked list. After the insertion, the new node will be the first node of the linked list.
	addAtTail(val) : Append a node of value val&#xA0;to the last element of the linked list.
	addAtIndex(index, val) : Add a node of value val&#xA0;before the index-th&#xA0;node in the linked list.&#xA0;If index&#xA0;equals&#xA0;to the length of&#xA0;linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. If index is negative, the node will be inserted at the head&#xA0;of the list.
	deleteAtIndex(index) : Delete&#xA0;the index-th&#xA0;node in the linked list, if the index is valid.


Example:

MyLinkedList linkedList = new MyLinkedList();
linkedList.addAtHead(1);
linkedList.addAtTail(3);
linkedList.addAtIndex(1, 2);  // linked list becomes 1-&gt;2-&gt;3
linkedList.get(1);            // returns 2
linkedList.deleteAtIndex(1);  // now the linked list is 1-&gt;3
linkedList.get(1);&#xA0;&#xA0;&#xA0;         // returns 3


Note:


	All values will be in the range of [1, 1000].
	The number of operations will be in the range of&#xA0;[1, 1000].
	Please do not use the built-in LinkedList library.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution707
{
    public class MyLinkedList {​    /** Initialize your data structure here. */    public MyLinkedList() { }        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */    public int Get(int index) { }        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */    public void AddAtHead(int val) { }        /** Append a node of value val to the last element of the linked list. */    public void AddAtTail(int val) { }        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */    public void AddAtIndex(int index, int val) { }        /** Delete the index-th node in the linked list, if the index is valid. */    public void DeleteAtIndex(int index) { } }​/** * Your MyLinkedList object will be instantiated and called as such: * MyLinkedList obj = new MyLinkedList(); * int param_1 = obj.Get(index); * obj.AddAtHead(val); * obj.AddAtTail(val); * obj.AddAtIndex(index,val); * obj.DeleteAtIndex(index); *
}
