using System;
using NUnit.Framework;

namespace Rafaela.Functional.Test
{
    [TestFixture]
    public class FailShould
    {
        [Test]
        public void Return_True_On_IsFailed()
        {
            var fail = Result.Fail<string>();

            var actual = fail.IsFailed;

            Assert.IsTrue(actual);
        }

        [Test]
        public void Return_False_On_IsSucceeded()
        {
            var fail = Result.Fail<string>();

            var actual = fail.IsSucceeded;

            Assert.IsFalse(actual);
        }

        [Test]
        public void Raise_NullReferenceException_When_Accessing_Value()
        {
            var fail = Result.Fail<string>();

            Assert.Throws<NullReferenceException>(() =>
            {
                var data = fail.Value;
            });
        }

        [Test]
        public void Have_Overriden_ToString()
        {
            var fail = Result.Fail<string>();

            var actual = fail.ToString();

            Assert.AreEqual($"Result of {typeof(string).Name}", actual);
        }
    }
}