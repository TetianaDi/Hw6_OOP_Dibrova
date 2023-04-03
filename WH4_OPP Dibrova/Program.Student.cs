using static WH4_OPP_Dibrova.Program;

namespace WH4_OPP_Dibrova
{
    internal partial class Program
    {

        public class Student : University
        {         
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string City { get; set; }
                      
            public CoursesAttended Kurs { get; set; }


            public Student(string name, string surname, int age, string city, string university, string cathedra) : base(university, cathedra)
            {
                FirstName = name;
                LastName = surname;
                Age = age;
                City = city;
                Kurs = new CoursesAttended();
            }



            //Describe the following actions: Print (output basic information).
            public void Print()
            {
                Console.WriteLine($"Student {FirstName} {LastName}, Age {Age}, City {City} in University {UnivName} and Cathedra {Сathedra}");
            }

        }

        public class CoursesAttended
        {

            public List <string> Kurs { get; set; }

        }


    }
}








