// See https://aka.ms/new-console-template for more information
using DotNet8_C_12;
using System;

Console.WriteLine("Example of C#12 and .net 8");

/*****************/
Console.WriteLine("Alias any type");
AliasType aliasType = new AliasType();
var person=aliasType.GetPerson();
aliasType.PrintPerson(person);

/**************************************************************/

Console.WriteLine("Collection Expression");
CollectionExpressions ce = new CollectionExpressions();
ce.Demo();

/**********************************************/
Console.WriteLine("Default Lambda Parameter Values");

DefaultLambdaParameters dlp = new DefaultLambdaParameters();
dlp.LambdaDemo();

/**************************************************************/
Console.WriteLine($"Experimental Attribute examples:");

#pragma warning disable Test001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
var demo = new ExperimentalAttributeDemo();
#pragma warning restore Test001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.


/************************************************************/

Console.WriteLine($"Ref Readonly Parameters examples");

var refOnlyParametersDemo = new RefOnlyParameters();

Console.WriteLine("Method with ref readonly:");
var numberExample1 = 1;
refOnlyParametersDemo.PrintWithRefReadonly(ref numberExample1);
Console.WriteLine($"Your number is now {numberExample1}");

Console.WriteLine("Method with in:");
var numberExample2 = 2;
refOnlyParametersDemo.PrintWithIn(numberExample2);
Console.WriteLine($"Your number is now {numberExample2}");

Console.WriteLine("Method with ref:");
var numberExample3 = 3;
refOnlyParametersDemo.PrintWithRef(ref numberExample3);
Console.WriteLine($"Your number is now {numberExample3}");


/************************************************************/
Console.WriteLine($"Interceptors examples");

var interceptableExample = new InterceptableExample();

interceptableExample.PrintValue1();
interceptableExample.PrintValue2(); // The method PrintValue2 will be intercepted;
interceptableExample.PrintValue3();


/************************************************************/
Console.WriteLine($"Inline Arrays examples");

var inlineArray = new InlineArrayDemo();
for (int i = 0; i < 10; i++)
{
    inlineArray[i] = i;
}

foreach (var item in inlineArray)
{
    Console.Write($"{item} ");
}