using NUnit.Framework;
using Rafaela.Functional.Results;

namespace Rafaela.Functional.Test.Results
{
    [TestFixture]
    public class ResultShould
    {
        [Test]
        public void Should_Return_Success()
        {
            var success = Result.Success("");


            Assert.IsInstanceOf<Success<string>>(success);
        }

        [Test]
        public void Should_Return_Fail()
        {
            var success = Result.Fail<string>();


            Assert.IsInstanceOf<Fail<string>>(success);
        }
    }
}
