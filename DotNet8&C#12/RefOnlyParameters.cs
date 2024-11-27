using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8_C_12
{
    public class RefOnlyParameters
    {
        // Example using "ref" and "readonly" keywords;
        public void PrintWithRefReadonly(ref readonly int number)
        {
            Console.WriteLine($"Your number is {number}");
            //number++; // This will make the compiler issue an error;
        }

        // Example using the "in" keyword;
        public void PrintWithIn(in int number)
        {
            Console.WriteLine($"Your number is {number}");
            //number++; // This will make the compiler issue an error;
        }

        // Example using only the "ref" keyword;
        public void PrintWithRef(ref int number)
        {
            Console.WriteLine($"Your number is {number}");
            number++;
        }
    }
}
