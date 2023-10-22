using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Remap_CodeReview
{
    internal class Power2
    {
        public static void PowerOf2(int n3)
        {
            if(n3<0 && n3 >31)
            {
                Console.WriteLine("N must be between 0 and 30:");
                return;
            }
            else
            {
                for(int i = 0; i < n3; i++)
                {
                    Console.WriteLine($"2^" + i + " = " + Math.Pow(2, i));
                  //Console.WriteLine($"2^" + i + " = " + Math.Pow(2, i));
                }
            }
        }
    }
}
