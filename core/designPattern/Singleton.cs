using System;

namespace InterviewPreperationGuide.Core.DesignPattern
{
    /// <summary>
    /// Definition: Ensures a class hs only one instance and provides a global point to access it
    /// Marked sealed to prevent derivation
    /// </summary>
    public sealed class Singleton
    {
        /// <summary>
        /// volatile ensures that the assignment to the instance is done before its accessed
        /// </summary>
        private static volatile Singleton instance;

        /// <summary>
        /// to avoid deadlocks
        /// </summary>
        private static object syncRoot = new Object();

        /// <summary>
        /// private constructor to ensure that the instance of the class cannot be created
        /// </summary>
        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    // allows only single thread to enter only when the instance is not yet created
                    lock (syncRoot)
                    {
                        // double check to solve thread concurrency problem
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }

                return instance;
            }
        }
    }
}