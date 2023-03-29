namespace WH4_OPP_Dibrova
{
    internal partial class Program
    {

        public class Student
        {         
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string City { get; set; }

            public CoursesAttended Kurs { get; set; }


            public Student(string name, string surname, int age, string city)
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
                Console.WriteLine($"First name {FirstName}, Last name {LastName}, Age {Age}, City {City}");
            }

        }

        public class CoursesAttended
        {

            public List <string> Kurs { get; set; }

        }


    }
}








