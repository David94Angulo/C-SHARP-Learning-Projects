using System;


namespace TechAcademyDailyReport
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("The Tech Academy");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("Student Daily Report");
            Console.WriteLine(" ");

            Console.WriteLine("What course are you on?");
            string CurrentCourse = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("What Page Number are you on?");
            string PgNmbr = Console.ReadLine();
            byte PageNumber = Convert.ToByte(PgNmbr);
            Console.WriteLine(" ");

            Console.WriteLine("Do you need help with anything? (Please answer with True or False)");
            string helpNeed = Console.ReadLine();
            bool NeedHelp = Convert.ToBoolean(helpNeed);
            Console.WriteLine(" ");

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string PowerofPositivity = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("Is there any other feedback you'd like to provide?");
            string Feedback = Console.ReadLine();
            Console.WriteLine(" ");

            Console.WriteLine("How many hours did you study today?");
            string hrsStdy = Console.ReadLine();
            byte HoursStudied = Convert.ToByte(hrsStdy);
            Console.WriteLine(" ");

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();









        }
    }
}
