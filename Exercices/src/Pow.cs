using System;

namespace Exercices
{
    public class Pow
    {
        /// <summary>  
        ///  Find the power of the number x
        /// </summary>
        /// <param name="x">number</param>
        /// <param name="n">power</param>
        /// <returns>Returns the power of x (x^n)</returns>
        public double GetValue(double x, int n)
        {
            if (n == 0) return 1;
            if (n == 1) return x;

            if (n < 0)
            {
                return 1 / GetValue(x, n * -1);
            }

            int half = n / 2;
            double res = GetValue(x, half);

            if (n % 2 != 0)
            {
                return res * res * x;
            }
            else
            {
                return res * res;
            }
        }
    }
}