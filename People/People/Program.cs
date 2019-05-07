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

            Manager.SayName();

            Console.ReadLine();

        }
    }
}
