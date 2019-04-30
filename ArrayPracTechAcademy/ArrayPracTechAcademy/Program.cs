using System;
using System.Collections.Generic;



    class Program
    {
        static void Main()
        {

            string[] Stringy = { "Howdy", "Hola", "Hoo-rah", "Hello There", "Hi", "Bonjour" };

            Console.WriteLine("Pick a number between 1 and 6");
            int selection = Convert.ToInt32(Console.ReadLine());
       
            while (selection > 6 || selection < 1)
            {
                Console.WriteLine("That number is not in my database :-( Try again! (1-6): ");
                 selection = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(Stringy[selection - 1] + "!");


            Console.WriteLine("\n\n\n");


            int[] inters = { 1, 5, 10, 20, 100 };
            Console.WriteLine("Select a withdrawal ammount: \n 1 (For $1)\n 2 (For $5)\n 3 (For $10)\n 4 (For $20)\n 5 (For $100)" );
            int intSelection = Convert.ToInt32(Console.ReadLine());
            while (intSelection > 5 || intSelection < 1)
            {
                Console.WriteLine("That number is not in my database :-( please select again... (1-5): ");
                intSelection = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Please remove your card and your "+(inters[(intSelection-1)])+" Dollars will appear below.");

            Console.WriteLine("\n\n\n");

            var byeStrings = new List<string>() { "Have a Nice Day! :-)","Good day sir, or mam...","Thank you for your business!","Thank you for feeding me your info >:-D","You dropped your pocket! ;-)","HEY! Don't forget your Card!","Your card was very read-able!"};
            Console.WriteLine("Pick a farewell between 1 and 7: ");
            int Farewell = Convert.ToInt16(Console.ReadLine());
            while (Farewell > 7 || Farewell < 1)
            {
                Console.WriteLine("That number is not in my database :-( please, make another attempt... (1-5): ");
                Farewell = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine(byeStrings[(Farewell - 1)]);

        Console.ReadLine();

        }

    }

