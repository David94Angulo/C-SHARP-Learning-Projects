using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPracTechAcademy
{
    public class Employee : Person
    {

        public int ID { get; set; }

        public List<Employee> Team1 {get; set;}

       

    }
}
