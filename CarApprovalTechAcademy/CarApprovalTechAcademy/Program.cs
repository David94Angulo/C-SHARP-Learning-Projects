using System;


namespace CarApprovalTechAcademy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int Age = Convert.ToInt16(age);
           
            Console.WriteLine("");

            Console.WriteLine("You have had a DUI: True or False?");
            string Dui = Console.ReadLine();
            bool DUI = Convert.ToBoolean(Dui);
            
            Console.WriteLine("");

            Console.WriteLine("How many speeding tickets do you have?");
            string speedtick = Console.ReadLine();
            int SpeedTickets = Convert.ToInt16(speedtick);
            
            Console.WriteLine("");

            bool Qualified = (Age > 15 && DUI == false && SpeedTickets <= 3);
            Console.WriteLine("Qualified?");
            Console.WriteLine(Qualified);

            Console.ReadLine();





        }
    }
}
