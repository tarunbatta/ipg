// Url:https://leetcode.com/problems/unique-email-addresses

/*
929. Unique Email Addresses
Easy

Every email consists of a local name and a domain name, separated by the @ sign.

For example, in alice@leetcode.com,&#xA0;alice is the local name, and leetcode.com is the domain name.

Besides lowercase letters, these emails may contain &apos;.&apos;s or &apos;+&apos;s.

If you add periods (&apos;.&apos;) between some characters in the local name part of an email address, mail sent there will be forwarded to the same address without dots in the local name.&#xA0; For example, &quot;alice.z@leetcode.com&quot; and &quot;alicez@leetcode.com&quot; forward to the same email address.&#xA0; (Note that this rule does not apply for domain names.)

If you add a plus (&apos;+&apos;) in the local name, everything after the first plus sign will be&#xA0;ignored. This allows certain emails to be filtered, for example&#xA0;m.y+name@email.com&#xA0;will be forwarded to&#xA0;my@email.com.&#xA0; (Again, this rule does not apply for domain names.)

It is possible to use both of these rules at the same time.

Given a list of emails, we send one email to each address in the list.&#xA0;&#xA0;How many different addresses actually receive mails?&#xA0;

&#xA0;


Example 1:

Input: [&quot;test.email+alex@leetcode.com&quot;,&quot;test.e.mail+bob.cathy@leetcode.com&quot;,&quot;testemail+david@lee.tcode.com&quot;]
Output: 2
Explanation:&#xA0;&quot;testemail@leetcode.com&quot; and &quot;testemail@lee.tcode.com&quot; actually receive mails


&#xA0;

Note:


	1 &lt;= emails[i].length&#xA0;&lt;= 100
	1 &lt;= emails.length &lt;= 100
	Each emails[i] contains exactly one &apos;@&apos; character.
	All local and domain names are non-empty.
	Local names do not start with a &apos;+&apos; character.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution929
{
    public class Solution
    {
        public void Init() { }

        public int NumUniqueEmails(string[] emails) { }
    }
}
