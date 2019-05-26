using NUnit.Framework;
using Rafaela.Functional.Results;

namespace Rafaela.Functional.Test.Results
{
    [TestFixture]
    public class SuccessShould
    {
        [Test]
        public void Return_True_On_IsSucceeded()
        {
            var success = Result.Success("");

            var actual = success.IsSucceeded;

            Assert.IsTrue(actual);
        }

        [Test]
        public void Return_False_On_IsFailed()
        {
            var success = Result.Success("");

            var actual = success.IsFailed;

            Assert.IsFalse(actual);
        }

        [Test]
        public void Get_Value()
        {
            const string name = "luka";
            var success = Result.Success(name);

            var actual = success.Value;

            Assert.AreEqual(name, actual);
        }

        [Test]
        public void Have_Overriden_ToString()
        {
            var success = Result.Success("");

            var actual = success.ToString();

            Assert.AreEqual($"Successful Result of {typeof(string).Name}", actual);
        }

    }
}
