namespace OOPSConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  OOPS CONCEPTS  *****");
            

            // creating object for inheritance

            Computer stream = new Computer();
            stream.Course();
            Console.WriteLine(stream.Department + " " + stream.stream);
        }
    }
}