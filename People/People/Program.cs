using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee Manager = new Employee();
            Manager.FirstName = "Sample";
            Manager.LastName = "Student";
            Manager.ID = 1001;

            Employee OfMonth = new Employee();
            OfMonth.ID = 1001;
            OfMonth.FirstName = "Sample";
            OfMonth.LastName = "Student";

            Employee Hired = new Employee();
            Hired.ID = 1002;
            Hired.FirstName = "Dan";
            Hired.LastName = "Chermen";


            Manager.SayName();
            OfMonth.SayName();
            Hired.SayName();



            if (Hired == OfMonth)
            {
                Console.WriteLine(Hired.FirstName + " is the Employee of the month! :)");
            }

            else
            {
                Console.WriteLine(Hired.FirstName +" is NOT the Employee of the month! :(");
            }


            Console.ReadLine();

        }
    }
}
