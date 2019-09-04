using System;

namespace TechByTarun.InterviewPreperationGuide.App.PracticeQuestions
{
    /// <summary>
    /// Check whether a number is a Prime Number
    /// (A prime number is a natural number greater than 1 that has no positive divisors other than 1 and itself.)
    /// </summary>
    public class Question13
    {
        public static void Init(string[] args)
        {
            Console.WriteLine(IsPrime_a(0));
            Program.PrintLine();
            Console.WriteLine(IsPrime_a(1));
            Program.PrintLine();
            Console.WriteLine(IsPrime_a(6));
            Program.PrintLine();
            Console.WriteLine(IsPrime_a(7));
            Program.PrintLine();
            Console.WriteLine(IsPrime_a(11));
            Program.PrintLine();
            Console.WriteLine(IsPrime_a(17));
            Program.PrintLine();
            Console.WriteLine(IsPrime_a(33));

            Program.PrintSeperator();

            Console.WriteLine(IsPrime_b(0));
            Program.PrintLine();
            Console.WriteLine(IsPrime_b(1));
            Program.PrintLine();
            Console.WriteLine(IsPrime_b(6));
            Program.PrintLine();
            Console.WriteLine(IsPrime_b(7));
            Program.PrintLine();
            Console.WriteLine(IsPrime_b(11));
            Program.PrintLine();
            Console.WriteLine(IsPrime_b(17));
            Program.PrintLine();
            Console.WriteLine(IsPrime_b(33));
        }

        private static bool IsPrime_a(int n)
        {
            if (n == 1)
            {
                return true;
            }
            else if (n < 1)
            {
                return false;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsPrime_b(int n)
        {
            if (n == 1)
            {
                return true;
            }
            else if (n < 1)
            {
                return false;
            }

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}