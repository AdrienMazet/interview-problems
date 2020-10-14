using System;
using Xunit;
using Exercices;
using System.Collections.Generic;

// Added this pragma to ignore warnings about dummy parameters '_' unused in theory tests.
#pragma warning disable xUnit1026 
namespace Exercices.Tests
{
    public class Duplicates_Should
    {
        private readonly Duplicates _duplicates;

        public Duplicates_Should()
        {
            _duplicates = new Duplicates();
        }

        [Fact]
        public void ReturnFalseGivenNullValue()
        {
            Assert.False(_duplicates.ContainsDuplicates(null));
        }

        [Fact]
        public void ReturnFalseGivenEmptyList()
        {
            Assert.False(_duplicates.ContainsDuplicates(new List<string>()));
        }

        [Theory]
        [InlineData(new string[] { "1", "1" }, true)]
        [InlineData(new string[] { "1", "a", "", "0", "" }, true)]
        [InlineData(new string[] { "A", "b", "c", "d", "a" }, true)]
        [InlineData(new string[] { "AA", "b", "c", "d", "aa" }, true)]
        public void ReturnTrueGivenListWithDuplicates(string[] tab, bool _)
        {
            Assert.True(_duplicates.ContainsDuplicates(new List<string>(tab)));
        }

        [Theory]
        [InlineData(new string[] { }, true)]
        [InlineData(new string[] { "1", "2" }, true)]
        [InlineData(new string[] { "1", "a", "b", "0", "c" }, true)]
        [InlineData(new string[] { "A", "b", "c", "d", "e" }, true)]
        [InlineData(new string[] { "AA", "b", "c", "d", "efgh" }, true)]
        public void ReturnFalseGivenListWithoutDuplicates(string[] tab, bool _)
        {
            Assert.False(_duplicates.ContainsDuplicates(new List<string>(tab)));
        }
    }
}
