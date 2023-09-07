using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{

    class baseClass

    {
        public void show()
        {
            Console.WriteLine("Base class");
        }
    }


    class derived : baseClass
    {


        new public void show()
        {
            Console.WriteLine("Derived class");
        }
    }
    internal class Overriding

    {


    }
}

