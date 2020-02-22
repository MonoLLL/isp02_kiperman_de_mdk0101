using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hierarchy1
{
    class Teacher : Person
    {
        public string[] Disceplines { get; set; }

        public Teacher(string name, int age, string[] disceplines) : base(name, age)
        {
            Disceplines = disceplines;
        }


        public void RemoveElement(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    array[i] = array[array.Length - 1];
                    Array.Resize(ref array, array.Length - 1);
                    break;
                }
            }
        }
    }
}
