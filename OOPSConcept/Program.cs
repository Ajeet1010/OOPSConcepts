using System.Net.NetworkInformation;

namespace OOPSConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  OOPS CONCEPTS  *****");
            

            Type type = new Type(); // Create a type object
            type.abstractmethod();  // Call the abstract method
            type.abstractmethod();  // Call the regular method

        }
    }
}