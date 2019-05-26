namespace Rafaela.Functional.Optionals.Fp
{
    /// <summary>
    /// The representation of "Value of type T"
    /// </summary>
    public sealed class Some<T> : Option<T>
    {
        public override bool IsSome => true;
        public override bool IsNone => false;
        public override T Value { get; }

        public Some(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"Some of {typeof(T).Name}";
        }
    }
}
