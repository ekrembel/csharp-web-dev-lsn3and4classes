using System;
using System.Collections.Generic;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }
        
    }

    public class Course
    {
        private Dictionary<int, string> students = new Dictionary<int, string>();
        public List<string> requirenments = new List<string>();
        public string CourseName { get; set; }
        public List<string> Requirenments
        {
            get { return requirenments; }
            set { requirenments = value; }
        }
        public Dictionary<int, string> Students
        {
            get { return students; }
            set { students = value; }
        }       

    }

    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public int YearsTeaching { get; set; }
    }
}
