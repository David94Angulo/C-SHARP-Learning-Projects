using System;
using System.Collections.Generic;


    class Program
    {
        static void Main(string[] args)
     {
        Console.WriteLine("#1");
        Console.WriteLine("Type in whatever you'd like.");
        Console.WriteLine("\n\n");
        string input = Console.ReadLine();
        string[] InputArray = new string[] { input };
        string paragraph = "";
     
        foreach (string word in InputArray)
        {
            paragraph = paragraph + word;
        }

        foreach (char c in paragraph )
        {
            Console.WriteLine(" ");
            Console.Write(c);

            if (c == ' ')
            {
                Console.WriteLine();
            }
        }
        Console.ReadLine();



        Console.WriteLine("\n\n#2");


        //for (int i = 0; i < 5; i--)
        //{
        //    Console.WriteLine("HELLO!!!");
        //}



        Console.WriteLine("\n\n#3");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("HELLO!!!");
        }






        Console.WriteLine("\n\n#4");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Less than is useful!");  
        }

        Console.WriteLine("\n\n#5");
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Prints ONE more statement compared to number 4!");
        }


        Console.WriteLine("\n\n#6 & 7 & 8");
        List <string> StoreNames = new List<string> {"Happy Town","BK Lounge","Meatless Meatloaf" };
        Console.WriteLine("I have a list of store names you can buy food from, Where would you like to get food from?");
        string foodChoice = Console.ReadLine();



        int countStore = 0;
        foreach (string Store in StoreNames)
        {
            countStore++;
            Console.WriteLine("Searching...");
            if(foodChoice == Store)
            {
                Console.WriteLine("The index of your store is: " + StoreNames.IndexOf(foodChoice));
                break;
            }  

            else if (countStore == StoreNames.Count)
            {
                Console.WriteLine("Sorry! The store name you typed in could not be found, or does not exist!");
            }
        }

        Console.WriteLine("\n\n#9 & 10");

        List <string> Names = new List<string>  {"James","John","Jacob","Jack","Jansen","Jack","Jack","Alex", "Jose", "Alex","Jose","John" };

        Console.WriteLine("Type in a common name: ");
        int StoredIndex = 0;
        int test = 0;
        string guessedName = Console.ReadLine();

        foreach (string Name in Names)
        {

            if (guessedName == Name)
            {
                test = 1;
                Console.WriteLine(StoredIndex);

            }

            StoredIndex++;

        }
        if (test == 0)
        {
            Console.WriteLine("Hrmm... I guess " + guessedName + " is not a common name.");
        }

        Console.WriteLine("\n\n#11");
        bool HasAppeared = false;
        List<string> NewNames = new List<string> { "James", "John", "Jacob", "Jack", "Jansen", "Jack", "Jack", "Alex", "Jose", "Alex", "Jose", "John" };
        string selectedName = Console.ReadLine();

        foreach (string Named in NewNames)
        {


            if (selectedName == Named)
            {
                if (HasAppeared)
                {
                    Console.WriteLine(selectedName + " has appeared already...");
                }

                else
                {
                    Console.WriteLine( selectedName + " \nhas made his first apperance.");
                }
                HasAppeared = true;
            }
        }
       


        Console.ReadLine();
     }
    }

