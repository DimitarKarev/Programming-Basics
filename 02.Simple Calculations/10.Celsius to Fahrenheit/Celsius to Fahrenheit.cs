using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете градуси C = ");
            var C = double.Parse(Console.ReadLine());
            var F = (C * 1.8) + 32;
            Console.Write("Градуси F = ");
            Console.WriteLine(Math.Round(F, 2));
        }
    }
}
