using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете rad = ");
            var rad = double.Parse(Console.ReadLine());
            var deg = rad * (180 / Math.PI);
            Console.Write("deg = ");
            Console.WriteLine(Math.Round(deg, 2));
        }
    }
}
