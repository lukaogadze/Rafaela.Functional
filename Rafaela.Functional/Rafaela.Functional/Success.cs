namespace Rafaela.Functional
{
    /// <summary>
    /// The representation of "Successful result"
    /// </summary>
    public sealed class Success<T> : Result<T>
    {
        private readonly T _value;

        public Success(T value)
        {
            _value = value;
        }

        public override bool IsSucceeded => true;
        public override bool IsFailed => false;
        public override T Value => _value;

        public override string ToString()
        {
            return $"Result of {typeof(T).Name}";
        }
    }
}
