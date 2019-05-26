using System;

namespace Rafaela.Functional.Optionals.Fp
{
    /// <summary>
    /// The representation of 'No value'
    /// </summary>
    public sealed class None<T> : Option<T>
    {
        public override bool IsSome => false;

        public override bool IsNone => true;

        public override T Value => throw new InvalidOperationException("Option is None.");

        public override string ToString()
        {
            return $"None of {typeof(T).Name}";
        }
    }
}
