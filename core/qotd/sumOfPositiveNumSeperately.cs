using System;

namespace InterviewPreperationGuide.Core.Qotd
{
    /// <summary>
    /// Sum +ve and -ve numbers separately
    /// </summary>
    public class sumOfPositiveNumSeperately
    {
        public static void Init()
        {
            SumArray(new int[] { 1, 2, 3, 4, -1, -2, -3 });
        }

        public static void SumArray(int[] arr)
        {
            int p = 0;
            int n = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    p += arr[i];
                }
                else
                {
                    n += arr[i];
                }
            }

            Console.WriteLine(p);
            Console.WriteLine(n);
        }
    }
}