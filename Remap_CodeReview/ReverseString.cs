using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_CodeReview
{
    internal class ReverseString
    {
        public static string Reverse(string s)
        {
            int len = s.Length;
            string reverse = "";
            for(int i = len-1; i >= 0; i--)
            {
                reverse = reverse + s[i];
            }
            return reverse;
        }
        public static void ReverseAtItsPosition()
        {
            string[] arr = new string[3];
            arr[0] = "khushi";
            arr[1] = "raj";
            arr[2] = "soni";
            for (int i = 0; i < 3; i++)
            {
                 string reversedString = Reverse(arr[i]);
                Console.WriteLine(reversedString);
            }
           
        }
    }
}
