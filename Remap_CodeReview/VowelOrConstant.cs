using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_CodeReview
{
    internal class VowelOrConstant
    {
        public static void Vowel_Constant()
        {
            Console.WriteLine("Enter any later");
            char alphabet = char.Parse(Console.ReadLine());
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u' ||
                alphabet == 'A' || alphabet == 'E' || alphabet == 'I' || alphabet == 'O' || alphabet == 'U')
            {
                Console.WriteLine(alphabet + " is vowel");
            }
            else
            {
                Console.WriteLine(alphabet + " is Consonant");
            }
        }
    }
}

