using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.

            Student ekrem = new Student();
            ekrem.Name = "Ekrem";
            ekrem.StudentId = 10;
            ekrem.NumberOfCredits = 1;
            ekrem.Gpa = 4.0;

            Student student = new Student();
           

            Console.WriteLine(ekrem.Name);
            Console.WriteLine(ekrem.StudentId);
            Console.WriteLine(ekrem.NumberOfCredits);
            Console.WriteLine(ekrem.Gpa);

            Course csharp = new Course();
            csharp.CourseName = "C# Web Development";
            csharp.Requirenments.Add("Commitment");
            csharp.Requirenments.Add("Computer");
            csharp.Requirenments.Add("internet Access");
            csharp.Students.Add(ekrem.StudentId, ekrem.Name);

            int i = 0;
            while (i < 2)
            {
                Console.WriteLine("Student Name: ");
                student.Name = Console.ReadLine();

                Console.WriteLine("Student Id: ");
                student.StudentId = int.Parse(Console.ReadLine());

                csharp.Students.Add(student.StudentId, student.Name);
                i++;
            }

            foreach (KeyValuePair<int, string> person in csharp.Students)
            {
                Console.WriteLine(person.Value);
            }

            foreach (string requirenment in csharp.Requirenments)
            {
                Console.WriteLine(requirenment);
            }

            Teacher instructor = new Teacher();
            instructor.FirstName = "Benet";
            instructor.LastName = "Clark";
            instructor.Subject = "Web Development";
            instructor.YearsTeaching = 2;

            Console.WriteLine(instructor.FirstName);
            Console.WriteLine(instructor.LastName);
            Console.WriteLine(instructor.Subject);
            Console.WriteLine(instructor.YearsTeaching);

            
        }
    }
}
