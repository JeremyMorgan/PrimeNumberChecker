using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeChecker.Tests
{
    [TestClass]
    public class TestCheckForPrime
    {
        readonly NumberContainer _testNumbers = new NumberContainer();

        [TestMethod]
        public void CheckForExceptionOnIncorrectInput()
        {
            // This test is to check to make sure sure method fails if we pass a letter to it
            // Note: merely enforcing current design, an override may give a false failure here

            try{
                CheckForPrime.IsNumberPrime(Convert.ToInt32("A"));
                Assert.Fail("Exception was not thrown");
            }
            catch (FormatException fe){
                Assert.AreEqual("Input string was not in a correct format.", fe.Message);
            }
            catch (Exception ex){
                // generic exception
                Assert.Fail("Unexpected Exception, {0} was caught instead", ex.GetType());
            }
        }

        [TestMethod]
        public void CheckKnownPrimeNumbers()
        {
            // this will check a list of known prime numbers
            foreach (int num in _testNumbers.KnownPrimes){
                Assert.IsTrue(CheckForPrime.IsNumberPrime(num), message: $"{num} was returned as not a prime number");
            }
        }

        [TestMethod]
        public void CheckKnownNonPrimeNumbers()
        {
            foreach (int num in _testNumbers.NotPrimes){
                Assert.IsFalse(CheckForPrime.IsNumberPrime(num), message: $"{num} was returned as a prime number");
            }
        }
    }
}
