using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hierarchy2
{
    class Content
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime UploudDate { get; set; }

        public override string ToString()
        {
            return $"{Id},{Name},{UploudDate.ToString("dd.MM.yyyy")}";
        }
        public Content(int id, string name, DateTime uploudDate)
        {
            Id = id;
            Name = name;
            UploudDate = uploudDate;
        }
    }
}
