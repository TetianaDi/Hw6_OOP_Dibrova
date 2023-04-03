using static WH4_OPP_Dibrova.Program;

namespace WH4_OPP_Dibrova
{
    internal partial class Program
    {
        public class Teacher : University
        {
            public string TeachName { get; set; }

            public Teacher(string teachName, string university, string cathedra) : base(university, cathedra)
            {
                TeachName = teachName;
            }
            public void Print()
            {
                Console.WriteLine($"Teacher is  {TeachName} in University {UnivName} and Cathedra {Сathedra}");
            }

            
            public  void DescribeYourself(University university)
            {

                //University.DescribeYourself();
                

            }


        }
    }
}









