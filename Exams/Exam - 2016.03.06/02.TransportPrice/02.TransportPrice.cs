using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double price = 0;
            if (n < 20)
            {
                if (dayOrNight == "day") price = 0.7 + (n * 0.79);
                if (dayOrNight == "night") price = 0.7 + (n * 0.9);
            }
            if (n >= 20 && n < 100) price = (n * 0.09);
            if (n >= 100) price = (n * 0.06);
            Console.WriteLine(price);
        }
    }
}
