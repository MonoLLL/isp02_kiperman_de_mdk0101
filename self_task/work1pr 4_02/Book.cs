using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        public string Title { get; set; }
        public string[] ListOfAuthors;
        public int Price { get; set; }


        public override string ToString()
        {
            string result = default;
            int counter = 0;
            foreach (var auth in ListOfAuthors)
            {
                result += auth;
                counter++;
                Console.Write($"{counter}. {auth}, ");
            }

            return $"{Title}, {Price}";
        }

        public Book(string title, string[] listOfAuthors, int price)
        {
            Title = title;
            ListOfAuthors = listOfAuthors;
            Price = price;
        }
    }
}
