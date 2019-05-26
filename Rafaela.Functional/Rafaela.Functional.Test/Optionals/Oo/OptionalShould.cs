using NUnit.Framework;
using Rafaela.Functional.Optionals.Oo;

namespace Rafaela.Functional.Test.Optionals.Oo
{
    [TestFixture]
    public class OptionalShould
    {
        [Test]
        public void Should_Return_Something()
        {
            var something = Optional.Something("");


            Assert.IsInstanceOf<Something<string>>(something);
        }

        [Test]
        public void Should_Return_Nothing()
        {
            var nothing = Optional.Nothing<string>();


            Assert.IsInstanceOf<Nothing<string>>(nothing);
        }
    }
}
