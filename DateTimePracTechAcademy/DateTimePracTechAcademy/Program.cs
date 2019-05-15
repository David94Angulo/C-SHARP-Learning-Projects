using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTimePracTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            TimeSpan timetoadd = TimeSpan.FromHours(number);
            TimeSpan date = DateTime.Now.TimeOfDay;
            var hoursfromnow = date.Add(timetoadd);


            Console.WriteLine("The time in {0} hours will be {1}",number,hoursfromnow);

            Console.ReadLine();
        }
    }
}
