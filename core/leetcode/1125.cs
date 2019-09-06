// Url:https://leetcode.com/problems/smallest-sufficient-team

/*
1125. Smallest Sufficient Team
Hard

In a project, you have a list of required skills req_skills,&#xA0;and a list of people.&#xA0; The i-th person people[i]&#xA0;contains a list of skills that person has.

Consider a sufficient team: a set of people such that for every required skill in req_skills, there is at least one person in the team who has that skill.&#xA0; We can represent these teams by the index of each person: for example, team = [0, 1, 3] represents the people with skills people[0], people[1], and people[3].

Return any&#xA0;sufficient team of the smallest possible size, represented by the index of each person.

You may return the answer in any order.&#xA0; It is guaranteed an answer exists.

&#xA0;
Example 1:
Input: req_skills = [&quot;java&quot;,&quot;nodejs&quot;,&quot;reactjs&quot;], people = [[&quot;java&quot;],[&quot;nodejs&quot;],[&quot;nodejs&quot;,&quot;reactjs&quot;]]
Output: [0,2]
Example 2:
Input: req_skills = [&quot;algorithms&quot;,&quot;math&quot;,&quot;java&quot;,&quot;reactjs&quot;,&quot;csharp&quot;,&quot;aws&quot;], people = [[&quot;algorithms&quot;,&quot;math&quot;,&quot;java&quot;],[&quot;algorithms&quot;,&quot;math&quot;,&quot;reactjs&quot;],[&quot;java&quot;,&quot;csharp&quot;,&quot;aws&quot;],[&quot;reactjs&quot;,&quot;csharp&quot;],[&quot;csharp&quot;,&quot;math&quot;],[&quot;aws&quot;,&quot;java&quot;]]
Output: [1,2]

&#xA0;
Constraints:


	1 &lt;= req_skills.length &lt;= 16
	1 &lt;= people.length &lt;= 60
	1 &lt;= people[i].length, req_skills[i].length, people[i][j].length&#xA0;&lt;= 16
	Elements of req_skills and people[i] are (respectively) distinct.
	req_skills[i][j], people[i][j][k] are&#xA0;lowercase English letters.
	Every skill in people[i]&#xA0;is a skill in req_skills.
	It is guaranteed a sufficient team exists.
*/

using System;

namespace InterviewPreperationGuide.Core.LeetCode.Solution1125
{
    public class Solution
    {
        public void Init() { }

        public int[] SmallestSufficientTeam(string[] req_skills, IList<IList<string>> people) { }
    }
}
