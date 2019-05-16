using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExceptionPracTechAcademy
{
     public class TrollException : Exception
     {
         public TrollException()
             : base() { }
         public TrollException(string message)
             : base(message) { }
     }
}
