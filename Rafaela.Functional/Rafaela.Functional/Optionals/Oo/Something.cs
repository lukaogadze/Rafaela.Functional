namespace Rafaela.Functional.Optionals.Oo
{
    /// <summary>
    /// The representation of 'Value of type T'
    /// </summary>
    public sealed class Something<T> : Optional<T>
    {
        public override T Value { get; }
        public override bool IsSomething => true;
        public override bool IsNothing => false;

        public Something(T value)
        {
            Value = value;
        }


        public override string ToString()
        {
            return $"Something of {typeof(T).Name}";
        }
    }
}
