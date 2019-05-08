using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPracTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Charles = new Employee();
            Charles.FirstName = "Sample";
            Charles.LastName = "Student";

            Charles.SayName();


            IQuittable quiting = new Employee();
            quiting.Quit();

            Console.ReadLine();
        }
    }
}
