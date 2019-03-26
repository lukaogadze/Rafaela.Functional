using System;

namespace Rafaela.Functional
{
    /// <summary>
    /// The representation of "Failed result"
    /// </summary>
    public sealed class Fail<T> : Result<T>
    {
        public override bool IsSucceeded => false;

        public override bool IsFailed => true;

        public override T Value => throw new NullReferenceException("Result is Fail.");

        public override string ToString()
        {
            return $"Result of {typeof(T).Name}";
        }
    }
}
