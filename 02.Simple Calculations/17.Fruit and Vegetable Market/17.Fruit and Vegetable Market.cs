using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Fruit_and_Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegs = double.Parse(Console.ReadLine());
            var fruits = double.Parse(Console.ReadLine());
            var vegPrice = int.Parse(Console.ReadLine());
            var fruitPrice = int.Parse(Console.ReadLine());
            var sumVeg = (vegPrice * vegs)/1.94;
            var sumFruit = (fruits * fruitPrice)/1.94;
            var harvest = sumFruit + sumVeg;
            Console.WriteLine(harvest);
        }
    }
}
