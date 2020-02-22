using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int workingExperiencer { get; set; }

        public override string ToString()
        {
            return $"Служащий: {Name}, {Profession}, {workingExperiencer}";
        }

        public Employee(string name, string profession, int WorkingExperiencer)
        {
            Name = name;
            Profession = profession;
            workingExperiencer = WorkingExperiencer;
        }
    }
}
