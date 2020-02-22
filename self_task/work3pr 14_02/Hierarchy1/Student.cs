using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hierarchy1
{
    class Student : Person
    {
        
            public int Course { get; set; }
        public string Group { get; set; }

        public override string ToString()
        {
            base.ToString();
            return $"Person: {Course}, {Group}";
        }

        public Student(string name, int age, int course, string group) : base(name, age)
        {
            Course = course;
            Group = group;
        }

        public void NextCourse()
        {
            Course++;
        }
    }
}
