using System;
using System.Collections.Generic;
using System.Linq;

namespace TechByTarun.InterviewPreperationGuide.App.Leetcode {
    /// <summary>
    /// Merge k Sorted Lists
    /// https://leetcode.com/problems/merge-k-sorted-lists/
    ///
    /// Merge k sorted linked lists and return it as one sorted list. Analyze and describe its complexity.
    /// </summary>
    public class Question23 {
        public static void Init (string[] args) {
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

            ListNode result = GetMergedKLists (lists);

            while (result.next != null) {
                Console.WriteLine (result.val);
                result = result.next;
            }
        }

        public static ListNode GetMergedKLists (ListNode[] lists) {
            if (lists == null || (lists != null && lists.Length == 0)) {
                return null;
            }

            List<KeyValuePair<int, ListNode>> sortedList = new List<KeyValuePair<int, ListNode>> ();

            foreach (var item in lists) {
                if (item != null) {
                    KeyValuePair<int, ListNode> kv = new KeyValuePair<int, ListNode> (item.val, item);
                    int index = sortedList.IndexOf (kv);

                    if (index >= 0) {
                        sortedList[index] = kv;
                    } else {
                        sortedList.Add (kv);
                    }
                }
            }

            ListNode head = null;
            ListNode result = null;

            while (sortedList.Count > 0) {
                sortedList = sortedList.OrderBy (x => x.Key).ToList ();

                var node = sortedList[0];
                var first = sortedList[0].Value;
                sortedList.Remove (node);

                if (first.next != null) {
                    sortedList.Add (new KeyValuePair<int, ListNode> (first.next.val, first.next));
                }

                if (result == null) {
                    first.next = null;
                    result = first;
                    head = result;
                } else {
                    result.next = first;
                    first.next = null;
                    result = first;
                }
            }

            return head;
        }
    }
}