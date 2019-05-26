using NUnit.Framework;
using Rafaela.Functional.Optionals.Oo;

namespace Rafaela.Functional.Test.Optionals.Oo
{
    [TestFixture]
    public class SomethingShould
    {
        [Test]
        public void Return_True_On_IsSomething()
        {
            var something = Optional.Something("");

            var actual = something.IsSomething;

            Assert.IsTrue(actual);
        }

        [Test]
        public void Return_False_On_IsNone()
        {
            var something = Optional.Something("");

            var actual = something.IsNothing;

            Assert.IsFalse(actual);
        }

        [Test]
        public void Get_Value()
        {
            const string name = "luka";
            var something = Optional.Something(name);

            var actual = something.Value;

            Assert.AreEqual(name, actual);
        }

        [Test]
        public void Have_Overriden_ToString()
        {
            var something = Optional.Something("");

            var actual = something.ToString();

            Assert.AreEqual($"Something of {typeof(string).Name}", actual);
        }

    }
}
