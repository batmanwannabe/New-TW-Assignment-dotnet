using System.Collections.Generic;
using TW_Assignment.Source.prime;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Source.prime
{
    /**
     * Test for @{@link Prime}
     *
     * Write an algorithm that returns all the prime numbers between 0 and N where N is the user input.
     */
    [TestClass]
    //Should return the list of prime numbers Upto N
    public class PrimeTest
    {

        [TestMethod]
        public void shouldReturnEmptyListWhen_N_IsZero()
        {
            int N = 0;
            Prime prime = new Prime();
            List<int> primes = prime.FindPrimesUpto(N);
            List<int> expectedPrimes = new List<int>();
            CollectionAssert.AreEqual(expectedPrimes, primes);
        }

        [TestMethod]
        public void shouldReturnTwoWhen_N_IsTwo()
        {
            int N = 2;
            Prime prime = new Prime();
            List<int> primes = prime.FindPrimesUpto(N);
            List<int> expectedPrimes = new List<int> { 2 };
            CollectionAssert.AreEqual(expectedPrimes, primes);
        }

        [TestMethod]
        public void shouldReturnPrimeNumbersTillTwentyWhenNIsTwenty()
        {
            int N = 20;
            Prime prime = new Prime();
            List<int> primes = prime.FindPrimesUpto(N);
            List<int> expectedPrimes = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19 };
            CollectionAssert.AreEqual(expectedPrimes, primes);
        }

        [TestMethod]
        public void shouldReturnEmptyWhenNIsMinusFive()
        {
            int N = -5;
            Prime prime = new Prime();
            List<int> primes = prime.FindPrimesUpto(N);
            List<int> expectedPrimes = new List<int>();
            CollectionAssert.AreEqual(expectedPrimes, primes);
        }

    }

}
