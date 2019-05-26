namespace Rafaela.Functional.Optionals.Oo
{
    public abstract class Optional<T>
    {
        /// <summary>
        /// Return 'true' if the optional is a 'Something'.
        /// </summary>
        public abstract bool IsSomething { get; }

        /// <summary>
        /// Return 'true' if the optional is a 'Nothing'.
        /// </summary>
        public abstract bool IsNothing { get; }

        /// <summary>
        /// Get the value of a 'Something' optional. A InvalidOperationException is raised if the option is 'None'
        /// </summary>
        public abstract T Value { get; }
    }

    public static class Optional
    {
        public static Optional<T> Something<T>(T value) => new Something<T>(value);
        public static Optional<T> Nothing<T>() => new Nothing<T>();
    }
}
