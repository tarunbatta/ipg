// Url:https://leetcode.com/problems/print-in-order

/*
1114. Print in Order
Easy

Suppose we have a class:

public class Foo {
&#xA0; public void first() { print(&quot;first&quot;); }
&#xA0; public void second() { print(&quot;second&quot;); }
&#xA0; public void third() { print(&quot;third&quot;); }
}


The same instance of Foo will be passed to three different threads. Thread A will call first(), thread B will call second(), and thread C will call third(). Design a mechanism and modify the program&#xA0;to ensure that&#xA0;second()&#xA0;is executed after&#xA0;first(), and&#xA0;third() is executed after&#xA0;second().

&#xA0;

Example 1:

Input: [1,2,3]
Output: &quot;firstsecondthird&quot;
Explanation: There are three threads being fired asynchronously. The input [1,2,3] means thread A calls first(), thread B calls second(), and thread C calls third(). &quot;firstsecondthird&quot; is the correct output.


Example 2:

Input: [1,3,2]
Output: &quot;firstsecondthird&quot;
Explanation: The input [1,3,2] means thread A calls first(), thread B calls third(), and thread C calls second(). &quot;firstsecondthird&quot; is the correct output.

&#xA0;

Note:

We do not know how the threads will be scheduled in the operating system, even though the numbers in the input seems to imply the ordering. The input format you see is mainly&#xA0;to ensure our tests&apos; comprehensiveness.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1114
{
    public class Foo
    {​    public Foo() { }​    public void First(Action printFirst)
        {                // printFirst() outputs "first". Do not change or remove this line.        printFirst();    }​    public void Second(Action printSecond) {                // printSecond() outputs "second". Do not change or remove this line.        printSecond();    }​    public void Third(Action printThird) {                // printThird() outputs "third". Do not change or remove this line.        printThird();    }}
        }
    }
}