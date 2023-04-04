using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    internal class MethodTypes
    {
        //Static method
        public static void Get()
        {
            int a = 5;
            Console.WriteLine(a);
        }
        //nonstatic method
        public void GetValue()
        {
            int b = 7;
            Console.WriteLine(b);
        }
        //Virtual Method
        public class A
        {
            public virtual int Calculate(int a, int b)
            {
                return a + b;
            }
        }
        public class B : A
        {
            public override int Calculate(int a, int b)
            {
                return a + b + 1;
            }
        }
    }
}
