using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class StudentInformation
    {
        class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        class Enrollment
        {
            public int StudentID { get; set; }
            public string Course { get; set; }
        }

        static void Main()
        {
            List<Student> students = new List<Student>
        {
            new Student { ID = 1, Name = "Alice" },
            new Student { ID = 2, Name = "Bob" },
            new Student { ID = 3, Name = "Charlie" }
        };

            List<Enrollment> enrollments = new List<Enrollment>
        {
            new Enrollment { StudentID = 1, Course = "Mathematics" },
            new Enrollment { StudentID = 1, Course = "Science" },
            new Enrollment { StudentID = 2, Course = "Literature" },
            new Enrollment { StudentID = 3, Course = "Mathematics" },
            new Enrollment { StudentID = 3, Course = "History" }
        };

            var studentCourses = from student in students
                                 join enrollment in enrollments
                                 on student.ID equals enrollment.StudentID
                                 group new { student, enrollment } by new { student.ID, student.Name } into g
                                 select new
                                 {
                                     StudentName = g.Key.Name,
                                     Courses = g.Select(x => x.enrollment.Course).ToList()
                                 };
            foreach (var s in studentCourses)
            {
                Console.WriteLine($"Student: {s.StudentName}");
                Console.WriteLine("Courses: " + string.Join(", ", s.Courses));
                Console.WriteLine();
            }
        }
    }
}
