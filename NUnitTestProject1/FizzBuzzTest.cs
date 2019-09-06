using System;
using NUnit.Framework;
using NUnitTestProject1;

namespace Tests
{

    public class FizzBuzzTest
    {


        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Should_Return_Fizz_when_number_is_Divisible_by_3()
        {

            string result = FizzBuzz.GetAnswserFor(3);

            Assert.AreEqual(result, "Fizz");

        }

        [Test]
        public void Should_Return_Buzz_when_number_is_Divisible_by_5()
        {

            string result = FizzBuzz.GetAnswserFor(5);

            Assert.AreEqual(result, "Buzz");

        }

        [Test]
        public void Should_Return_FizzBuzz_when_number_is_Divisible_by_3_and_5()
        {

            string result = FizzBuzz.GetAnswserFor(15);

            Assert.AreEqual(result, "FizzBuzz");

        }

        [Test]
        public void Should_Return_stringEmpty_when_number_is_not_Divisible_by_3_and_5()
        {

            string result = FizzBuzz.GetAnswserFor(0);

            Assert.AreEqual(result, string.Empty);

        }
    }
}