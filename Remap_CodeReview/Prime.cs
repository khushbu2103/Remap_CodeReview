using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_CodeReview
{
    internal class Prime
    {
        public static void PrimeNumber(int n1)
        {
            int factorCount = 0;
            for (int i = 1; i <= n1; i++)
            {
                if (n1 % i == 0)
                    factorCount++;
            }
            if (factorCount == 2)
                Console.WriteLine("{0} is a prime number", n1);
            else
                Console.WriteLine("{0} is not a prime number", n1);
        }
    }
}
