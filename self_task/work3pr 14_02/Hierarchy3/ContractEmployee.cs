using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hierarchy3
{
    class ContractEmployee : Employee
    {
        public float PayPerHour { get; set; }
        public string ContractPeriod { get; set; }

        public override string ToString()
        {
            return $"{PayPerHour}, {ContractPeriod}";
        }
        public ContractEmployee(int id, string name, float payPerHour, string contractPeriod) : base(id, name)
        {
            PayPerHour = payPerHour;
            ContractPeriod = contractPeriod;
        }
    }
}
