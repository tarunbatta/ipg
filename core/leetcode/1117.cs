// Url:https://leetcode.com/problems/building-h2o

/*
1117. Building H2O
Medium

There are two kinds of threads, oxygen and hydrogen. Your goal is to group these threads to form water molecules.&#xA0;There is a barrier where each thread has to&#xA0;wait until a complete molecule can be formed. Hydrogen and oxygen threads will be given releaseHydrogen&#xA0;and releaseOxygen&#xA0;methods respectively, which will allow them to pass the barrier. These threads should pass the barrier in groups of three, and they must be able to immediately bond with each other to form a water molecule.&#xA0;You must guarantee that all the threads from one molecule bond before any other threads from the next molecule do.

In other words:


	If an oxygen thread arrives at the barrier when no hydrogen threads are present, it has to wait for two hydrogen threads.
	If a hydrogen thread arrives at the barrier when no other threads are present, it has to wait for an oxygen thread and another hydrogen thread.


We don&#x2019;t have to worry about matching the threads up explicitly; that is, the threads do not necessarily know which other threads they are paired up with. The key is just that threads pass the barrier in complete sets; thus, if we examine the sequence of threads that bond and divide them into groups of three, each group should contain one oxygen and two hydrogen threads.

Write synchronization code for oxygen and hydrogen molecules that enforces these constraints.


&#xA0;



Example 1:

Input: &quot;HOH&quot;
Output: &quot;HHO&quot;
Explanation: &quot;HOH&quot; and &quot;OHH&quot; are also valid answers.



Example 2:

Input: &quot;OOHHHH&quot;
Output: &quot;HHOHHO&quot;
Explanation: &quot;HOHHHO&quot;, &quot;OHHHHO&quot;, &quot;HHOHOH&quot;, &quot;HOHHOH&quot;, &quot;OHHHOH&quot;, &quot;HHOOHH&quot;, &quot;HOHOHH&quot; and &quot;OHHOHH&quot; are also valid answers.




&#xA0;
Constraints:


	Total length of input string will be 3n, where 1 &#x2264;&#xA0;n&#xA0;&#x2264; 20.
	Total number of H will be 2n&#xA0;in the input string.
	Total number of O will&#xA0;be n&#xA0;in the input&#xA0;string.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1117
{
    public class H2O
    {​    
	public H2O() { }​    
	public void Hydrogen(Action releaseHydrogen)
        {                // releaseHydrogen() outputs "H". Do not change or remove this line.        releaseHydrogen();    }​    public void Oxygen(Action releaseOxygen) {                // releaseOxygen() outputs "O". Do not change or remove this line.        releaseOxygen();    }}
        }
    }
}