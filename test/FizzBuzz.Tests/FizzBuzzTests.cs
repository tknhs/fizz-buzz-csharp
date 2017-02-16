using System;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    class FizzBuzzTests
    {
        [TestCase(3)]
        [TestCase(6)]
        public void FizzTest(int i)
        {
            Assert.AreEqual("Fizz", FizzBuzz.Judge(i));
        }

        [TestCase(5)]
        [TestCase(10)]
        public void BuzzTest(int i)
        {
            Assert.AreEqual("Buzz", FizzBuzz.Judge(i));
        }

        [TestCase(15)]
        [TestCase(30)]
        public void FizzBuzzTest(int i)
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.Judge(i));
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(4)]
        public void ElseTest(int i)
        {
            Assert.AreEqual(Convert.ToString(i), FizzBuzz.Judge(i));
        }
    }
}
