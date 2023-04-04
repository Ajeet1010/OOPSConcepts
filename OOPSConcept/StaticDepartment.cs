using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    // UC3.2- Static Polymorphism.
    public class StaticDepartment
    {
        public void Student(string Name, string stream)
        {
            Console.WriteLine("{0} is student of {1} stream", Name, stream);
        }
        public void Student(string Name, string stream, int Age)
        {
            Console.WriteLine("{0}'s age is {1} and studying in {2} stream", Name, Age, stream);
        }
    }
}
