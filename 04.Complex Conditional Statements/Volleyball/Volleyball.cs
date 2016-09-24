using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            var inSofia = (48 - h)*3.0/4;
            var holyday = p * 2.0 / 3;
            var games = (inSofia + holyday + h);
            if (year == "leap")
            {
                Console.WriteLine(Math.Floor(games * 1.15));
            }
            else
            {
                Console.WriteLine(Math.Floor(games));
            }
        }
    }
}
