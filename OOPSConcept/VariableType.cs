using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    internal class VariableType
    {
        public void Type()
        {
            Console.WriteLine("variable Types Sample");

            // Declare int variable
            int i = 34;
            // char variable
            char c = 'm';
            // float variable
            float per = 6.8f;
            // object variable:
            object o = c;
            // string varialbe
            string name = "Mahesh ";
            // Use i in an operation

            Console.WriteLine("Integer type:   {0},\ncharacter type:  {1},\nfloat type:  {2},\nstring:   {3},\nobject:  {4}", i,c,per,name,o);
        }
    }
}
