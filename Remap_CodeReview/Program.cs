using Remap_CodeReview.FIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Remap_CodeReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter any statement");
            //string statement = Convert.ToString(Console.ReadLine());
            //Palindrome.ReverseWordAtSamePosition(statement);
            //Palindrome.ReverseWord(word);
            //Console.WriteLine("enter any word");
            //string words = Convert.ToString(Console.ReadLine());
            //Palindrome.PalindromWord(words);
            //string words = Convert.ToString(Console.ReadLine());
            //int number = Convert.ToInt32(Console.ReadLine());
            //Palindrome.PalindromNumber(number);

            Console.WriteLine("Welcome to the logical programs");
            Console.WriteLine("Choose any one program");


            Console.WriteLine("1.Fibonoccie Series\n" +
                "2.Prime Number\n" +
                "3.Reverse Number\n" +
                "4.Harmonic series\n" +
                "5.Power of 2\n" +
                "6.Print non repeated element\n" +
                "7.Vowel or constant\n" +
                "8.Swape two digit\n" +
                "9.Reminder and quotient\n" +
                "10.Check leap year\n" +
                "11.Calculate factor\n" +
                "13.Flip coin\n" +
                "14.Coupon number\n" +
                "15.Print in upecase and lowercase\n" +
                "16.Duplicate element\n" +
                "17.FIO save data, read data and copy data\n" +
                "19.Reverse statement and palindrom number\n" +
                "20.Calculate perfact number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("enter any number");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Fibonoccie.FibonoccieSeries(n);
                    break;
                case 2:
                    Console.WriteLine("enter any number");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    Prime.PrimeNumber(n1);
                    break;
                case 3:
                    Console.WriteLine("please enter eny number");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    ReverseNumber.ReverseEachNumber(n2);
                    break;
                case 4:
                    Console.WriteLine("please enter the number till you want Harmonic number");
                    Harmonic.HramonicNumber();
                    break;
                case 5:
                    Console.WriteLine("please enter a number");
                    int n3 = Convert.ToInt32(Console.ReadLine());
                    Power2.PowerOf2(n3);
                    break;
                case 6:
                    NonRepeatedElement.PrintNonRepeatedElement();
                    break;
                case 7:
                    VowelOrConstant.Vowel_Constant();
                    break;
                case 8:
                    SwapeTwoDigit.Swape();
                    break;
                case 9:
                    ReminderAndQuetient.Quotient_Reminder();
                    break;
                case 10:
                    CheckLeapYear.LeapYear();
                    break;
                case 11:
                    CalculateFactor.Factors();
                    break;
                case 12:
                    ReverseLinkedList reverseLinkedList = new ReverseLinkedList();
                    reverseLinkedList.ReverseLnkedListElement(20);
                    reverseLinkedList.ReverseLnkedListElement(30);
                    reverseLinkedList.ReverseLnkedListElement(40);
                    //reverseLinkedList.Display();
                    break;
                case 13:
                    FlipCoin.Flip();
                    break;
                case 15:
                    UpperCase_LowerCase.PrintInUpperCaseAndLowerCase();
                    break;
                case 16:
                    DuplicateElement.NonRepeatedElement();
                    break;
                case 17:
                    List<Student> students = new List<Student>
                    {
                        new Student{ID = 1, Name = "Khushi", MobileNumbe = 8619532017, Age = 27, Address = "Gujrat"},
                        new Student{ID = 2, Name = "Raj", MobileNumbe = 861954345, Age = 28, Address = "Rajasthan"}
                    };

                    Student.SaveStudentDetails(students);
                    Console.WriteLine("Save data successfully");
                    Student.ReadStudentDetails();
                    Student.CopyDataInAnotherFile();
                    Console.ReadLine();
                    break;
                case 18:
                    ReverseString.ReverseAtItsPosition();
                    break;
                case 19:
                    Console.WriteLine("Enter a statment");
                    string statement = Console.ReadLine();
                    ReverseSatatementAndPalindrome.ReverseEachWordInSamePosition(statement);
                    Console.WriteLine("\nEnter a number");
                    int number = Convert.ToInt32(Console.ReadLine());
                    ReverseSatatementAndPalindrome.PalindromNumber(number);
                    break;
                case 20:
                    Console.WriteLine("Enter a number");
                    int num = Convert.ToInt32(Console.ReadLine());
                    PerfactNumber.CalculatePerfectNumber(num);
                    break;
                default:
                    break;

            }

           

            Console.ReadLine();
        }
    }
}
