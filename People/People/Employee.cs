using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Employee : Person
    //<T> 
    {



        public int ID { get; set; }



        public static bool operator ==(Employee Emp1, Employee Emp2)
        {
            return Emp1.ID == Emp2.ID;
        }

        public static bool operator !=(Employee Emp1, Employee Emp2)
        {
            return Emp1.ID == Emp2.ID;
        }


        //public List<T> Things { get; set; }

    }
}
