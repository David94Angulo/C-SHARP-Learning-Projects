using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOPracTechAcademy
{
     class Program
    {
         static void Main()
        {
            Console.WriteLine("Type in a number: ");
             string number = Console.ReadLine();
            File.WriteAllText(@"FileIO.txt", number);
            //File.ReadAllText(@"C:\Users\david\C-SHARP-Learning-Projects\FileIOlogs.txt");
            using (StreamReader readtext = new StreamReader(@"FileIO.txt"))
            {
                string line = readtext.ReadLine();
                Console.WriteLine(line);

            }

            Console.ReadLine();
        }
    }
}
