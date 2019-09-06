// Url:https://leetcode.com/problems/print-foobar-alternately

/*
1115. Print FooBar Alternately
Medium

Suppose you are given the following code:

class FooBar {
  public void foo() {
&#xA0; &#xA0; for (int i = 0; i &lt; n; i++) {
&#xA0; &#xA0; &#xA0; print(&quot;foo&quot;);
&#xA0;   }
  }

  public void bar() {
&#xA0; &#xA0; for (int i = 0; i &lt; n; i++) {
&#xA0; &#xA0; &#xA0; print(&quot;bar&quot;);
&#xA0; &#xA0; }
  }
}


The same instance of FooBar will be passed to two different threads. Thread A will call&#xA0;foo() while thread B will call&#xA0;bar().&#xA0;Modify the given program to output &quot;foobar&quot; n times.

&#xA0;

Example 1:

Input: n = 1
Output: &quot;foobar&quot;
Explanation: There are two threads being fired asynchronously. One of them calls foo(), while the other calls bar(). &quot;foobar&quot; is being output 1 time.


Example 2:

Input: n = 2
Output: &quot;foobarfoobar&quot;
Explanation: &quot;foobar&quot; is being output 2 times.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1115
{
    public class FooBar
    {
        private int n;​ 
        
           public FooBar(int n) { this.n = n; }​    public void Foo(Action printFoo)
        {
            for (int i = 0; i < n; i++)
            {                        // printFoo() outputs "foo". Do not change or remove this line.            printFoo();        }    }​    public void Bar(Action printBar) {                for (int i = 0; i < n; i++) {                        // printBar() outputs "bar". Do not change or remove this line.            printBar();        }    }}
            }
        }
    }
}