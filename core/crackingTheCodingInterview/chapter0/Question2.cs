using System;

namespace InterviewPreperationGuide.Core.CrackingTheCodingInterview.Chapter0 {
    /// <summary>
    /// Given a time, calculate the angle between the hour and minute hands.
    /// </summary>
    internal class Question2 {
        public static void Init (string[] args) {
            Console.WriteLine (DateTime.Now + ": " + CalculateAngle (DateTime.Now));
        }

        private static int CalculateAngle (DateTime time) {
            int result = 0;

            if (time != null) {
                int minuteAngle = (360 * time.Minute) / 60;
                int hourAngle = 360 * (time.Hour % 12) / 12 + 360 * (time.Minute / 60) * (1 / 12);
                result = (hourAngle - minuteAngle) % 360;
            }

            return result;
        }
    }
}