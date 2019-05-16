using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExceptionPracTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int Age = 0 ;
                bool isValid = false;
                while (!isValid)
                {
                    Console.WriteLine("Please enter your age: ");
                    isValid = int.TryParse(Console.ReadLine(), out Age);
                    Console.WriteLine("Enter digits. No decimals, no letters please.\n\n");
                   
                }

                if ( Age < 0)
                {
                    throw new TrollException();
                }

                DateTime StartDate = DateTime.Now;
                DateTime yearBorn = StartDate.AddYears(-(Age));

                Console.WriteLine("You were born in {0}!", yearBorn.Year);
            }

            catch(TrollException)
            {
                Console.WriteLine("Ha. Ha. Very funny, you can't be Negative years old...");
            }


            catch(Exception)
            {
                Console.WriteLine("An unexpected error occured, please try running the program again.");
                Console.ReadLine();
                return;
            }


            Console.ReadLine();
        }
    }
}
