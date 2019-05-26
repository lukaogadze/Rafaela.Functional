using NUnit.Framework;
using Rafaela.Functional.Optionals.Fp;
using System;

namespace Rafaela.Functional.Test.Optionals.Fp
{
    [TestFixture]
    public class NoneShould
    {
        [Test]
        public void Return_True_On_IsNone()
        {
            var none = Option.None<string>();

            var actual = none.IsNone;

            Assert.IsTrue(actual);
        }

        [Test]
        public void Return_False_On_IsSome()
        {
            var none = Option.None<string>();

            var actual = none.IsSome;

            Assert.IsFalse(actual);
        }

        [Test]
        public void Raise_InvalidOperationException_When_Accessing_Value()
        {
            var none = Option.None<string>();

            Assert.Throws<InvalidOperationException>(() =>
            {
                var data = none.Value;
            });
        }

        [Test]
        public void Have_Overriden_ToString()
        {
            var none = Option.None<int>();

            var actual = none.ToString();

            Assert.AreEqual($"None of {typeof(int).Name}", actual);
        }
    }
}