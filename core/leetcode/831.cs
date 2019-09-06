// Url:https://leetcode.com/problems/masking-personal-information

/*
831. Masking Personal Information
Medium

We are given a&#xA0;personal information string S, which may represent&#xA0;either an email address or a phone number.

We would like to mask this&#xA0;personal information according to the&#xA0;following rules:


1. Email address:

We define a&#xA0;name to be a string of length &#x2265; 2 consisting&#xA0;of only lowercase letters&#xA0;a-z or uppercase&#xA0;letters&#xA0;A-Z.

An email address starts with a name, followed by the&#xA0;symbol &apos;@&apos;, followed by a name, followed by the&#xA0;dot&#xA0;&apos;.&apos;&#xA0;and&#xA0;followed by a name.&#xA0;

All email addresses are&#xA0;guaranteed to be valid and in the format of&#xA0;&quot;name1@name2.name3&quot;.

To mask an email, all names must be converted to lowercase and all letters between the first and last letter of the first name must be replaced by 5 asterisks &apos;*&apos;.


2. Phone number:

A phone number is a string consisting of&#xA0;only the digits 0-9 or the characters from the set {&apos;+&apos;, &apos;-&apos;, &apos;(&apos;, &apos;)&apos;, &apos;&#xA0;&apos;}.&#xA0;You may assume a phone&#xA0;number contains&#xA0;10 to 13 digits.

The last 10 digits make up the local&#xA0;number, while the digits before those make up the country code. Note that&#xA0;the country code is optional. We want to expose only the last 4 digits&#xA0;and mask all other&#xA0;digits.

The local&#xA0;number&#xA0;should be formatted and masked as &quot;***-***-1111&quot;,&#xA0;where 1 represents the exposed digits.

To mask a phone number with country code like &quot;+111 111 111 1111&quot;, we write it in the form &quot;+***-***-***-1111&quot;.&#xA0; The &apos;+&apos;&#xA0;sign and the first &apos;-&apos;&#xA0;sign before the local number should only exist if there is a country code.&#xA0; For example, a 12 digit phone number mask&#xA0;should start&#xA0;with &quot;+**-&quot;.

Note that extraneous characters like &quot;(&quot;, &quot;)&quot;, &quot; &quot;, as well as&#xA0;extra dashes or plus signs not part of the above formatting scheme should be removed.

&#xA0;

Return the correct &quot;mask&quot; of the information provided.

&#xA0;

Example 1:

Input: &quot;LeetCode@LeetCode.com&quot;
Output: &quot;l*****e@leetcode.com&quot;
Explanation:&#xA0;All names are converted to lowercase, and the letters between the
&#xA0;            first and last letter of the first name is replaced by 5 asterisks.
&#xA0;            Therefore, &quot;leetcode&quot; -&gt; &quot;l*****e&quot;.


Example 2:

Input: &quot;AB@qq.com&quot;
Output: &quot;a*****b@qq.com&quot;
Explanation:&#xA0;There must be 5 asterisks between the first and last letter 
&#xA0;            of the first name &quot;ab&quot;. Therefore, &quot;ab&quot; -&gt; &quot;a*****b&quot;.


Example 3:

Input: &quot;1(234)567-890&quot;
Output: &quot;***-***-7890&quot;
Explanation:&#xA0;10 digits in the phone number, which means all digits make up the local number.


Example 4:

Input: &quot;86-(10)12345678&quot;
Output: &quot;+**-***-***-5678&quot;
Explanation:&#xA0;12 digits, 2 digits for country code and 10 digits for local number. 


Notes:


	S.length&#xA0;&lt;=&#xA0;40.
	Emails have length at least 8.
	Phone numbers have length at least 10.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution831
{
    public class Solution
    {
        public void Init() { }

        public string MaskPII(string S) { }
    }
}
