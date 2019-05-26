namespace Rafaela.Functional.Results
{
    /// <summary>
    /// The representation of "Successful result"
    /// </summary>
    public sealed class Success<T> : Result<T>
    {
        public override bool IsSucceeded => true;
        public override bool IsFailed => false;
        public override T Value { get; }

        public Success(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"Successful Result of {typeof(T).Name}";
        }
    }
}
