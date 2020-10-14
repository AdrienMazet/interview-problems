using System;
using System.Collections.Generic;

namespace Exercices
{
    public class FindSum
    {
        /// <summary>  
        ///  Check if the sum 'x' of two distinct indexes exist in the array
        /// </summary>
        /// <param name="array">array of distinct numbers</param>
        /// <param name="x">sum to find</param>
        /// <returns>Returns true if the sum exists, false if not</returns>
        public bool Exists(int[] array, int x)
        {
            if (array == null) return false;
            if (array.Length < 2) return false;
            //We need to find x where x = a + b
            // so x - a = b
            // we know all the possible values of a (i.e all the possible values in the array given in input)
            // so we just need to find b where b = x - a

            // 1 - Create a dictionary with the value of a = array[i] as a key and index as the value (to be able to check if these values are distinct)
            IDictionary<int, int> mapIndexDifferences = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                int a = array[i];
                mapIndexDifferences.Add(a, i);
            }

            // 2 - find if b exist. b = x - a
            for (int i = 0; i < array.Length; i++)
            {
                int b = x - array[i];
                if (mapIndexDifferences.ContainsKey(b))
                {
                    // check that it's not the same index
                    if (mapIndexDifferences[b] != i)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
