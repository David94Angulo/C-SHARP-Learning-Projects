using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPracTechAcademy
{
    public class Employee: Person
    {

        public void SayName()
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine("Hello, my  name is " + FullName);
        }


    }
}
