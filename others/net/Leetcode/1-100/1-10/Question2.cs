using System;

namespace TechByTarun.InterviewPreperationGuide.App.Leetcode
{
    /// <summary>
    /// Add Two Numbers
    /// https://leetcode.com/problems/add-two-numbers/
    ///
    /// You are given two non-empty linked lists representing two non-negative integers.
    /// The digits are stored in reverse order and each of their nodes contain a single digit.
    /// Add the two numbers and return it as a linked list.
    ///
    /// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    ///
    /// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    /// Output: 7 -> 0 -> 8
    /// </summary>
    public class Question2
    {
        public static void Init(string[] args)
        {
            ListNode first_a = new ListNode(5);
            first_a.next = new ListNode(6);
            first_a.next.next = new ListNode(3);

            ListNode second_a = new ListNode(8);
            second_a.next = new ListNode(4);
            second_a.next.next = new ListNode(2);

            Console.WriteLine(Program.PrintListNode(AddTwoNumbers(first_a, second_a)));

            Program.PrintLine();

            ListNode first_b = new ListNode(7);
            first_b.next = new ListNode(5);
            first_b.next.next = new ListNode(9);
            first_b.next.next.next = new ListNode(4);
            first_b.next.next.next.next = new ListNode(6);

            ListNode second_b = new ListNode(8);
            second_b.next = new ListNode(4);

            Console.WriteLine(Program.PrintListNode(AddTwoNumbers(first_b, second_b)));
        }

        public static ListNode AddTwoNumbers(ListNode first, ListNode second)
        {
            ListNode result = null;
            ListNode previous = null;
            ListNode temp = null;

            int carry = 0;

            while (first != null || second != null)
            {
                int sum = carry + (first != null ? first.val : 0) + (second != null ? second.val : 0);
                carry = sum >= 10 ? 1 : 0;

                temp = new ListNode(sum % 10);

                if (result == null)
                {
                    result = temp;
                }
                else
                {
                    previous.next = temp;
                }

                previous = temp;

                if (first != null)
                {
                    first = first.next;
                }

                if (second != null)
                {
                    second = second.next;
                }
            }

            if (carry > 0)
            {
                result.next = new ListNode(carry);
            }

            return result;
        }
    }
}