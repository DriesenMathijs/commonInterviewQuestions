using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Fibonacci.Tests
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void FibonacciIndex5()
        {
            List<int> givenResult = new List<int>()
            {
                0,1,1,2,3
            };

            var result = Fibonacci.FibonacciSequence(5);

            CollectionAssert.AreEqual(givenResult, result);
        }

        [TestMethod]
        public void FibonacciOneDigitAtATime10thDigit()
        {
            int givenResult = 55;

            var result = Fibonacci.OneAtDigitAtATime(10);

            Assert.AreEqual(givenResult, result);
        }
    }
}
