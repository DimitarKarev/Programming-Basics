using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter r = ");
            var r = double.Parse(Console.ReadLine());
            Console.Write("Area = ");
            Console.WriteLine(Math.PI * r * r);
            Console.Write("Perimeter = ");
            Console.WriteLine(2 * Math.PI * r);
        }
    }
}
