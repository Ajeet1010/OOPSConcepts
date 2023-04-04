using System.Net.NetworkInformation;

namespace OOPSConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  OOPS CONCEPTS  *****");
            Computer1 stream = new Computer1();
            stream.Branch();
            Console.WriteLine(stream.Department);
            stream.Branch1();
            stream.Branch3();
            Mechanical mechanical = new Mechanical();
            mechanical.Branch2();

            
        }
    }
}