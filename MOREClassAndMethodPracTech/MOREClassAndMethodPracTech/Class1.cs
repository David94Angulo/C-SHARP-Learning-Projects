using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOREClassAndMethodPracTech
{
    public class Class1
    {



        public static int Number(int a)
        {
            a = (a * 2) + 6;
            return a;
        }

        public static int Number(double a)
        {
            a = (a - 12) / 5;
            int A = Convert.ToInt16(a);
            return A;
        }




        public static int Number (String a)
        {
            int A = Convert.ToInt16(a);
           A = (A + 5) + (5 + 5) / (5 * 4);
            return A;
        }





    }
}
