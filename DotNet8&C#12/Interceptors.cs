using DotNet8_C_12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class InterceptsLocationAttribute(string filePath, int line, int character) : Attribute
    {
    }
}
namespace DotNet8_C_12
{
    public static class Interceptors
    {
        [InterceptsLocation(
                filePath: @"C:\Repos\DotNet8&C#12\DotNet8&C#12\Program.cs",
                line: 61,
                character: 22)]
        public static void InterceptMethodPrintValue2(this InterceptableExample example)
        {
            Console.WriteLine("Interceptor is here!");
        }
    }
}
public class InterceptableExample
{
    // This method will not be intercepted;
    public void PrintValue1()
    {
        Console.WriteLine("Test 1");
    }

    // This method will be intercepted;
    public void PrintValue2()
    {
        Console.WriteLine("Test 2");
    }

    // This method will not be intercepted;
    public void PrintValue3()
    {
        Console.WriteLine("Test 3");
    }
}
