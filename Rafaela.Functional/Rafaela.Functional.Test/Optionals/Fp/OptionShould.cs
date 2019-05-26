using NUnit.Framework;
using Rafaela.Functional.Optionals.Fp;

namespace Rafaela.Functional.Test.Optionals.Fp
{
    [TestFixture]
    public class OptionShould
    {
        [Test]
        public void Should_Return_Some()
        {
            var some = Option.Some("");


            Assert.IsInstanceOf<Some<string>>(some);
        }

        [Test]
        public void Should_Return_None()
        {
            var none = Option.None<string>();


            Assert.IsInstanceOf<None<string>>(none);
        }
    }
}
