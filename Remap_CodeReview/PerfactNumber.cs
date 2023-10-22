using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_CodeReview
{
    internal class PerfactNumber
    {
        public static void CalculatePerfectNumber(int n)
        {
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if(n % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (n == sum)
            {
                Console.WriteLine("{0} is a perfact number", n);
            }
            else
            {
                Console.WriteLine("{0} is not a perfact number", n);
            }

        }
    }
}
