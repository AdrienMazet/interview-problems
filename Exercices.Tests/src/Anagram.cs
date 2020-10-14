using System;
using Xunit;
using Exercices;

namespace Exercices.Tests
{
    public class Anagram_Should
    {
        private readonly Anagram _anagram;

        public Anagram_Should()
        {
            _anagram = new Anagram();
        }

        [Fact]
        public void ReturnFalseForNullWords()
        {
            Assert.False(_anagram.AreAnagrams(null, "", 0));
            Assert.False(_anagram.AreAnagrams("", null, 0));
            Assert.False(_anagram.AreAnagrams(null, null, 0));
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("", "             ")]
        [InlineData("   ", "             ")]
        [InlineData("  abab ", "    abba         ")]
        [InlineData("ab ab", "abb a")]
        [InlineData("ab a  b", "abba")]
        public void ReturnTrueForAnagrams(string word1, string word2)
        {
            Assert.True(_anagram.AreAnagrams(word1, word2, 0));
        }

        [Theory]
        [InlineData("", "a")]
        [InlineData("", "     a        ")]
        [InlineData(" b  ", "             ")]
        [InlineData("  abab ", "    abbba         ")]
        [InlineData("ab ab z", "abb a")]
        [InlineData("ab aa b", "abba")]
        public void ReturnFalseForNonAnagrams(string word1, string word2)
        {
            Assert.False(_anagram.AreAnagrams(word1, word2, 0));
        }

        [Theory]
        [InlineData("", "a", 1)]
        [InlineData("a", "", 1)]
        [InlineData("a", "             ", 1)]
        [InlineData("   ", "             ", 1)]
        [InlineData("  abab ", "    abba         ", 1)]
        [InlineData("ab ab", "abb az", 1)]
        [InlineData("ab a  bc", "abba", 1)]
        public void ReturnTrueForAnagramsUsingWildcards(string word1, string word2, int nbWildCards)
        {
            Assert.True(_anagram.AreAnagrams(word1, word2, nbWildCards));
        }

        [Theory]
        [InlineData("", "ac", 1)]
        [InlineData("baa", "     a        ", 1)]
        [InlineData(" b c ", "      d       ", 1)]
        [InlineData("  abab ", "    ab bba c        ", 1)]
        public void ReturnFalseForNonAnagramsUsingWildcards(string word1, string word2, int nbWildCards)
        {
            Assert.False(_anagram.AreAnagrams(word1, word2, nbWildCards));
        }
    }
}
