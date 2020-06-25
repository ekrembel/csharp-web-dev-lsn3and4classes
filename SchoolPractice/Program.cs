using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TODO: Test your exercise solutions with print statements here.
            Student me = new Student("Ekrem");
            Student you = new Student("James");
            
            you.AddGrade(4, 4);
            me.AddGrade(4, 3.8);

            Console.WriteLine(me.ToString());
            Console.WriteLine(you.ToString());

            Console.WriteLine(me.Equals(you));
            Console.WriteLine(me.Equals(me));

            Course course = new Course();
            Teacher teacher = new Teacher("Mr.", "Ben", "Web Development", 2);
            course.Topic = "C# Web Development";
            course.Instructor = teacher;
            course.enrolledStudents.Add(me);
            course.enrolledStudents.Add(you);

            Console.WriteLine(course.ToString());

            Course course1 = new Course();
            Teacher teacher1 = new Teacher("Adam", "Stone", "Mobile App Development", 4);
            course1.Topic = "Native React";
            course1.Instructor = teacher1;
            course1.EnrolledStudents.Add(me);

            Console.WriteLine(course1.ToString());

            Console.WriteLine(course.Equals(course1));
            Console.WriteLine(course.Equals(course));

        }
    }
}
