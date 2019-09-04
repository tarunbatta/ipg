using System;
using System.Collections.Generic;

namespace TechByTarun.InterviewPreperationGuide.App.Leetcode
{
    /// <summary>
    /// Roman to Integer
    /// https://leetcode.com/problems/roman-to-integer/
    ///
    /// Given a roman numeral, convert it to an integer.
    /// Input is guaranteed to be within the range from 1 to 3999.
    /// </summary>
    public class Question13
    {
        public static void Init(string[] args)
        {
            Console.WriteLine(RomanToInt(null));
            Program.PrintLine();
            Console.WriteLine(RomanToInt("IX"));
            Program.PrintLine();
            Console.WriteLine(RomanToInt("VI"));
            Program.PrintLine();
            Console.WriteLine(RomanToInt("MDCLIX"));
            Program.PrintLine();
            Console.WriteLine(RomanToInt("MDCIL"));
        }

        public static int RomanToInt(string s)
        {
            int result = 0;

            if (!string.IsNullOrEmpty(s))
            {
                Dictionary<char, int> dict = new Dictionary<char, int>();
                dict.Add('I', 1);
                dict.Add('V', 5);
                dict.Add('X', 10);
                dict.Add('L', 50);
                dict.Add('C', 100);
                dict.Add('D', 500);
                dict.Add('M', 1000);

                for (int i = 0; i < s.Length; i++)
                {
                    if (!dict.ContainsKey(s[i]))
                    {
                        return result;
                    }
                }

                result = dict[s[s.Length - 1]];

                for (int i = s.Length - 2; i >= 0; i--)
                {
                    if (dict[s[i + 1]] > dict[s[i]])
                    {
                        result -= dict[s[i]];
                    }
                    else
                    {
                        result += dict[s[i]];
                    }
                }
            }

            return result;
        }
    }
}