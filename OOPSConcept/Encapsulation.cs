using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    // UC4- Encapsulation with its types.
    internal class Encapsulation
    {
        // member variable
        private int seat;
        private int student;
        public void SittingPlan()
        {
            Console.Write("Enter no of student sit together on a seat:  ");
            seat = Convert.ToInt32(Console.ReadLine());
            Console.Write("No. of student in class:  ");
            student = Convert.ToInt32(Console.ReadLine());
            float Seat = student / seat;
            Console.WriteLine("No of student: {0}", student);
            Console.WriteLine("No of Seat: {0}", Seat);
        }

        
    }
}