using System;
using Xunit;
using Exercices;

namespace Exercices.Tests
{
    public class Pow_Should
    {
        private readonly Pow _pow;

        public Pow_Should()
        {
            _pow = new Pow();
        }

        [Theory]
        [InlineData(2, 0, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, -2, 0.25)]
        [InlineData(1, 1, 1)]
        [InlineData(10, 2, 100)]
        [InlineData(10, 3, 1000)]
        [InlineData(10, -3, 1.0 / 1000)]
        public void ComputeRightValue(double x, int n, double resExpected)
        {
            Assert.Equal(resExpected, _pow.GetValue(x, n));
        }
    }
}
