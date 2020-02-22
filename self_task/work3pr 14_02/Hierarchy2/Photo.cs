using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Hierarchy2
{
    class Photo : Content
    {
        public string WhoIsOnPicture { get; set; }

        public override string ToString()
        {
            return $"{WhoIsOnPicture}";
        }
        public Photo(int id, string name, DateTime uploudDate, string whoIsOnPicture) : base(id, name, uploudDate)
        {
            WhoIsOnPicture = whoIsOnPicture;
        }
    }
}
