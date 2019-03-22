using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public sealed class None<T> : Option<T>
    {
        public override bool IsSome => false;

        public override bool IsNone => true;

        public override T Value => throw new NullReferenceException("Option is None.");

        public override string ToString()
        {
            return $"None of {typeof(T).Name}";
        }
    }
}
