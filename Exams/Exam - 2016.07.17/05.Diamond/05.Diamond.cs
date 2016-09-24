using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p = 0;
            Console.WriteLine("{0}{1}{0}",new string('.',n) ,new string('*', 3 * n));
            for (int row = 1; row < n; row++)
            {
            Console.WriteLine("{0}*{1}*{0}",new string('.', n - row), new string('.', 3 * n + p));
             p += 2;
            }
            Console.WriteLine(new string('*', 5 * n)); p = 0;
            for (int row = 1; row <= 2* n ; row++)
            {
            Console.WriteLine("{0}*{1}*{0}",new string('.',row), new string('.', 5 * n - 4 - p));
             p += 2;
            }
            Console.WriteLine("{0}{1}{0}",new string('.', (4 * n + 2)/2), new string('*', n - 2));
        }
    }
}
