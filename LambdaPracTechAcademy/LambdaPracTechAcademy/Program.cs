using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPracTechAcademy
{
    class Program
    {

        static void Main(string[] args)
        {

           List<Employee> TeamOne = new List<Employee>();

            Employee Employee1 = new Employee();
            Employee1.FirstName = "Joe";
            Employee1.LastName = "Delgado";
            Employee1.ID = 1;

            Employee Employee2 = new Employee();
            Employee2.FirstName = "Joe";
            Employee2.LastName = "Sanchez";
            Employee2.ID = 2;

            Employee Employee3 = new Employee();
            Employee3.FirstName = "Joe";
            Employee3.LastName = "Dresch";
            Employee3.ID = 3;

            Employee Employee4 = new Employee();
            Employee4.FirstName = "Frank";
            Employee4.LastName = "Keester";
            Employee4.ID = 4;

            Employee Employee5 = new Employee();
            Employee5.FirstName = "Ron";
            Employee5.LastName = "Burns";
            Employee5.ID = 5;

            Employee Employee6 = new Employee();
            Employee6.FirstName = "John";
            Employee6.LastName = "Salazar";
            Employee6.ID = 6;

            Employee Employee7 = new Employee();
            Employee7.FirstName = "Earl";
            Employee7.LastName = "Shapiro";
            Employee7.ID = 7;

            Employee Employee8 = new Employee();
            Employee8.FirstName = "Bobby";
            Employee8.LastName = "Hughman";
            Employee8.ID = 8;

            Employee Employee9 = new Employee();
            Employee9.FirstName = "Daniel";
            Employee9.LastName = "Darkshire";
            Employee9.ID = 9;

            Employee Employee10 = new Employee();
            Employee10.FirstName = "Joe";
            Employee10.LastName = "Connrad";
            Employee10.ID = 10;


            TeamOne.Add(Employee1);
            TeamOne.Add(Employee2);
            TeamOne.Add(Employee3);
            TeamOne.Add(Employee4);
            TeamOne.Add(Employee5);
            TeamOne.Add(Employee6);
            TeamOne.Add(Employee7);
            TeamOne.Add(Employee8);
            TeamOne.Add(Employee9);
            TeamOne.Add(Employee10);

            List<Employee> JoeList = new List<Employee>();

            foreach (Employee Hired in TeamOne)
            {
                if (Hired.FirstName == "Joe")
                {
                    JoeList.Add(Hired);
                }

            }

            List<Employee> NewJoeList = new List<Employee>();

            foreach (Employee Hired in TeamOne.FindAll(x=> x.FirstName=="Joe"))
            {
                NewJoeList.Add(Hired);
            }

            List<Employee> GreaterThanFive = new List<Employee>();

            foreach (Employee Hired in TeamOne.FindAll(x => x.ID >5))
            {
                GreaterThanFive.Add(Hired);
            }

            //Print time

            foreach (Employee hire in JoeList)
            {
                Console.WriteLine(hire.ID +" "+ hire.LastName );
            }
            Console.WriteLine("\nAbove is the list with the foreach loop.\n");





            foreach (Employee hire in NewJoeList)
            {
                Console.WriteLine(hire.ID + " " + hire.LastName );
            }
            Console.WriteLine( "\nAbove is the list with Lambda\n");




            foreach (Employee hire in GreaterThanFive)
            {
                Console.WriteLine(hire.ID + " " + hire.LastName);
            }
            Console.WriteLine("\nAbove is the list of all employees with ID greatert than 5\n");


                  



            Console.ReadLine();

        }
    }
}
