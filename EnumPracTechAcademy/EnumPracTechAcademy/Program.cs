using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPracTechAcademy
{
    class Program
    {

        public enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
           
            try
            {
                Console.WriteLine("Please enter the current Day of the week: ");
                string Input = Console.ReadLine();

                DayOfWeek CurrentDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Input);

                Console.WriteLine("Alright, Today is " + CurrentDay);
            }

            catch 
            { 

                Console.WriteLine("Please enter an actual day of the week");
            }
          
        
            Console.ReadLine();
        }


       


    }
}
