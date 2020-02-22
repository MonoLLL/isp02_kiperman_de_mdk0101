using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hierarchy3
{
    class RegularEmployee : Employee
    {
        public float Salary { get; set; }
        public int Bonus { get; set; }

        public override string ToString()
        {
            return $"{Salary}, {Bonus}";
        }
        public RegularEmployee(int id, string name, float salary, int bonus) : base(id, name)
        {
            Salary = salary;
            Bonus = bonus;
        }
    }
}
