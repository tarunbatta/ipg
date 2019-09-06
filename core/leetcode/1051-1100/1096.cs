// Url:https://leetcode.com/problems/brace-expansion-ii

/*
1096. Brace Expansion II
Hard

Under a grammar given below, strings can represent a set of lowercase words.&#xA0; Let&apos;s&#xA0;use R(expr)&#xA0;to denote the set of words the expression represents.

Grammar can best be understood through simple examples:


	Single letters represent a singleton set containing that word.
	
		R(&quot;a&quot;) = {&quot;a&quot;}
		R(&quot;w&quot;) = {&quot;w&quot;}
	
	
	When we take a comma delimited list of 2 or more expressions, we take the union of possibilities.
	
		R(&quot;{a,b,c}&quot;) = {&quot;a&quot;,&quot;b&quot;,&quot;c&quot;}
		R(&quot;{{a,b},{b,c}}&quot;) = {&quot;a&quot;,&quot;b&quot;,&quot;c&quot;}&#xA0;(notice the final set only contains each word at most once)
	
	
	When we concatenate two expressions, we take the set of possible concatenations between two words where the first word comes from the first expression and the second word comes from the second expression.
	
		R(&quot;{a,b}{c,d}&quot;) = {&quot;ac&quot;,&quot;ad&quot;,&quot;bc&quot;,&quot;bd&quot;}
		R(&quot;a{b,c}{d,e}f{g,h}&quot;)&#xA0;= {&quot;abdfg&quot;, &quot;abdfh&quot;, &quot;abefg&quot;, &quot;abefh&quot;, &quot;acdfg&quot;, &quot;acdfh&quot;, &quot;acefg&quot;, &quot;acefh&quot;}
	
	


Formally, the 3 rules for our grammar:


	For every lowercase letter x, we have R(x) = {x}
	For expressions e_1, e_2, ... , e_k&#xA0;with k &gt;= 2, we have R({e_1,e_2,...}) = R(e_1)&#xA0;&#x222A; R(e_2)&#xA0;&#x222A; ...
	For&#xA0;expressions e_1 and e_2, we have R(e_1 + e_2) = {a + b for (a, b) in&#xA0;R(e_1)&#xA0;&#xD7; R(e_2)}, where + denotes concatenation, and &#xD7; denotes the cartesian product.


Given an expression representing a set of words under the given grammar, return the&#xA0;sorted list of words that the expression represents.

&#xA0;


Example 1:

Input: &quot;{a,b}{c,{d,e}}&quot;
Output: [&quot;ac&quot;,&quot;ad&quot;,&quot;ae&quot;,&quot;bc&quot;,&quot;bd&quot;,&quot;be&quot;]



Example 2:

Input: &quot;{{a,z},a{b,c},{ab,z}}&quot;
Output: [&quot;a&quot;,&quot;ab&quot;,&quot;ac&quot;,&quot;z&quot;]
Explanation: Each distinct word is written only once in the final answer.


&#xA0;

Constraints:


	1 &lt;= expression.length &lt;= 50
	expression[i] consists of &apos;{&apos;, &apos;}&apos;, &apos;,&apos;or lowercase English letters.
	The given&#xA0;expression&#xA0;represents a set of words based on the grammar given in the description.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1096
{
    public class Solution
    {
        public void Init() { }

        public IList<string> BraceExpansionII(string expression) { }
    }
}
