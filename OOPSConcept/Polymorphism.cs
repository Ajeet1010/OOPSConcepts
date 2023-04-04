using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    // UC3.1-  Dynamic Polymorphism.
    internal class Department
    {
        public virtual void Stream()
        {
            Console.WriteLine("There are many stream in this department");
        }
    }

    // Derived class (child)
    class Civil : Department
    {
        public override void Stream()
        {
            Console.WriteLine("Civil department is for construction");
        }
    }

    class Mechanical1 : Department
    {
        public override void Stream()
        {
            Console.Write("Mechanical for motor Vehicle");
        }
    }    
}
