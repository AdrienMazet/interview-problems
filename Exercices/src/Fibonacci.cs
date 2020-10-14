using System;
using System.Numerics;

namespace Exercices
{
    public class Fibonacci
    {

        /// <summary>  
        ///  Compute the value of fibonacci(n) 
        ///  with f(0) = 0, f(1) = 1, f(2) = 1  
        /// </summary>
        /// <param name="n">value to compute</param>
        /// <returns>Returns the value of fibonacci(n)</returns>
        public BigInteger GetValue(int n)
        {
            // 1 - Test with recursive implementation
            //return FiboRec(n);

            // 2 - Test with iterative implementation
            //return FiboIterative(n);

            // 3 - Test with dynamic programming implementation
            return FiboDynamicProgramming(n);
        }

        // Complexity O(2^n)
        private BigInteger FiboRec(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;

            return FiboRec(n - 2) + FiboRec(n - 1);
        }

        // Complexity O(n)
        private BigInteger FiboIterative(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;

            BigInteger a = 1, b = 1, tmp = 0;

            for (int i = 3; i <= n; i++)
            {
                tmp = a + b;
                a = b;
                b = tmp;
            }

            return b;
        }

        // Complexity O(n)
        private BigInteger FiboDynamicProgramming(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 1;

            // As we consider f(0) = 0, init the array with n+1 values
            BigInteger[] fibo = new BigInteger[n + 1];
            fibo[0] = 0;
            fibo[1] = 1;
            fibo[2] = 1;

            for (int i = 3; i <= n; i++)
            {
                fibo[i] = fibo[i - 2] + fibo[i - 1];
            }

            return fibo[n];
        }
    }
}
