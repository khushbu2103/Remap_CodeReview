using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_CodeReview
{
    internal class ReverseNumber
    {
        public static void ReverseEachNumber(int n2) //567
        {
            int reminder = 0;
            int reverse = 0;
            for (int i = 0; i < n2; i++)
            {
                reminder = n2 % 10;  //7;

                reverse = (reverse * 10) + reminder; //7;

                n2 = n2 / 10;
            }
            Console.WriteLine( reverse);
            

        }
    }
}
