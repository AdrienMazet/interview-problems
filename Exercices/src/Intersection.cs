using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercices
{
    public class Intersection
    {
        /// <summary>  
        ///  Check if the lists have common values
        /// </summary>
        /// <param name="list1">list1</param>
        /// <param name="list2">list2</param>
        /// <returns>Returns true if the lists have common values, false if not</returns>
        public bool HaveCommonValues(IList<string> list1, IList<string> list2)
        {
            if (list1 == null || list1.Count == 0) return false;
            if (list2 == null || list2.Count == 0) return false;

            ISet<string> set1 = new HashSet<string>(list1.Select(str => str.ToLower()));

            foreach (string str in list2)
            {
                if (set1.Contains(str))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
