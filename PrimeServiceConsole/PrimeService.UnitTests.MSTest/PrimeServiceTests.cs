using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeService.UnitTests.MSTest
{
    [TestClass]
    public class PrimeServiceTests
    {
        private readonly PrimeServiceConsole.PrimeService _primeService;

        public PrimeServiceTests()
        {
            _primeService = new PrimeServiceConsole.PrimeService();
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);
            Assert.IsFalse(result, "1 should not be prime.");
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void ReturnFalseGivenValueLessThan2(int value)
        {
            var result = _primeService.IsPrime(value);
            Assert.IsFalse(result, $"{value} should not be prime.");
        }
    }
}
