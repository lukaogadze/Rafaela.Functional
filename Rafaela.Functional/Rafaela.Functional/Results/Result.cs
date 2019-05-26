namespace Rafaela.Functional.Results
{
    public abstract class Result<T>
    {
        /// <summary>
        /// Return 'true' if the result is 'Success'.
        /// </summary>
        public abstract bool IsSucceeded { get; }

        /// <summary>
        /// Return 'true' if the Result is 'Fail'.
        /// </summary>
        public abstract bool IsFailed { get; }

        /// <summary>
        /// Get the value of a 'Success' result. A InvalidOperationException is raised if the result is 'Fail'
        /// </summary>
        public abstract T Value { get; }
    }

    public static class Result
    {
        public static Result<T> Success<T>(T value) => new Success<T>(value);
        public static Result<T> Fail<T>() => new Fail<T>();
    }
}
