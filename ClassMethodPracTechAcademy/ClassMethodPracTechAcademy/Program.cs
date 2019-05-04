using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodPracTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int Num = Convert.ToInt16(Console.ReadLine());

            int Num1 = MathClass.Multiply(Num);
            Console.WriteLine(Num1);

            int Num2 = MathClass.Divide(Num);
            Console.WriteLine(Num2);

            int Num3 = MathClass.Add(Num);
            Console.WriteLine(Num3);

            Console.WriteLine("Some math was done to your number...");

            Console.ReadLine();
        }



    }
}
