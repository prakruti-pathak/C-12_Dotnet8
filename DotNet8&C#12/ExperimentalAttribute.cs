using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8_C_12
{
    [Experimental(diagnosticId: "Test001")]
    public class ExperimentalAttributeDemo
    {
        [Experimental(diagnosticId: "Test002")]
        public void Print()
        {
            Console.WriteLine("Hello Experimental Attribute");
        }
    }
}
