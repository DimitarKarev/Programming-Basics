using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var input = (Console.ReadLine());
            var output = (Console.ReadLine());

            if (input == "mm") value /= 1000;
            else if (input == "cm") value /= 100;
            else if (input == "mi") value /= 0.000621371192;
            else if (input == "in") value /= 39.3700787;
            else if (input == "km") value /= 0.001;
            else if (input == "ft") value /= 3.2808399;
            else if (input == "yd") value /= 1.0936133;
            else  value /= 1;
           
            if (output == "mm") value *= 1000;
            else if (output == "cm") value *= 100;
            else if (output == "mi") value *= 0.000621371192;
            else if (output == "in") value *= 39.3700787;
            else if (output == "km") value *= 0.001;
            else if (output == "ft") value *= 3.2808399;
            else if (output == "yd") value *= 1.0936133;
            else  value *= 1;
            Console.WriteLine($"{value} {output}");
        }
    }
}
