using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете Страна а = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Въведете Страна b = ");
            var b = double.Parse(Console.ReadLine());
            Console.Write("Въведете Височината h = ");
            var h = double.Parse(Console.ReadLine());
            Console.Write("Лицето на трапеца = ");
            Console.WriteLine((a + b) * h / 2);
        }
    }
}
