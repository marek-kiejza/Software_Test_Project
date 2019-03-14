using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace InsuranceService
{
    [TestFixture]
    class Test_InsuranceService
    {
        InsuranceService sut;

        [SetUp]
        public void Initialise()
        {
            sut = new InsuranceService();
        }
       
        [TestCase(20, "female", ExpectedResult = 5.0f)]
        [TestCase(38, "female", ExpectedResult = 3.5f)]
        [TestCase(60, "female", ExpectedResult = 1.75f)]
        [TestCase(30, "male", ExpectedResult = 6.0f)]
        [TestCase(46, "male", ExpectedResult = 5.0f)]
        [TestCase(70, "male", ExpectedResult = 2.5f)]
        [TestCase(13, "female", ExpectedResult = 0.0f)]
        [TestCase(16, "male", ExpectedResult = 0.0f)]
        public float Test_CalcPremium_many(int a, string b)
        {
            float actualResult = sut.CalcPremium(a, b);
            return actualResult;
        }
    }
}
