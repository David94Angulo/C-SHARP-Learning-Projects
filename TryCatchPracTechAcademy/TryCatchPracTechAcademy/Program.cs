using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchPracTechAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> Numbers = new List<int> {410,345,6,3,13,51,3,};
                Console.WriteLine("Please enter an Integer");
                int Divider = Convert.ToInt32(Console.ReadLine());
                foreach (int Number in Numbers)
                {
                    Console.WriteLine(Number / Divider);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.WriteLine("Welcome to the other side of the Try block!");

            Console.ReadLine();

        }
    }
}
