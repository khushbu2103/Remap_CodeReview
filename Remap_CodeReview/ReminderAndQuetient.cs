using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_CodeReview
{
    internal class ReminderAndQuetient
    {
        public static void Quotient_Reminder()
        {
            int reminder;
            int quotient;
            int num = 25;
            int num2 = 10;
            reminder = num % num2;
            quotient = num / num2;
            Console.WriteLine("reminder : {0}", reminder);
            Console.WriteLine("quotient : {0}", quotient);
        }
    }
}
