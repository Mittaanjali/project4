using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------STUDENTS---------");
            //student
            Console.WriteLine("Enter the no of students :");
            int n = int.Parse(Console.ReadLine());
            Student[] stud = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter student name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter class");
                int cls = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter section");
                char section = char.Parse(Console.ReadLine());
                stud[i] = new Student(name, cls, section);
                Console.WriteLine("---------------");
            }
            Console.WriteLine("----------------------------------");
            //teacher
            Console.WriteLine("--------TEACHERS---------");
            Console.WriteLine("Enter the no of teachers :");
            int n1 = int.Parse(Console.ReadLine());
            Teacher[] teach = new Teacher[n1];
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("Enter teacher name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter subject name");
                string subject = Console.ReadLine();
                teach[i] = new Teacher(name, subject);
                Console.WriteLine("---------------");
            }
            Console.WriteLine("----------------------------------");
            //subject
            Console.WriteLine("--------SUBJECT---------");
            Console.WriteLine("Enter the no of subject :");
            int n2 = int.Parse(Console.ReadLine());
            Subject[] sub = new Subject[n2];
            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine("Enter subject name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter subjectcode");
                string code = Console.ReadLine();
                sub[i] = new Subject(name, code);
                Console.WriteLine("---------------");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------PRINTING DETAILS OF STUDENTS------------------------");
            foreach (var item in stud)
            {
                Console.WriteLine($"Name : {item.Name}");
                Console.WriteLine($"Class : {item.Class}");
                Console.WriteLine($"Section : {item.Section}");
                Console.WriteLine("---------------");
            }
            Console.WriteLine("----------PRINTING DETAILS OF TEACHERS------------------------");
            foreach (var item in teach)
            {
                Console.WriteLine($"Name : {item.Name}");
                Console.WriteLine($"Subject : {item.Subject}");
                Console.WriteLine("---------------");
            }
            Console.WriteLine("----------PRINTING DETAILS OF SUBJECTS------------------------");
            foreach (var item in sub)
            {
                Console.WriteLine($"Name : {item.Name}");
                Console.WriteLine($"Subject Code : {item.SubCode}");
                Console.WriteLine("---------------");
            }
            Console.ReadKey();
        }

    }
}