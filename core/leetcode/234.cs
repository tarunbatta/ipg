// Url:https://leetcode.com/problems/palindrome-linked-list

/*
234. Palindrome Linked List
Easy

Given a singly linked list, determine if it is a palindrome.

Example 1:

Input: 1->2
Output: false

Example 2:

Input: 1->2->2->1
Output: true

Follow up:
Could you do it in O(n) time and O(1) space?
*/

using System;
using System.Collections;

namespace InterviewPreperationGuide.Core.LeetCode.Solution234 {
    public class Solution {
        public void Init () {
            ListNode l1 = new ListNode (1);
            l1.next = new ListNode (2);

            ListNode l2 = new ListNode (1);
            l2.next = new ListNode (2);
            l2.next.next = new ListNode (2);
            l2.next.next.next = new ListNode (1);

            Console.WriteLine (IsPalindrome_a (null));
            Console.WriteLine (IsPalindrome_a (new ListNode (0)));
            Console.WriteLine (IsPalindrome_a (l1));
            Console.WriteLine (IsPalindrome_a (l2));

            Console.WriteLine (IsPalindrome_b (null));
            Console.WriteLine (IsPalindrome_b (new ListNode (0)));
            Console.WriteLine (IsPalindrome_b (l1));
            Console.WriteLine (IsPalindrome_b (l2));
        }

        public static bool IsPalindrome_a (ListNode head) {
            bool result = true;

            if (head == null) {
                return true;
            } else {
                Stack s = new Stack ();
                ListNode node = head;

                while (node != null) {
                    s.Push (node.val);
                    node = node.next;
                }

                if (s.Count > 0) {
                    node = head;

                    while (node.next != null) {
                        int fromStack = (int) s.Pop ();

                        if (node.val == fromStack) {
                            node = node.next;
                        } else {
                            return false;
                        }
                    }

                    result = true;
                } else {
                    result = false;
                }
            }

            return result;
        }

        public static bool IsPalindrome_b (ListNode head) {
            bool result = true;

            if (head == null) {
                result = true;
            } else {
                int lengthOfList = 0;
                ListNode node = head;

                while (node != null) {
                    lengthOfList++;
                    node = node.next;
                }

                if (lengthOfList == 1) {
                    result = true;
                } else {
                    node = head;

                    ListNode temp = null;
                    ListNode reverseHead = null;

                    for (int i = 0; i < (lengthOfList / 2); i++) {
                        temp = node;
                        node = node.next;
                        temp.next = reverseHead;
                        reverseHead = temp;
                    }

                    if (lengthOfList % 2 != 0) {
                        node = node.next;
                    }

                    while (node != null) {
                        if (reverseHead.val != node.val) {
                            return false;
                        }

                        node = node.next;
                        reverseHead = reverseHead.next;
                    }
                }
            }

            return result;
        }
    }

    public class ListNode {
        public int val;
        public ListNode next;

        public ListNode (int x) {
            val = x;
        }
    }
}