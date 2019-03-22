using NUnit.Framework;

namespace Rafaela.Functional.Test
{
    [TestFixture]
    public class SomeShould
    {
        [Test]
        public void Return_True_On_IsSome()
        {
            var some = Option.Some("");

            var actual = some.IsSome;

            Assert.IsTrue(actual);
        }

        [Test]
        public void Return_False_On_IsNone()
        {
            var some = Option.Some("");

            var actual = some.IsNone;

            Assert.IsFalse(actual);
        }

        [Test]
        public void Get_Value()
        {
            const string name = "luka";
            var some = Option.Some(name);

            var actual = some.Value;

            Assert.AreEqual(name, actual);
        }

        [Test]
        public void Have_Overriden_ToString()
        {
            var some = Option.Some("");

            var actual = some.ToString();

            Assert.AreEqual($"Some of {typeof(string).Name}", actual);
        }

    }
}
