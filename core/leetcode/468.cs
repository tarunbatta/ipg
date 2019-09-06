// Url:https://leetcode.com/problems/validate-ip-address

/*
468. Validate IP Address
Medium

Write a function to check whether an input string is a valid IPv4 address or IPv6 address or neither.



IPv4 addresses are canonically represented in dot-decimal notation, which consists of four decimal numbers, each ranging from 0 to 255, separated by dots (&quot;.&quot;), e.g.,172.16.254.1;



Besides, leading zeros in the IPv4 is invalid. For example, the address 172.16.254.01 is invalid.



IPv6 addresses are represented as eight groups of four hexadecimal digits, each group representing 16 bits. The groups are separated by colons (&quot;:&quot;). For example, the address 2001:0db8:85a3:0000:0000:8a2e:0370:7334 is a valid one. Also, we could omit some leading zeros among four hexadecimal digits and some low-case characters in the address to upper-case ones, so 2001:db8:85a3:0:0:8A2E:0370:7334 is also a valid IPv6 address(Omit leading zeros and using upper cases).




However, we don&apos;t replace a consecutive group of zero value with a single empty group using two consecutive colons (::) to pursue simplicity. For example, 2001:0db8:85a3::8A2E:0370:7334 is an invalid IPv6 address.



Besides, extra leading zeros in the IPv6 is also invalid. For example, the address 02001:0db8:85a3:0000:0000:8a2e:0370:7334 is invalid.



Note:
You may assume there is no extra space or special characters in the input string.


Example 1:
Input: &quot;172.16.254.1&quot;

Output: &quot;IPv4&quot;

Explanation: This is a valid IPv4 address, return &quot;IPv4&quot;.




Example 2:
Input: &quot;2001:0db8:85a3:0:0:8A2E:0370:7334&quot;

Output: &quot;IPv6&quot;

Explanation: This is a valid IPv6 address, return &quot;IPv6&quot;.



Example 3:
Input: &quot;256.256.256.256&quot;

Output: &quot;Neither&quot;

Explanation: This is neither a IPv4 address nor a IPv6 address.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution468
{
    public class Solution
    {
        public void Init() { }

        public string ValidIPAddress(string IP) { }
    }
}
