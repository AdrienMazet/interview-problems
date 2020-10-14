using System;
using Xunit;
using Exercices;
using System.Numerics;

namespace Exercices.Tests
{
    public class Fibonacci_Should
    {
        private readonly Fibonacci _fibonacci;

        public Fibonacci_Should()
        {
            _fibonacci = new Fibonacci();
        }

        [Fact]
        public void Return0GivenNegativeValues()
        {
            Assert.Equal(0, _fibonacci.GetValue(-1));
        }

        [Fact]
        public void Return0Given0()
        {
            Assert.Equal(0, _fibonacci.GetValue(0));
        }

        [Fact]
        public void Return1Given1()
        {
            Assert.Equal(1, _fibonacci.GetValue(1));
        }

        [Fact]
        public void Return1Given2()
        {
            Assert.Equal(1, _fibonacci.GetValue(2));
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(-25, 0)]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(11, 89)]
        [InlineData(25, 75025)]
        public void ReturnRightFibonacciValues(int n, long expected)
        {
            Assert.Equal(expected, _fibonacci.GetValue(n));
        }

        [Fact]
        public void ReturnRightValueGiven100()
        {
            BigInteger a = BigInteger.Parse("354224848179261915075");
            Assert.Equal<BigInteger>(a, _fibonacci.GetValue(100));
        }
    }
}
