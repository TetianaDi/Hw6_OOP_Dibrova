using System.Security.Cryptography.X509Certificates;

namespace WH4_OPP_Dibrova
{
    internal partial class Program
    {
        public class University
        {
            public string UnivName { get; set; }

            public string Сathedra { get; set; }




            public University(string university, string cathedra)
            {
                this.UnivName = university;
                this.Сathedra = cathedra;

            }

            public void Print()
            {
                Console.WriteLine($"University {UnivName} and Cathedra {Сathedra}");
            }

            string UnivDescription = "University descrioption";
            public virtual void DescribeYourself()
            {
                Console.WriteLine($"Description:" + UnivDescription);
                //return "Description";
            }

        }
    }
}









