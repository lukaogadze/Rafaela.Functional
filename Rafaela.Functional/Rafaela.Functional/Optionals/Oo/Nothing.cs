using System;

namespace Rafaela.Functional.Optionals.Oo
{
    /// <summary>
    /// The representation of 'No value'
    /// </summary>
    public sealed class Nothing<T> : Optional<T>
    {
        public override bool IsSomething => false;

        public override bool IsNothing => true;

        public override T Value => throw new InvalidOperationException("Optional is Nothing.");

        public override string ToString()
        {
            return $"Nothing of {typeof(T).Name}";
        }
    }
}
