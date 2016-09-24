using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Date_after_5_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = 2015;
            DateTime firstDate = new DateTime(year, month, days);
            DateTime secondDate = firstDate.AddDays(5);
            Console.WriteLine(secondDate.ToString("d.MM"));
        }
    }
}
