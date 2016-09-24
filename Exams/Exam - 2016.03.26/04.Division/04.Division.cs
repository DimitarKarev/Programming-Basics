using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var counter2 = 0;
            var counter3 = 0;
            var counter4 = 0;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num % 2 == 0) counter2++;
                if (num % 3 == 0) counter3++;
                if (num % 4 == 0) counter4++;

            }
            double percentDivisionOn2 = Math.Round(counter2 * 100.0 / n,2);
            double percentDivisionOn3 = Math.Round(counter3 * 100.0 / n, 2);
            double percentDivisionOn4 = Math.Round(counter4 * 100.0 / n, 2);
            Console.WriteLine("{0:f2}%",percentDivisionOn2);
            Console.WriteLine("{0:f2}%", percentDivisionOn3);
            Console.WriteLine("{0:f2}%", percentDivisionOn4);
        }
    }
}
