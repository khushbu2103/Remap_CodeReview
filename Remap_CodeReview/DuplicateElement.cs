using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_CodeReview
{
    internal class DuplicateElement
    {
        public static void NonRepeatedElement()
        {
            string[] arr = { "25", "false", "25", "true", "false", "11.21", "25" };
            int len = arr.Length;
            string[] duplicateElement = new string[len];
            int duplicateCount = 0;
            for (int i = 0; i < len; i++)
            {
                bool isDuplicate = false;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate)
                {
                    bool alreadyCounted = false;
                    for (int k = 0; k < duplicateCount; k++)
                    {
                        if (arr[i] == duplicateElement[k])
                        {
                            alreadyCounted = true;
                            break;
                        }
                    }
                    
                   
                }
                
            }
        }
    }
}
