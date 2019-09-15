// Url:https://leetcode.com/problems/merge-k-sorted-lists

/*
23. Merge k Sorted Lists
Hard

Merge k sorted linked lists and return it as one sorted list. Analyze and describe its complexity.

Example:

Input:
[
  1->4->5,
  1->3->4,
  2->6
]
Output: 1->1->2->3->4->4->5->6
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewPreperationGuide.Core.LeetCode.problem23 {
    public class Solution {
        public void Init () {
            ListNode l1 = new ListNode (3);
            l1.next = new ListNode (9);

            ListNode l2 = new ListNode (2);
            l2.next = new ListNode (5);

            ListNode l3 = new ListNode (1);
            l3.next = new ListNode (8);

            ListNode[] lists = new ListNode[3];
            lists[0] = l1;
            lists[1] = l2;
            lists[2] = l3;

            ListNode result = MergeKLists (lists);

            while (result.next != null) {
                Console.WriteLine (result.val);
                result = result.next;
            }
        }

        public ListNode MergeKLists (ListNode[] lists) {
            // if (lists == null || (lists != null && lists.Length == 0)) {
            //     return null;
            // }

            // List<KeyValuePair<int, ListNode>> sortedList = new List<KeyValuePair<int, ListNode>> ();

            // foreach (var item in lists) {
            //     if (item != null) {
            //         KeyValuePair<int, ListNode> kv = new KeyValuePair<int, ListNode> (item.val, item);
            //         int index = sortedList.IndexOf (kv);

            //         if (index >= 0) {
            //             sortedList[index] = kv;
            //         } else {
            //             sortedList.Add (kv);
            //         }
            //     }
            // }

            // ListNode head = null;
            // ListNode result = null;

            // while (sortedList.Count > 0) {
            //     sortedList = sortedList.OrderBy (x => x.Key).ToList ();

            //     var node = sortedList[0];
            //     var first = sortedList[0].Value;
            //     sortedList.Remove (node);

            //     if (first.next != null) {
            //         sortedList.Add (new KeyValuePair<int, ListNode> (first.next.val, first.next));
            //     }

            //     if (result == null) {
            //         first.next = null;
            //         result = first;
            //         head = result;
            //     } else {
            //         result.next = first;
            //         first.next = null;
            //         result = first;
            //     }
            // }

            // return head;

            return null;
        }

        private class KeyValuePair<T1, T2> { }
    }

    public class ListNode {
        public int val;
        public ListNode next;

        public ListNode (int x) {
            val = x;
        }
    }
}