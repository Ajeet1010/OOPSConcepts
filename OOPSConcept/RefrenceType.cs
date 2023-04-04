﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    internal class RefrenceType
    {
        public static void TestReferenceType()
        {
            Student1 student = new Student1();
            student.Id = 1;
            student.Name = "Rahul";
            Console.WriteLine("Before modify method: " + student.Id + "     " + student.Name);
            ChangeReferenceType(student);
            Console.WriteLine("After modify method: " + student.Id + "      " + student.Name);

        }
        public static void ChangeReferenceType(Student1 s)
        {
            s.Id = 1;
            s.Name = "Raj";
            Console.WriteLine("Within method: " + s.Id + "      " + s.Name);
        }
    }
}
