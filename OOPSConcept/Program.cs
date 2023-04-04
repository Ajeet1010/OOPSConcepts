namespace OOPSConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  OOPS CONCEPTS  *****");


            // dynamic polymorphism object
            Console.WriteLine("\nDynamic Polymorphism");
            Department dynamic = new Department();
            dynamic.Stream();
            dynamic = new Civil();
            dynamic.Stream();
            dynamic = new Mechanical();
            dynamic.Stream();

            // static dynamic polymorphism
            Console.WriteLine("\n\nStatic Polymorphism");
            StaticDepartment poly = new StaticDepartment();
            poly.Student("Ajeet", "CSE");
            poly.Student("Ajeet", "CSE", 19);

        }
    }
}