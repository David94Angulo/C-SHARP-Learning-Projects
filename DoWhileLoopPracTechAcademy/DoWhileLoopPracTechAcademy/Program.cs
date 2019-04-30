using System;


namespace DoWhileLoopPracTechAcademy
{
    class Program
    {
        static void Main()
        {


            bool PlayGame = false;
            int count = 0;

            do
            {

                if (count == 1)
                {
                    Console.WriteLine("...Pretty please?");
                    Console.WriteLine(" ");
                }
                else if (count == 2)
                {
                    Console.WriteLine("Fine, Have a good day >:(!");
                    Console.ReadLine();
                    System.Environment.Exit(1);
                }

                Console.WriteLine("Would you like to play a game? (Yes or no)");
                string playGame = Console.ReadLine();
                Console.WriteLine(" ");
                string yes = "yes";
                string Yes = "Yes";
                
                if (playGame.Equals(yes))
                {
                    PlayGame = true;
                }
                else if (playGame.Equals(Yes))
                {
                   PlayGame = true;
                }
                count++;
                
                

            } while (PlayGame == false);




                bool Guess = false;
                Console.WriteLine("Guess my favorite number between 1 and 10: ");
                int guessedNumber = Convert.ToInt32(Console.ReadLine());

                if (guessedNumber == 7)
                {
                    Console.WriteLine("YES! 7 is my favorite Number!");
                    Console.WriteLine("First Guess too, You're a mind-reader!");
                    Console.ReadLine();
                }

                else
                {
                    while (!Guess)
                    {
                        Console.WriteLine("Guess again! Remember, between 1 and 10: ");
                        guessedNumber = Convert.ToInt32(Console.ReadLine());
                        if (guessedNumber == 7)
                        {
                            Guess = true;
                        }

                    }

                    Console.WriteLine("YES! 7 is my favorite Number!");
                    Console.ReadLine();
                }

           








        }
    }
}
