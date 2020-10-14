using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercices
{
    public class Duplicates
    {
        /// <summary>  
        ///  Check if the list contains duplicates 
        /// </summary>
        /// <param name="listOfValues">list</param>
        /// <returns>Returns true if the list contains duplicates, false if not</returns>
        public bool ContainsDuplicates(IList<string> listOfValues)
        {
            if (listOfValues == null) return false;

            ISet<string> set = new HashSet<string>(listOfValues.Select(str => str.ToLower()));
            return set.Count != listOfValues.Count;
        }
    }
}
