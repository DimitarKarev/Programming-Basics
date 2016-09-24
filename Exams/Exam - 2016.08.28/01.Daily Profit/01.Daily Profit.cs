using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Daily_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var dolarValue = double.Parse(Console.ReadLine());
            var totalProfit = 14.5 * n * m;
            double profitAfterTaxes = totalProfit * 0.75;
            double totalProfitinLeva = profitAfterTaxes * dolarValue;
            double levaPerDay = totalProfitinLeva / 365.0;
           
            Console.WriteLine("{0:f2}", levaPerDay);
        }
    }
}
