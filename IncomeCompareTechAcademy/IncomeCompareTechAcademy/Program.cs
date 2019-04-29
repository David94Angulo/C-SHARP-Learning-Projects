using System;


namespace IncomeCompareTechAcademy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Person 1");
            Console.WriteLine("What is the Hourly rate of this person?");
            string HrlyRateP1 = Console.ReadLine();
            int HourRateP1 = Convert.ToInt32(HrlyRateP1);
            Console.WriteLine("How many Hours did this person work?");
            string HrsWorkedP1 = Console.ReadLine();
            int HoursWorkedP1 = Convert.ToInt32(HrsWorkedP1);
            Console.WriteLine(" ");

            Console.WriteLine("Person 2");
            Console.WriteLine("What is the Hourly rate of this person?");
            string HrlyRateP2 = Console.ReadLine();
            int HourRateP2 = Convert.ToInt32(HrlyRateP2);
            Console.WriteLine("How many Hours did this person work?");
            string HrsWorkedP2 = Console.ReadLine();
            int HoursWorkedP2 = Convert.ToInt32(HrsWorkedP2);
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            int AnnualSalaryP1 = (HourRateP1 * HoursWorkedP1) * 52;
            int AnnualSalaryP2 = (HourRateP2 * HoursWorkedP2) * 52;

            Console.WriteLine("Annual salary of Person 1: ");
            Console.WriteLine(AnnualSalaryP1);

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Annual salary of Person 2: ");
            Console.WriteLine(AnnualSalaryP2);
            Console.WriteLine(" ");

            bool P1MakeMore = AnnualSalaryP1 > AnnualSalaryP2;
            Console.WriteLine("Does Person 1 Make more than Person 2? ");
            Console.WriteLine(P1MakeMore);
            Console.ReadLine();















        }
    }
}
