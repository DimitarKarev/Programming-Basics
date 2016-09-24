using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете Страната а = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Въведете Страната h = ");
            var h = double.Parse(Console.ReadLine());
            var area = ((a * h) / 2);
            Console.Write("Лицето на Триъгълника е ");
            Console.WriteLine(Math.Round(area, 2));
        }
    }
}
