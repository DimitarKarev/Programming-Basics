using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            double workinghours = days * 0.90 * 8;
            var overtimehours = days * workers * 2;
            double totalHours = Math.Floor(workinghours + overtimehours);
            var extraHours = Math.Abs(totalHours - hours);
            if (totalHours >= hours) Console.WriteLine("Yes!{0} hours left.", extraHours);
            else Console.WriteLine("Not enough time!{0} hours needed.", extraHours);
        }
    }
}
