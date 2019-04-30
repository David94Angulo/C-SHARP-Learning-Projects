using System;
using System.Text;


namespace String_ingAlongTechAcademy
{
    class Program
    {
        static void Main()
        {

            string name, lastName, middleName, FullName;
            name = "Darren";
            lastName = "Hoffman";
            middleName = "Anthony";

            FullName = name +" " + lastName + " " + middleName + " ";

            StringBuilder Paragraph = new StringBuilder("Hello, My name is: " + name +".");
            Console.WriteLine(Paragraph);
            Paragraph.Append (" My last name is: " + lastName + ".");
            Console.WriteLine(Paragraph);
            Paragraph.Append("Oh, and my middle name is: " + middleName + ".");
            Console.WriteLine(Paragraph);
            Paragraph.Append("And I like to tickle people in public...");
            Console.WriteLine(Paragraph);
            Paragraph.Append("*Everyone in the circle* \" Hi Darren...\"");
            Console.WriteLine(Paragraph);

            Console.WriteLine("\n");
            Console.WriteLine("Target: "+FullName.ToUpper()+"Known for tickling, DANGER, DANGER!");
            


            Console.ReadLine();
        }
    }
}
