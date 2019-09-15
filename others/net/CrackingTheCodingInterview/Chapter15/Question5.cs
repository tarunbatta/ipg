namespace InterviewPreperationGuide.App.CrackingTheCodingInterview.Chapter15 {
    /// <summary>
    /// Call In Order: Suppose we have the following code:
    /// public class Foo
    /// {
    ///     public Foo() { ... }
    ///     public void first() { ... }
    ///     public void second() { ... }
    ///     public void third() { ... }
    /// }
    /// The same instance of Foo will be passed to three different threads.ThreadA will call first,
    /// threadB will call second, and threadC will call third.Design a mechanism to ensure that
    /// first is called before second and second is called before third.
    /// </summary>
    public class Question5 {
        public static void Init (string[] args) { }
    }
}