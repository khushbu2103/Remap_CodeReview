using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_CodeReview
{
    internal class SwapeTwoDigit
    {
        public static void Swape()
        {
            int n1 = 2;
            int n2 = 4;
            
            Console.Write("{0} {1}", n1, n2);
            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
            Console.Write("\nAfter swaping : {0} {1}", n1, n2);
        }
    }
}
