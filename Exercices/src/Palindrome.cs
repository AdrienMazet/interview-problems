using System;
using System.Collections.Generic;

namespace Exercices
{
    public class Palindrome
    {
        /// <summary>  
        ///  Check if the word is a palindrome
        /// </summary>
        /// <param name="word">word</param>
        /// <returns>Returns true if the word is a palindrome, false if not</returns>
        public bool IsPalindrome(string word)
        {
            if (word == null) return false;

            string wordIgnoreCase = word.ToLower();
            char[] wordAsArray = wordIgnoreCase.ToCharArray();
            Stack<char> stack = new Stack<char>();

            foreach (char c in wordAsArray)
            {
                stack.Push(c);
            }

            foreach (char c in wordAsArray)
            {
                char popped = stack.Pop();
                if (c != popped) return false;
            }

            return true;
        }
    }
}
