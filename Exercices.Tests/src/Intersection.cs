using System;
using Xunit;
using Exercices;
using System.Collections.Generic;

// Added this pragma to ignore warnings about dummy parameters '_' unused in theory tests.
#pragma warning disable xUnit1026 
namespace Exercices.Tests
{
    public class Intersection_Should
    {
        private readonly Intersection _intersection;

        public Intersection_Should()
        {
            _intersection = new Intersection();
        }

        [Fact]
        public void ReturnFalseGivenNullLists()
        {
            Assert.False(_intersection.HaveCommonValues(null, null));
        }

        [Fact]
        public void ReturnFalseGivenEmptyLists()
        {
            Assert.False(_intersection.HaveCommonValues(new List<string>(), new List<string>()));
        }

        [Theory]
        [InlineData(new string[] { "" }, new string[] { "" }, true)]
        [InlineData(new string[] { "a", "B", "C", "A" }, new string[] { "z", "z", "b", "a" }, true)]
        [InlineData(new string[] { "a", " ", "C", "A" }, new string[] { "z", " ", "b", "part" }, true)]
        public void ReturnTrueGivenListsWithCommonValues(string[] tab1, string[] tab2, bool _)
        {
            Assert.True(_intersection.HaveCommonValues(new List<string>(tab1), new List<string>(tab2)));
        }

        [Theory]
        [InlineData(new string[] { }, new string[] { }, true)]
        [InlineData(new string[] { "" }, new string[] { " " }, true)]
        [InlineData(new string[] { "a", "B", "C", "A" }, new string[] { "d", "E", "F", "D" }, true)]
        [InlineData(new string[] { "a", "B", "C" }, new string[] { "d", "E", "F", "D" }, true)]
        [InlineData(new string[] { "a", " ", "C", "A" }, new string[] { "z", "  ", "b", "part" }, true)]
        [InlineData(new string[] { "a", " ", "C", "A" }, new string[] { "z", "", "b", "part" }, true)]
        public void ReturnFalseGivenListsWithoutCommonValues(string[] tab1, string[] tab2, bool _)
        {
            Assert.False(_intersection.HaveCommonValues(new List<string>(tab1), new List<string>(tab2)));
        }
    }
}
