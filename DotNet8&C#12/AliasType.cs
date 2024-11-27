using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person = (string name, int age, string country);

namespace DotNet8_C_12
{
    public class AliasType
    {
        public Person GetPerson()
        {
            Person person = new("Name", 33, "Country");

            return person;
        }

        public void PrintPerson(Person person)
        {
            Console.WriteLine($"{person.name}, {person.age}, {person.country}");
        }
    }
}
