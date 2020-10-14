using System;
using Xunit;
using Exercices;

namespace Exercices.Tests
{
    public class FindSum_Should
    {
        private readonly FindSum _findSum;

        public FindSum_Should()
        {
            _findSum = new FindSum();
        }

        [Fact]
        public void ReturnFalseForNullArray()
        {
            Assert.False(_findSum.Exists(null, 1));
        }

        [Fact]
        public void ReturnFalseForArrayLengthLessThan2()
        {
            Assert.False(_findSum.Exists(new int[] { }, 1));
            Assert.False(_findSum.Exists(new int[] { 1 }, 1));
        }

        [Theory]
        [InlineData(new int[] { 1, 2 }, 3)]
        [InlineData(new int[] { 2, 3, -2 }, 1)]
        [InlineData(new int[] { 2, 3, -7, -4, 1 }, 3)]
        [InlineData(new int[] { -2, 2, -3, 3, 1 }, 0)]
        [InlineData(new int[] { -2, 2, -3, 3, -4 }, -7)]
        public void ReturnTrueForGivenValues(int[] array, int x)
        {
            Assert.True(_findSum.Exists(array, x));
        }

        [Theory]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, 4)]
        [InlineData(new int[] { 2, 3, -2 }, -2)]
        public void ReturnFalseForGivenValues(int[] array, int x)
        {
            Assert.False(_findSum.Exists(array, x));
        }
    }
}
