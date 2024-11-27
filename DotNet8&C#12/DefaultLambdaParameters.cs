using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8_C_12
{
    public class DefaultLambdaParameters
    {
        public void LambdaDemo()
        {
            var lambdaDemo = (string name = "Name") => Console.WriteLine($"Hello {name}");

            lambdaDemo();
            lambdaDemo("Prakruti");
            Console.WriteLine($"Default parameter value is: {lambdaDemo.Method.GetParameters()[0].DefaultValue}");
        }
    }
}
