using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hierarchy2
{
    class Video : Content
    {
        public int Lenght { get; set; }

        public override string ToString()
        {
            return $"{Lenght}";
        }
        public Video(int id, string name, DateTime uploudDate, int lenght) : base(id, name, uploudDate)
        {
            Lenght = lenght;
        }
    }
}
