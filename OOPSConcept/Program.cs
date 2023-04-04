using System.Net.NetworkInformation;

namespace OOPSConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  OOPS CONCEPTS  *****");     
            

            // method type object
            MethodTypes.Get();

            MethodTypes obj = new MethodTypes();
            obj.GetValue();
        }
    }
}