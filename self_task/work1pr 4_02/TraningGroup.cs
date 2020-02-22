using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TraningGroup
    {
        public int Cipher { get; set; }
        public int NumberOfStudents { get; set; }
        public DateTime YaerFormation { get; set; }
        public string Specialty { get; set; }

        public override string ToString()
        {
            return $"TrainingGroup: {Cipher}, {NumberOfStudents}, {YaerFormation.ToString("dd.MM.yyyy")},{Specialty}";
        }

        public TraningGroup(int cipher, int numberOfStudents, DateTime yaerFormation, string specialty)
        {
            Cipher = cipher;
            NumberOfStudents = numberOfStudents;
            YaerFormation = yaerFormation;
            Specialty = specialty;
        }
    }
}
