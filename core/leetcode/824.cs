// Url:https://leetcode.com/problems/goat-latin

/*
824. Goat Latin
Easy

A sentence S is given, composed of words separated by spaces. Each word consists of lowercase and uppercase letters only.

We would like to convert the sentence to &quot;Goat Latin&quot;&#xA0;(a made-up language similar to Pig Latin.)

The rules of Goat Latin are as follows:


	If a word begins with a vowel (a, e, i, o, or u), append &quot;ma&quot;&#xA0;to the end of the word.
	For example, the word &apos;apple&apos; becomes &apos;applema&apos;.
	&#xA0;
	If a word begins with a consonant (i.e. not a vowel), remove the first letter and append it to the end, then add &quot;ma&quot;.
	For example, the word &quot;goat&quot;&#xA0;becomes &quot;oatgma&quot;.
	&#xA0;
	Add one letter &apos;a&apos;&#xA0;to the end of each word per its word index in the sentence, starting with 1.
	For example,&#xA0;the first word gets &quot;a&quot; added to the end, the second word gets &quot;aa&quot; added to the end and so on.


Return the&#xA0;final sentence representing the conversion from S&#xA0;to Goat&#xA0;Latin.&#xA0;

&#xA0;

Example 1:

Input: &quot;I speak Goat Latin&quot;
Output: &quot;Imaa peaksmaaa oatGmaaaa atinLmaaaaa&quot;


Example 2:

Input: &quot;The quick brown fox jumped over the lazy dog&quot;
Output: &quot;heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa&quot;


&#xA0;

Notes:


	S contains only uppercase, lowercase and spaces.&#xA0;Exactly one space between each word.
	1 &lt;= S.length &lt;= 150.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution824
{
    public class Solution
    {
        public void Init() { }

        public string ToGoatLatin(string S) { }
    }
}
