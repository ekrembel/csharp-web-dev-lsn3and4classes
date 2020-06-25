using System;
using System.Collections.Generic;


namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents = new List<Student>();

        public List<Student> EnrolledStudents
        {
            get { return enrolledStudents; }
            set { enrolledStudents = value; }
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
        //  just the class fields.

        public override string ToString()
        {
            return Topic + " course is taught by " + Instructor.FirstName + " " + Instructor.LastName + " and currently has got " + enrolledStudents.Count + " students enrolled.";
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.

        public override bool Equals(object obj)
        {
            return obj is Course course &&
                   Topic == course.Topic &&
                   EqualityComparer<Teacher>.Default.Equals(Instructor, course.Instructor);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Topic, Instructor);
        }
    }
}
