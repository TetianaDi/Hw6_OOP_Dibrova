using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
using static WH4_OPP_Dibrova.Program;

namespace WH4_OPP_Dibrova
{
    internal partial class Program
    {
        //Create a course class and describe its main characteristics: course name, teacher name, course duration, number of students.
        //Describe the following actions: Print(output basic information).
        //Add a student to the course group(add one student to the number of students).
        public class Course 
        {
            public  string CourseName { get; set; }
            public string TeacherName { get; set; }
            public int CourseDuration { get; set; }
            public AllStudents StudentsNumbers { get; set; }

            public static int Count = 0;

            


            public Course(string course_name, string teacher, int duration)
            {
                CourseName = course_name;
                TeacherName = teacher;
                CourseDuration = duration;
                StudentsNumbers = new AllStudents();
                
            }
            public void Print()
            {
                Console.WriteLine($"Course Name {CourseName}, Teacher Name {TeacherName}, Course Duration {CourseDuration}, Number of students {StudentsNumbers}");
            }

            //я хотіла показати, що спочатку у нас 0 студентів, а потім після додавання, що кількість збільшується, але я не знаю, як це прописати

            }
        public class AllStudents
        {
            public List<string> StudentsNumbers { get; set; }
       
        }
    }
        
       


}