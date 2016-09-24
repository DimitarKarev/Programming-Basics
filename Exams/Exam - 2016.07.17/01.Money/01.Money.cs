using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitkoins = int.Parse(Console.ReadLine());
            double uans = double.Parse(Console.ReadLine());
            double procentComision = double.Parse(Console.ReadLine());
            double bitkoinsInLeva = bitkoins * 1168;
            double uansInLeva = uans * 0.15 * 1.76;
            double totalInEvro = (bitkoinsInLeva + uansInLeva) / 1.95;
            double total = totalInEvro - totalInEvro * procentComision / 100;
            Console.WriteLine(total);
        }
    }
}
