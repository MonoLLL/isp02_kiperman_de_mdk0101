using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hierarchy1
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Person: {Name}, {Age}";
        }

        public void PrintFullInfo()
        {
            Console.WriteLine(ToString());
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
