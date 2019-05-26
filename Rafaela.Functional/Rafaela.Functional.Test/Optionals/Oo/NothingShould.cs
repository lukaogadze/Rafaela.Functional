using NUnit.Framework;
using Rafaela.Functional.Optionals.Oo;
using System;

namespace Rafaela.Functional.Test.Optionals.Oo
{
    [TestFixture]
    public class NothingShould
    {
        [Test]
        public void Return_True_On_IsNothing()
        {
            var nothing = Optional.Nothing<string>();

            var actual = nothing.IsNothing;

            Assert.IsTrue(actual);
        }

        [Test]
        public void Return_False_On_IsSome()
        {
            var nothing = Optional.Nothing<string>();

            var actual = nothing.IsSomething;

            Assert.IsFalse(actual);
        }

        [Test]
        public void Raise_InvalidOperationException_When_Accessing_Value()
        {
            var nothing = Optional.Nothing<string>();

            Assert.Throws<InvalidOperationException>(() =>
            {
                var data = nothing.Value;
            });
        }

        [Test]
        public void Have_Overriden_ToString()
        {
            var nothing = Optional.Nothing<int>();

            var actual = nothing.ToString();

            Assert.AreEqual($"Nothing of {typeof(int).Name}", actual);
        }
    }
}