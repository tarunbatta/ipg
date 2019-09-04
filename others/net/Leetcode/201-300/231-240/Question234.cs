using System;
using System.Collections;

namespace TechByTarun.InterviewPreperationGuide.App.Leetcode
{
    /// <summary>
    /// Palindrome Linked List
    /// https://leetcode.com/problems/palindrome-linked-list/
    ///
    /// Given a singly linked list, determine if it is a palindrome.
    /// Follow up:
    /// Could you do it in O(n) time and O(1) space?
    /// </summary>
    public class Question234
    {
        public static void Init(string[] args)
        {
            Console.WriteLine(IsPalindrome_a(null));
            Program.PrintLine();
            Console.WriteLine(IsPalindrome_a(new PalindromeLLNode(0)));
            Program.PrintLine();
            Console.WriteLine(IsPalindrome_a(new PalindromeLLNode(2, new PalindromeLLNode(2))));
            Program.PrintLine();
            Console.WriteLine(IsPalindrome_a(new PalindromeLLNode(5, new PalindromeLLNode(4, new PalindromeLLNode(5)))));
            Program.PrintLine();
            Console.WriteLine(IsPalindrome_a(new PalindromeLLNode(5, new PalindromeLLNode(4, new PalindromeLLNode(1)))));

            Program.PrintSeperator();

            Console.WriteLine(IsPalindrome_b(null));
            Program.PrintLine();
            Console.WriteLine(IsPalindrome_b(new PalindromeLLNode(0)));
            Program.PrintLine();
            Console.WriteLine(IsPalindrome_b(new PalindromeLLNode(2, new PalindromeLLNode(2))));
            Program.PrintLine();
            Console.WriteLine(IsPalindrome_b(new PalindromeLLNode(5, new PalindromeLLNode(4, new PalindromeLLNode(5)))));
            Program.PrintLine();
            Console.WriteLine(IsPalindrome_b(new PalindromeLLNode(5, new PalindromeLLNode(4, new PalindromeLLNode(1)))));
        }

        public static bool IsPalindrome_a(PalindromeLLNode head)
        {
            bool result = true;

            if (head == null)
            {
                return true;
            }
            else
            {
                Stack s = new Stack();
                PalindromeLLNode node = head;

                while (node != null)
                {
                    s.Push(node.val);
                    node = node.next;
                }

                if (s.Count > 0)
                {
                    node = head;

                    while (node.next != null)
                    {
                        int fromStack = (int)s.Pop();

                        if (node.val == fromStack)
                        {
                            node = node.next;
                        }
                        else
                        {
                            return false;
                        }
                    }

                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }

        public static bool IsPalindrome_b(PalindromeLLNode head)
        {
            bool result = true;

            if (head == null)
            {
                result = true;
            }
            else
            {
                int lengthOfList = 0;
                PalindromeLLNode node = head;

                while (node != null)
                {
                    lengthOfList++;
                    node = node.next;
                }

                if (lengthOfList == 1)
                {
                    result = true;
                }
                else
                {
                    node = head;

                    PalindromeLLNode temp = null;
                    PalindromeLLNode reverseHead = null;

                    for (int i = 0; i < (lengthOfList / 2); i++)
                    {
                        temp = node;
                        node = node.next;
                        temp.next = reverseHead;
                        reverseHead = temp;
                    }

                    if (lengthOfList % 2 != 0)
                    {
                        node = node.next;
                    }

                    while (node != null)
                    {
                        if (reverseHead.val != node.val)
                        {
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

    public class PalindromeLLNode
    {
        public int val;
        public PalindromeLLNode next;

        public PalindromeLLNode(int x)
        {
            this.val = x;
            this.next = null;
        }

        public PalindromeLLNode(int x, PalindromeLLNode next)
        {
            this.val = x;
            this.next = next;
        }
    }
}