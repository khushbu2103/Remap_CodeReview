using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_CodeReview
{
    internal class CalculateFactor
    {
        public static void Factors()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    Console.WriteLine(i);
                else
                    Console.WriteLine();
            }
        }
    }
}
