using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPracTechAcademy
{
    public class Employee: Person, IQuittable
    {

        public void SayName()
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine("Hello, my  name is " + FullName);
        }

        public void Quit()
        {
            Console.WriteLine("I am destined to follow me dreams.Those dreams promise me a brighter futre than this dump! I quit!");
            Console.ReadLine();
        }

        


    }
}
