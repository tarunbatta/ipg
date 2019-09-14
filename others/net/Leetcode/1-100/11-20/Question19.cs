namespace TechByTarun.InterviewPreperationGuide.App.Leetcode {
    /// <summary>
    /// Remove Nth Node From End of List
    /// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
    ///
    /// Given a linked list, remove the nth node from the end of list and return its head.
    ///
    /// For example,
    /// Given linked list: 1->2->3->4->5, and n = 2.
    ///
    /// After removing the second node from the end, the linked list becomes 1->2->3->5.
    ///
    /// Note:
    /// Given n will always be valid.
    ///
    /// Try to do this in one pass.
    /// </summary>
    public class Question19 {
        public static void Init (string[] args) {
            Program.PrintListNode (RemoveNthFromEnd (null, 0));
            Program.PrintLine ();
            Program.PrintListNode (RemoveNthFromEnd (null, 0));
            Program.PrintLine ();
            Program.PrintListNode (RemoveNthFromEnd (null, 0));
        }

        public static ListNode RemoveNthFromEnd (ListNode head, int n) {
            return null;
        }
    }
}