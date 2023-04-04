using System.Net.NetworkInformation;

namespace OOPSConcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  OOPS CONCEPTS  *****");
            Console.WriteLine("1. Object & Class.\n2. Inheritance.\n3. Polymorphism.\n4. Encapsulation.\n5. Abstraction.\n6. Variable Types.\n" +
                "7. Method types.\n8. Value & Refrence Type.\n9. Types of Inheritance.\n10. Exit");
            Console.Write("Enter the option to perform:  ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Program for Object & Class");
                    // UC1- Creating an object for created class.
                    Student student = new Student();
                    student.Id = 1;
                    student.Name = "    Ajeet Pal";
                    Console.WriteLine(student.Id + student.Name);
                    break;
                case 2:
                    break;
                case 3:
                    Console.WriteLine("Polymorphism are of type\n Enter you choice\n1. Dynamic polymorphism\n2. Static polymorphism ");
                    int polychoice = Convert.ToInt32(Console.ReadLine());
                    if (polychoice == 1)
                    {
                        // dynamic polymorphism object
                        Console.WriteLine("\nDynamic Polymorphism");
                        Department dynamic = new Department();
                        dynamic.Stream();
                        dynamic = new Civil();
                        dynamic.Stream();
                        dynamic = new Mechanical1();
                        dynamic.Stream();

                    }
                    else
                    {
                        // static dynamic polymorphism
                        Console.WriteLine("\n\nStatic Polymorphism");
                        StaticDepartment poly = new StaticDepartment();
                        poly.Student("Ajeet", "CSE");
                        poly.Student("Ajeet", "CSE", 19);

                    }
                    break;

                case 4:
                    Console.WriteLine("Encapsulation");
                    // encapsulation object
                    Encapsulation encapsulation = new Encapsulation();
                    encapsulation.SittingPlan();
                    break;

                case 5:
                    Console.WriteLine("Abstraction");
                    Type type = new Type(); // Create a type object
                    type.abstractmethod();  // Call the abstract method
                    type.abstractmethod();  // Call the regular method
                    break;

                case 6:
                    Console.WriteLine("Variable types");
                    // types of variable object
                    VariableType variableType = new VariableType();
                    variableType.Type();
                    break;

                case 7:
                    Console.WriteLine("Method types");
                    // method type object
                    MethodTypes.Get();
                    MethodTypes obj = new MethodTypes();
                    obj.GetValue();
                    break;

                case 8:
                    Console.WriteLine("1.Value types 2. Refrence type");
                    ValueType.TestValueType();
                    RefrenceType refrenceType = new RefrenceType();
                    RefrenceType.TestReferenceType();
                    break;

                case 9:
                    Console.WriteLine("types of Inheritance");
                    Computer1 stream = new Computer1();
                    stream.Branch();
                    Console.WriteLine(stream.Department);
                    stream.Branch1();
                    stream.Branch3();
                    Mechanical mechanical = new Mechanical();
                    mechanical.Branch2();
                    break;

                default:
                    Console.WriteLine("Enter correct no");
                    break;
            }            
        }
    }
}