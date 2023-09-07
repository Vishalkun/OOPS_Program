using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    internal  class singleinheritance
    {
        public class Employee
        {
            public float salary = 40000;
        }
        public class Programmer : Employee
        {
            public float bonus = 10000;
        }
       
    }
}
