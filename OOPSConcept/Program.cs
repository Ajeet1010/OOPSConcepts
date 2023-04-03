namespace OOPSConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  OOPS CONCEPTS  *****");
            // UC1- Creating an object for created class.
            Student student = new Student();
            student.Id = 1;
            student.Name = "    Ajeet Pal";
            Console.WriteLine(student.Id + student.Name);
        }
    }
}