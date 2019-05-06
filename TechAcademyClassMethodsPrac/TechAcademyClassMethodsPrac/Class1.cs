using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademyClassMethodsPrac
{
    class Class1
    {



        public void PrintInt (int x)
        {
            Console.WriteLine("Your number divided by 2 is: "+ x/2);
        }

        public void Outputs (out int G, out string Question)
        {
            G = 7;
            Question = "How?";
        }

        public static void Outputs(out double g)
        {
            g = 21.1;
        }

    }
}
