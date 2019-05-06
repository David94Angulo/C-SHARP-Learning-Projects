using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyClassMethodsPrac
{
    class Program
    {
        static void Main(string[] args)
        {


            Class1 Trial1 = new Class1();
            Console.WriteLine("Please enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Trial1.PrintInt(n);




            Console.ReadLine();
        }


    }
}
