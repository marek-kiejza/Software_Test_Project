using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApp1
{
    [TestFixture]
    class TestQ4cs
    {

        WhiteBox sut;

       [SetUp]
        public void Inicialise()
        {
            sut = new WhiteBox();
        }
        [Test]
        public void Test_q4_1()
        {
            string actualResult = sut.ProQ4(75, 150);
            Assert.That(actualResult, Is.EqualTo("Hello"));
        }

        [Test]
        public void Test_q4_2()
        {
            string actualResult = sut.ProQ4(101, 150);
            Assert.That(actualResult, Is.EqualTo("P is Large"));
        }
    }

 
}
