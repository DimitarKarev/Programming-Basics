using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var counter1 = 0;
            var counter2 = 0;
            var counter3 = 0;
            var counter4 = 0;
            var counter5 = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num < 200) counter1++;
                else if (num >= 200 && num <= 399) counter2++;
                else if (num >= 400 && num <= 599) counter3++;
                else if (num >= 600 && num <= 799) counter4++;
                else counter5++;
            }
            double p1 = Math.Round((counter1 * 100.00 / n), 2);
            double p2 = Math.Round((counter2 * 100.00 / n), 2);
            double p3 = Math.Round((counter3 * 100.00 / n), 2);
            double p4 = Math.Round((counter4 * 100.00 / n), 2);
            double p5 = Math.Round((counter5 * 100.00 / n), 2);
            Console.WriteLine("{0:f2}%",p1);
            Console.WriteLine("{0:f2}%",p2);
            Console.WriteLine("{0:f2}%",p3);
            Console.WriteLine("{0:f2}%",p4);
            Console.WriteLine("{0:f2}%",p5);
        }
    }
}
