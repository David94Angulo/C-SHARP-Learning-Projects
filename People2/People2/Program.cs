using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {



            Employee<int> IntList = new Employee<int>();
            Employee<string> List = new Employee<string>();
            IntList.Things = new List<int>();
            List.Things = new List<string>();


            IntList.Things.Add(100);
            IntList.Things.Add(1000);
            IntList.Things.Add(10000);
            IntList.Things.Add(100000);
            IntList.Things.Add(1000000);
            //
            List.Things.Add("Stacy");
            List.Things.Add("Paul");
            List.Things.Add("Pat");





            foreach (string i in List.Things)
            {

                Console.WriteLine(i + " ");

            }

            foreach (int i in IntList.Things)
            {

                Console.WriteLine(i + " ");

            }












            //Employee Manager = new Employee();
            //Manager.FirstName = "Sample";
            //Manager.LastName = "Student";
            //Manager.ID = 1001;

            //Employee OfMonth = new Employee();
            //OfMonth.ID = 1001;
            //OfMonth.FirstName = "Sample";
            //OfMonth.LastName = "Student";

            //Employee Hired = new Employee();
            //Hired.ID = 1002;
            //Hired.FirstName = "Dan";
            //Hired.LastName = "Chermen";


            //Manager.SayName();
            //OfMonth.SayName();
            //Hired.SayName();



            //if (Hired == OfMonth)
            //{
            //    Console.WriteLine(Hired.FirstName + " is the Employee of the month! :)");
            //}

            //else
            //{
            //    Console.WriteLine(Hired.FirstName +" is NOT the Employee of the month! :(");
            //}


            Console.ReadLine();

        }
    }
}
