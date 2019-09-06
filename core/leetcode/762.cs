// Url:https://leetcode.com/problems/prime-number-of-set-bits-in-binary-representation

/*
762. Prime Number of Set Bits in Binary Representation
Easy

Given two integers L and R, find the count of numbers in the range [L, R] (inclusive) having a prime number of set bits in their binary representation.

(Recall that the number of set bits an integer has is the number of 1s present when written in binary.  For example, 21 written in binary is 10101 which has 3 set bits.  Also, 1 is not a prime.)


Example 1:Input: L = 6, R = 10
Output: 4
Explanation:
6 -&gt; 110 (2 set bits, 2 is prime)
7 -&gt; 111 (3 set bits, 3 is prime)
9 -&gt; 1001 (2 set bits , 2 is prime)
10-&gt;1010 (2 set bits , 2 is prime)


Example 2:Input: L = 10, R = 15
Output: 5
Explanation:
10 -&gt; 1010 (2 set bits, 2 is prime)
11 -&gt; 1011 (3 set bits, 3 is prime)
12 -&gt; 1100 (2 set bits, 2 is prime)
13 -&gt; 1101 (3 set bits, 3 is prime)
14 -&gt; 1110 (3 set bits, 3 is prime)
15 -&gt; 1111 (4 set bits, 4 is not prime)


Note:
L, R will be integers L &lt;= R in the range [1, 10^6].
R - L will be at most 10000.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution762
{
    public class Solution
    {
        public void Init() { }

        public int CountPrimeSetBits(int L, int R) { }
    }
}
