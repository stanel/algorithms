using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Recursion
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void FirstFibonacciNumberCanBeRetrieved()
        {
            AssertFibonacciNumberAtPositionIs(0, 0);
        }

        [TestMethod]
        public void SecondFibonacciNumberCanBeRetrieved()
        {
            AssertFibonacciNumberAtPositionIs(1, 1);
        }

        [TestMethod]
        public void ThirdFibonacciNumberCanBeRetrieved()
        {
            AssertFibonacciNumberAtPositionIs(1, 2);
        }

        [TestMethod]
        public void FibonacciNumberAtPositionEightCanBeRetrieved()
        {
            AssertFibonacciNumberAtPositionIs(21, 8);
        }

        private void AssertFibonacciNumberAtPositionIs(int expectedNumber, int position)
        {
            Fibonacci fib = new Fibonacci();

            int number = fib.GetNumber(position);

            Assert.AreEqual(expectedNumber, number);

        }
    }
}
