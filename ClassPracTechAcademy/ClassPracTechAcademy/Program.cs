using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPracTechAcademy
{
    public class Program
    {
        public static void Main(string[] args)
        {

            MathStuff FirstSet = new MathStuff();

            MathStuff.SomeMath( 5, 133);

            MathStuff.SomeMath(Num1: 50, Num2: 100);


            Console.ReadLine();
        }
    }
}
