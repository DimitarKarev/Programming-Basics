using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var r = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());
            if (type == "Premiere") Console.WriteLine("{0:f2} leva", (r * c * 12) );
            else if(type == "Normal") Console.WriteLine("{0:f2} leva", (r * c * 7.5));
            else if(type == "Discount") Console.WriteLine("{0:f2} leva" , (r * c * 5));

        }
    }
}
