// Url:https://leetcode.com/problems/number-of-atoms

/*
726. Number of Atoms
Hard

Given a chemical formula (given as a string), return the count of each atom.

An atomic element always starts with an uppercase character, then zero or more lowercase letters, representing the name.

1 or more digits representing the count of that element may follow if the count is greater than 1.  If the count is 1, no digits will follow.  For example, H2O and H2O2 are possible, but H1O2 is impossible.

Two formulas concatenated together produce another formula.  For example, H2O2He3Mg4 is also a formula.  

A formula placed in parentheses, and a count (optionally added) is also a formula.  For example, (H2O2) and (H2O2)3 are formulas.

Given a formula, output the count of all elements as a string in the following form: the first name (in sorted order), followed by its count (if that count is more than 1), followed by the second name (in sorted order), followed by its count (if that count is more than 1), and so on.

Example 1:
Input: 
formula = &quot;H2O&quot;
Output: &quot;H2O&quot;
Explanation: 
The count of elements are {&apos;H&apos;: 2, &apos;O&apos;: 1}.



Example 2:
Input: 
formula = &quot;Mg(OH)2&quot;
Output: &quot;H2MgO2&quot;
Explanation: 
The count of elements are {&apos;H&apos;: 2, &apos;Mg&apos;: 1, &apos;O&apos;: 2}.



Example 3:
Input: 
formula = &quot;K4(ON(SO3)2)2&quot;
Output: &quot;K4N2O14S4&quot;
Explanation: 
The count of elements are {&apos;K&apos;: 4, &apos;N&apos;: 2, &apos;O&apos;: 14, &apos;S&apos;: 4}.



Note:
All atom names consist of lowercase letters, except for the first character which is uppercase.
The length of formula will be in the range [1, 1000].
formula will only consist of letters, digits, and round parentheses, and is a valid formula as defined in the problem.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution726
{
    public class Solution
    {
        public void Init() { }

        public string CountOfAtoms(string formula) { }
    }
}
