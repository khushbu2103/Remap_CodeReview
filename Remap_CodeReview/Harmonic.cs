using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_CodeReview
{
    internal class Harmonic
    {
        public static void HramonicNumber()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            double Sum = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i != n)
                {
                    Console.Write("1/{0} + ", i);
                }
                else if (i == n)
                {
                    Console.Write("1/{0}", i);
                }
                Sum = Sum + 1 / ((double)i);
            }
            Console.WriteLine("\nNth harmonic value is " + Sum);
        }
    }
}
