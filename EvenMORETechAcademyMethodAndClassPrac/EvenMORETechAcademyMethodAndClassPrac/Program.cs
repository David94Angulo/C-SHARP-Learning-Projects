using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenMORETechAcademyMethodAndClassPrac
{
    public class Program
    {
        public static void Main(string[] args)
        {


            
           Class1 FirstOptionalNumber = new Class1();



           Console.WriteLine("Please type in a number: ");
           int n = Convert.ToInt16(Console.ReadLine());

           Console.WriteLine("Please type in another number IF YOU DARE >;D : ");
            string input = Console.ReadLine();

            if (input == "")
            {
                Console.WriteLine("Here is the result of your numbers: " + Class1.OneOptional(n));
            }

            else
            {
                int m = Convert.ToInt16(input);

                Console.WriteLine("Here is the result of your numbers: " + Class1.OneOptional(n, m));
            }
            

          
           Console.ReadLine();
            
        }
    }
}
