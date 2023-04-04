using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    internal class ValueType
    {
        public static void TestValueType()
        {
            int i = 100;
            Console.WriteLine("Before modifying value of x is:  " + i);
            ChangevalueType(i);
            Console.WriteLine("After modifying modified value of x is:" + i);


        }
        public static void ChangevalueType(int x)
        {
            x = x + 10;
            Console.WriteLine("Within method x value is increased by 10.\nSo new value of will be:  " + x);
        }
    }
}
