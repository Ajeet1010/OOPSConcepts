using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    // UC9- Create a inheritance class
    internal class Inheritance
    {
        public string Department = "B.Tech";
        public void Branch()
        {
            Console.WriteLine("Whats your branch name");
        }
    }

    // Creating a Single-level inherited class
    class Computer : Inheritance
    {
        public void Branch1()
        {
            Console.WriteLine("Software work");
        }
    }

    // Hierechial inheritanch
    class Mechanical : Inheritance
    {
        public void Branch2()
        {
            Console.WriteLine("Automobile work");
        }
    }

    // Multilevel inheritance
    class Computer1 : Computer
    {
        public void Branch3() 
        {
            Console.WriteLine("Network management");
        }
    }


    // creating object for inheritance

   
}
