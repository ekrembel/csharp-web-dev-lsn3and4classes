using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            NumberOfCredits = courseCredits + NumberOfCredits;
            double totalScore = (courseCredits * grade) + (NumberOfCredits * Gpa);
            Gpa = totalScore / NumberOfCredits;
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (credits >= 0 && credits <= 29)
            {
                return "Freshman";
            }
            else if (credits > 29 && credits <= 59)
            {
                return "Sophomore";
            }
            else if (credits > 59 && credits <= 89) 
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }           
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.

        public override string ToString()
        {
            return Name + " (student id #" + StudentId + ")" + " is currently a " + GetGradeLevel(NumberOfCredits) + " with credits of " + NumberOfCredits + " and a gpa of " + Gpa;
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.

        public override bool Equals(object obj)
        {
            return obj is Student student &&
                   StudentId == student.StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId);
        }
    }
}
