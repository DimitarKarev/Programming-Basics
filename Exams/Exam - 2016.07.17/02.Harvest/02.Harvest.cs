using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var z = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var harvest = x * y * 0.4;
            var wine = harvest / 2.5;
            if (wine < z)
            {
                var wineNeeded = Math.Floor(z - wine);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",wineNeeded);
            }
            else
            {
                var totalWine = Math.Floor(wine);
                var wineLeft = Math.Ceiling(wine - z);
                var winePerWorker = Math.Ceiling(wineLeft/workers);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",totalWine);
                Console.WriteLine("{0} liters left -> {1} liters per person.",wineLeft ,winePerWorker);
            }
        }
    }
}
