using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOREClassAndMethodPracTech
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 Step1 = new Class1();
            Console.WriteLine("The result is: " + Class1.Number(a: 12));



            Class1 Step2 = new Class1();// <--- Is this "Instantiation really needed? Maybe If I got a Tech Academy definition of instationation, It would help alot.
            Console.WriteLine("The result is: " + Class1.Number(a: 12.5));


            Class1 Step3 = new Class1();
            Console.WriteLine("The result is: " + Class1.Number(a: "125"));


            Console.ReadLine();
        }
    }
}
