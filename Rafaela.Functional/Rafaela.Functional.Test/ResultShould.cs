using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rafaela.Functional.Test
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
