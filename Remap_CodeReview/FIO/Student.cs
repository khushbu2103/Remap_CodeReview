using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remap_CodeReview.FIO
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public long MobileNumbe { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public static void SaveStudentDetails(List<Student> students)
        {
            string filePath = @"C:\Users\LENOVO\source\repos\Remap_CodeReview\Remap_CodeReview\FIO\TextFile1.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (Student student in students)
                {
                    writer.WriteLine("Id: " + student.ID);
                    writer.WriteLine("Student name: " + student.Name);
                    writer.WriteLine("Student mobile number: " + student.MobileNumbe);
                    writer.WriteLine("Student age: " + student.Age);
                    writer.WriteLine("Student adress: " + student.Address);
                }
            }
        }
        public static void ReadStudentDetails()
        {
            string filePath = @"C:\Users\LENOVO\source\repos\Remap_CodeReview\Remap_CodeReview\FIO\TextFile1.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                Console.WriteLine("Data read from file");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
        public static void CopyDataInAnotherFile()
        {
            string firstFilePath = @"C:\Users\LENOVO\source\repos\Remap_CodeReview\Remap_CodeReview\FIO\TextFile1.txt";
            string secondFilePath = @"C:\Users\LENOVO\source\repos\Remap_CodeReview\Remap_CodeReview\FIO\TextFile2.txt";

            using (StreamReader streamReader = new StreamReader(firstFilePath))
            {
                using (StreamWriter streamWriter = new StreamWriter(secondFilePath))
                {
                    string Content = streamReader.ReadToEnd();
                    streamWriter.Write(Content);
                }

            }
            Console.WriteLine("Copy successfully");
        }
    }

}
