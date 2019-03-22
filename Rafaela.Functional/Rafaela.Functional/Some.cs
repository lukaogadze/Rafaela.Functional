using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public sealed class Some<T> : Option<T>
    {
        private readonly T _value;

        public Some(T value)
        {
            _value = value;
        }

        public override bool IsSome => true;

        public override bool IsNone => false;

        public override T Value => _value;

        public override string ToString()
        {
            return $"Some of {typeof(T).Name}";
        }
    }
}
