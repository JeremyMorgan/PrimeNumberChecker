﻿namespace PrimeChecker.Tests
{
    class NumberContainer
    {
        public int[] KnownPrimes => _knownPrimes;
        public int[] NotPrimes => _notPrimes;

        // a list of known prime numbers 
        private readonly int[] _knownPrimes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103 };
        // a list of known non prime numbers
        private readonly int[] _notPrimes = { 0, 1, 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20, 21, 22, 24, 25, 26, 27, 28, 30, 32, 33, 34, 35, 36, 38, 39 };
    }
}
