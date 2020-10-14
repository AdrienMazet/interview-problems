using System;
using Xunit;
using Exercices;

namespace Exercices.Tests
{
    public class Palindrome_Should
    {
        private readonly Palindrome _palindrome;

        public Palindrome_Should()
        {
            _palindrome = new Palindrome();
        }


        [Fact]
        public void ReturnFalseGivenNullString()
        {
            Assert.False(_palindrome.IsPalindrome(null));
        }

        [Fact]
        public void ReturnTrueGivenEmptyString()
        {
            Assert.True(_palindrome.IsPalindrome(""));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("  ")]
        [InlineData("a")]
        [InlineData("aA")]
        [InlineData("aAa")]
        [InlineData("aAaA")]
        [InlineData("aAaAa")]
        [InlineData("laval")]
        [InlineData("Maoam")]
        public void ReturnTrueGivenPalindrome(string word)
        {
            Assert.True(_palindrome.IsPalindrome(word));
        }

        [Theory]
        [InlineData("-a")]
        [InlineData("ab")]
        [InlineData("  g")]
        [InlineData("aAc")]
        [InlineData("aabbA")]
        [InlineData("zaza")]
        public void ReturnFalseGivenNotPalindrome(string word)
        {
            Assert.False(_palindrome.IsPalindrome(word));
        }
    }
}
