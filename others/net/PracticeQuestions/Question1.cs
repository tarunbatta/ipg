using System;

namespace TechByTarun.InterviewPreperationGuide.App.PracticeQuestions
{
    /// <summary>
    /// Find the factorial of a number
    /// </summary>
    public class Question1
    {
        public static void Init(string[] args)
        {
            Console.WriteLine("Implementation by for loop:");
            Program.PrintLine();
            Console.WriteLine("-1: " + Factorial_a(-1));
            Program.PrintLine();
            Console.WriteLine("0: " + Factorial_a(0));
            Program.PrintLine();
            Console.WriteLine("1: " + Factorial_a(1));
            Program.PrintLine();
            Console.WriteLine("2: " + Factorial_a(2));
            Program.PrintLine();
            Console.WriteLine("3: " + Factorial_a(3));
            Program.PrintLine();
            Console.WriteLine("4: " + Factorial_a(4));
            Program.PrintLine();
            Console.WriteLine("5: " + Factorial_a(5));
            Program.PrintLine();
            Console.WriteLine("6: " + Factorial_a(6));
            Program.PrintLine();
            Console.WriteLine("7: " + Factorial_a(7));
            Program.PrintLine();
            Console.WriteLine("8: " + Factorial_a(8));
            Program.PrintLine();
            Console.WriteLine("9: " + Factorial_a(9));
            Program.PrintLine();
            Console.WriteLine("10: " + Factorial_a(10));

            Program.PrintSeperator();

            Console.WriteLine("Implementation by recursion:");
            Program.PrintLine();
            Console.WriteLine("-1: " + Factorial_b(-1));
            Program.PrintLine();
            Console.WriteLine("0: " + Factorial_b(0));
            Program.PrintLine();
            Console.WriteLine("1: " + Factorial_b(1));
            Program.PrintLine();
            Console.WriteLine("2: " + Factorial_b(2));
            Program.PrintLine();
            Console.WriteLine("3: " + Factorial_b(3));
            Program.PrintLine();
            Console.WriteLine("4: " + Factorial_b(4));
            Program.PrintLine();
            Console.WriteLine("5: " + Factorial_b(5));
            Program.PrintLine();
            Console.WriteLine("6: " + Factorial_b(6));
            Program.PrintLine();
            Console.WriteLine("7: " + Factorial_b(7));
            Program.PrintLine();
            Console.WriteLine("8: " + Factorial_b(8));
            Program.PrintLine();
            Console.WriteLine("9: " + Factorial_b(9));
            Program.PrintLine();
            Console.WriteLine("10: " + Factorial_b(10));
        }

        private static int Factorial_a(int input)
        {
            int result = 1;

            for (int i = input; i > 0; i--)
            {
                result = result * i;
            }

            return result;
        }

        private static int Factorial_b(int input)
        {
            if (input < 0)
            {
                return -1;
            }
            else if (input == 0)
            {
                return 1;
            }
            else
            {
                return input * Factorial_b(input - 1);
            }
        }
    }
}