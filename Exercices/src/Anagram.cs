using System;
using System.Collections.Generic;

namespace Exercices
{
    public class Anagram
    {
        /// <summary>  
        ///  Check if the two words are anagrams having wild cards
        /// </summary>
        /// <param name="word1">word 1</param>
        /// <param name="word2">word 2</param>
        /// <param name="nbWildCards">number of wild cards (jokers)</param>
        /// <returns>Returns true if the words are anagrams, false if not</returns>
        public bool AreAnagrams(string word1, string word2, int nbWildCards)
        {
            if (word1 == null || word2 == null || nbWildCards < 0) return false;

            IDictionary<char, int> mapWord1 = new Dictionary<char, int>();
            foreach (var c in word1)
            {
                if (c == ' ') continue;

                if (mapWord1.ContainsKey(c))
                {
                    mapWord1[c] = mapWord1[c] + 1;
                }
                else
                {
                    mapWord1[c] = 1;
                }
            }

            foreach (var c in word2)
            {
                if (c == ' ') continue;

                if (!mapWord1.ContainsKey(c) || mapWord1[c] == 0)
                {
                    if (nbWildCards == 0) return false;

                    nbWildCards--;
                    continue;
                }

                mapWord1[c] = mapWord1[c] - 1;
            }

            foreach (var kv in mapWord1)
            {
                if (kv.Value != 0)
                {
                    if (nbWildCards == 0 || kv.Value > nbWildCards) return false;
                    nbWildCards -= kv.Value;
                }
            }

            return true;
        }
    }
}
