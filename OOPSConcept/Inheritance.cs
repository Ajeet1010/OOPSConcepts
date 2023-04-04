using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    // UC2- Create a inheritance class
    internal class Inheritance
    {
        public string Department = "B.Tech";
        public void Course()
        {
            Console.WriteLine("Whats your stream");
        }
    }

    // Creating a inherited class of class INHERITANCE
    class Computer : Inheritance
    {
        public string stream = "Computer Science Engineering";
    }
}
