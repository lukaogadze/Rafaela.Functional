namespace Rafaela.Functional
{
    public abstract class Option<T>
    {
        /// <summary>
        /// Return 'true' if the option is a 'Some' value.
        /// </summary>
        public abstract bool IsSome { get; }

        /// <summary>
        /// Return 'true' if the option is a 'None' value.
        /// </summary>
        public abstract bool IsNone { get; }

        /// <summary>
        /// Get the value of a 'Some' option. A NullReferenceException is raised if the option is 'None'
        /// </summary>
        public abstract T Value { get; }
    }

    public static class Option
    {
        public static Option<T> Some<T>(T value) => new Some<T>(value);
        public static Option<T> None<T>() => new None<T>();
    }
}
