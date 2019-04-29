using System;


namespace ShippingQuoteTechAcademy
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("");
            Console.WriteLine("Please enter the weight of your package: ");
            string packageweight = Console.ReadLine();
            double PackageWeight = Convert.ToDouble(packageweight);

            if (PackageWeight > 50.0)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            else if (PackageWeight <= 50)
            {
                Console.WriteLine("Please enter the package width: ");
                string packagewidth = Console.ReadLine();
                int PackageWidth = Convert.ToInt32(packagewidth);
                Console.WriteLine(" ");

                Console.WriteLine("Please enter the package height: ");
                string packageheight = Console.ReadLine();
                int PackageHeight = Convert.ToInt32(packageheight);
                Console.WriteLine(" ");

                Console.WriteLine("Please enter the package length: ");
                string packagelength = Console.ReadLine();
                int PackageLength = Convert.ToInt32(packagelength);
                Console.WriteLine(" ");

                int PackageDimSum = PackageWidth + PackageHeight + PackageLength;

                if (PackageDimSum > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. ");
                }

                else if (PackageDimSum <= 50)
                {
                    double Quote = (PackageDimSum + PackageWeight)/100;

                    Console.Write("Your Quote is:  $");
                    Console.WriteLine(Quote);

                }

               

            }
            
            else
            {
                Console.WriteLine("Somethings very wrong... ");
            }


            Console.WriteLine("");



            Console.ReadLine();
        }
    }
}
