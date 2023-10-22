using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_CodeReview
{
    internal class UpperCase_LowerCase
    {
        public static void PrintInUpperCaseAndLowerCase()
        {
            Console.WriteLine("Enter any city name");
            string city = Convert.ToString(Console.ReadLine());

            city = city.ToLower();
            Console.WriteLine(city);
            city = city.ToUpper();
            Console.WriteLine(city);
        }
    }
}
