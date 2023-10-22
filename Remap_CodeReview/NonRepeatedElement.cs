using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_CodeReview
{
    internal class NonRepeatedElement
    {
        public static void PrintNonRepeatedElement()
        {
            //string[] arr = new string[5];
           
            string[] arr = { "25", "false", "25", "true", "false", "11.21", "25"};
            int len = arr.Length;
           
            for (int i = 0; i < len; i++)
            {
                bool isUnique = true;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    Console.WriteLine(arr[i]);
                }
            }
           
        }
    }
}
