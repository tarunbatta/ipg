// Url:https://leetcode.com/problems/evaluate-division

/*
399. Evaluate Division
Medium

Equations are given in the format A / B = k, where A and B are variables represented as strings, and k is a real number (floating point number). Given some queries, return the answers. If the answer does not exist, return -1.0.

Example:
Given  a / b = 2.0, b / c = 3.0.
queries are:  a / c = ?, b / a = ?, a / e = ?, a / a = ?, x / x = ? .
return  [6.0, 0.5, -1.0, 1.0, -1.0 ].

The input is:  vector<pair<string, string>> equations, vector<double>&amp; values, vector<pair<string, string>> queries , where equations.size() == values.size(), and the values are positive. This represents the equations. Return  vector<double>.

According to the example above:

equations = [ ["a", "b"], ["b", "c"] ],
values = [2.0, 3.0],
queries = [ ["a", "c"], ["b", "a"], ["a", "e"], ["a", "a"], ["x", "x"] ]. 

 

The input is always valid. You may assume that evaluating the queries will result in no division by zero and there is no contradiction.
*/

using System;
using System.Collections.Generic;

namespace InterviewPreperationGuide.Core.LeetCode.Solution399 {
    public class Solution {
        public void Init () {

        }

        public double[] CalcEquation (IList<IList<string>> equations, double[] values, IList<IList<string>> queries) {
            return null;
        }
    }
}