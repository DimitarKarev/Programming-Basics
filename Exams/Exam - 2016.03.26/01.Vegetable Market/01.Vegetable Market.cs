using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegPrice = double.Parse(Console.ReadLine());
            var fruitPrice = double.Parse(Console.ReadLine());
            var vegKgs = int.Parse(Console.ReadLine());
            var fruitKgs = int.Parse(Console.ReadLine());
            var profit = (vegKgs * vegPrice + fruitKgs * fruitPrice) / 1.94;
            Console.WriteLine(profit);
        }
    }
}
