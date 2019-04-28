using System;

namespace MathPracTechAcademy
{
    class Program
    {
        static void Main()
        {

            //#1
            Console.WriteLine("Please enter a number: ");
            string userNum = Console.ReadLine() ;
            int Num = Convert.ToInt32(userNum);
            int FinalNum = Num * 50;
            Console.WriteLine("");
            Console.WriteLine("Your number multiplied by 50 is "+FinalNum);
            Console.WriteLine("");
            Console.WriteLine("");

            //#2
            Console.WriteLine("Please enter a new number: ");
            string addNum = Console.ReadLine();
            int ADDNum = Convert.ToInt32(addNum);
            Console.WriteLine("");
            Console.Write("Your number plus 25 is ");
            Console.WriteLine(ADDNum + 25);
            Console.WriteLine("");
            Console.WriteLine("");

            //#3
            Console.WriteLine("Now enter a newer number: ");
            string newNum = Console.ReadLine();
            double NEWNum = Convert.ToDouble(newNum);
            Console.WriteLine("");
            Console.WriteLine("Your number divided by 12.5 is " + NEWNum/12.5);
            Console.WriteLine("");
            Console.WriteLine("");

            //#4
            Console.WriteLine("Now enter any number you want: ");
            string AnyNum = Console.ReadLine();
            int ANYNum = Convert.ToInt32(AnyNum);
            bool MoreThanFifty = ANYNum > 50;
            Console.WriteLine("");
            Console.WriteLine("Your number is larger than 50 is..." + MoreThanFifty);
            Console.WriteLine("");
            Console.WriteLine("");

            //#5
            Console.WriteLine("Now give me a final number: ");
            string LastNum = Console.ReadLine();
            int LASTNum = Convert.ToInt32(LastNum);
            Console.WriteLine("");
            Console.WriteLine("Here is the remainder of your number divided by 7: " + LASTNum % 7 );
            Console.Read();

        }
    }
}
