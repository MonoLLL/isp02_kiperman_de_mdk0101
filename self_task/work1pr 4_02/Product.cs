using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }
        public DateTime ShelfLife;


        public override string ToString()
        {
            return $"Product: {Name}, {Quantity}, {Cost}, {ShelfLife.ToString("dd.MM.yyyy")}";
        }

        public Product(string name, int quantity, int cost, DateTime shelfLife)
        {
            Name = name;
            Quantity = quantity;
            Cost = cost;
            ShelfLife = shelfLife;

        }
    }
}
