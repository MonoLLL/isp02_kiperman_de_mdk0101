using ConsoleApp1.Hierarchy1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Киперман
      
        static void Main(string[] args)
        {
            Student stud1 = new Student(name: "Иван",age: 10, course: 3, group: "isp-2") ;
            Student stud2 = new Student(name: "Петя",age: 19, course: 1, group: "isp-2");

            string[] predmet = new string[] { "Музыка" };
            Teacher tech = new Teacher(name: "Фредди Меркьюри", age: 45, disceplines: predmet);



            Person[] peoples = new Person[4];
            peoples[0] = stud1;
            peoples[1] = stud2;
            peoples[2] = tech;

            foreach (var i in peoples)
            {             
                Console.WriteLine($"{i}");
            }

            Console.ReadKey();
        }
    }
}
