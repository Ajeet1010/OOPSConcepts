using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    // UC5- Abstarct class.
    abstract class Abstract
    {
        // Abstract method (does not have a body)
        public abstract void abstractmethod();
        // Regular method
        public void OOPS()
        {
            Console.WriteLine("Types of OOPs concepts");
        }
    }

    // Derived class (inherit from Abstract)
    class Type : Abstract
    {
        public override void abstractmethod()
        {
            // The body of abstractmethod() 
            Console.WriteLine("Its one of a expaination of OOPS");
        }
    }   
}
