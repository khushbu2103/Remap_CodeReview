using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Remap_CodeReview
{
    internal class ReverseSatatementAndPalindrome
    {
        public static string ReverseWord(string word)
        {
            string reverse = "";
            foreach (char latter in word)
            {
                reverse = latter + reverse;

            }
            return reverse;
        }
        public static void ReverseEachWordInSamePosition(string statement)
        {
            String reverse = "";
            char[] delimeters = { ' ', ',', ':' };
            string[] Words = statement.Split(delimeters);
            foreach (string Word in Words)
            {
                string r = ReverseWord(Word);
                reverse = reverse + r + " ";
            }
            Console.Write(reverse);
        }
       

        public static int ReverseNumber(int number)
        {
            int reminder = 0;
            int reverse = 0;
            while( number != 0)
            {
                reminder = number % 10;
                reverse = (reverse * 10) + reminder;
                number = number / 10;
            }
            return reverse;
        }
        public static void PalindromNumber(int number)
        {
            int output = ReverseNumber(number);
            if (number == output)
            {
                Console.WriteLine("{0} is palindrom number", number);
            }
            else
                Console.WriteLine("{0} is not palindrom number", number);
        }
    }
}
