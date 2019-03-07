using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzBuzz_FizzBuzzOutput_Returns_Fizz_On_Multiples_Of_Three_Only()
        {
            int[] testArray = { 3, 6, 9, 12, 33, 99 };

            for (int i = 0; i < testArray.Length; i++)
            {
                FizzBuzz.FizzBuzz f = new FizzBuzz.FizzBuzz(testArray[i]);
                
                Assert.AreEqual("Fizz", f.Output);
            }
        }

        [TestMethod]
        public void FizzBuzz_FizzBuzzOutput_Returns_Buzz_On_Multiples_Of_Five_Only()
        {
            int[] testArray = { 5, 10, 20 };

            for (int i = 0; i < testArray.Length; i++)
            {
                FizzBuzz.FizzBuzz f = new FizzBuzz.FizzBuzz(testArray[i]);
                Assert.AreEqual("Buzz", f.Output);
            }
        }

        [TestMethod]
        public void FizzBuzz_FizzBuzzOutput_Returns_FizzBuzz_On_Multiples_Of_Fifteen_Only()
        {
            int[] testArray = { 15, 30, 45, 60, 75 };

            for (int i = 0; i < testArray.Length; i++)
            {
                FizzBuzz.FizzBuzz f = new FizzBuzz.FizzBuzz(testArray[i]);
                Assert.AreEqual("FizzBuzz", f.Output);
            }
        }
    }
}
