using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Test
    {
        public string NSMExaminee { get; set; }
        public string NSMExaminer { get; set; }
        public DateTime Date;
        public int Estimation { get; set; }


        public override string ToString()
        {
            return $"Цех: {NSMExaminee}, {NSMExaminer}, {Estimation}, {Date.ToString("dd.MM.yyyy")}";
        }

        public Test(string nSMExaminee, string nSMExaminer, DateTime date, int estimation)
        {
            NSMExaminee = nSMExaminee;
            NSMExaminer = nSMExaminer;
            Date = date;
            Estimation = estimation;
        }
    }
}
